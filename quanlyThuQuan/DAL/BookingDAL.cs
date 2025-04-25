using MySql.Data.MySqlClient;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DAL
{
    internal class BookingDAL
    {
        public bool CreateBooking(BookingDTO booking)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "INSERT INTO bookings (user_id, device_id, start_time, end_time, status, created_at) " +
                              "VALUES (@userId, @deviceId, @startTime, @endTime, @status, @createdAt)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", booking.UserId);
                cmd.Parameters.AddWithValue("@deviceId", booking.DeviceId);
                cmd.Parameters.AddWithValue("@startTime", booking.StartTime);
                cmd.Parameters.AddWithValue("@endTime", booking.EndTime);
                cmd.Parameters.AddWithValue("@status", booking.Status);
                cmd.Parameters.AddWithValue("@createdAt", booking.CreatedAt);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Kiểm tra bản ghi mượn dựa trên mssv và device_id
        public BookingDTO GetBookingByMSSVAndDeviceId(string mssv, int deviceId)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = @"SELECT b.booking_id, b.user_id, b.device_id, b.start_time, b.end_time, b.status, b.created_at, b.actual_time
                                FROM bookings b
                                JOIN users u ON b.user_id = u.user_id
                                WHERE u.mssv = @mssv AND b.device_id = @deviceId AND b.status = 'Đang mượn'
                                ORDER BY b.created_at DESC
                                LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                cmd.Parameters.AddWithValue("@deviceId", deviceId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new BookingDTO
                        {
                            BookingId = reader.GetInt32("booking_id"), // Gán BookingId
                            UserId = reader.GetInt32("user_id"),
                            DeviceId = reader.GetInt32("device_id"),
                            StartTime = reader.GetDateTime("start_time"),
                            EndTime = reader.GetDateTime("end_time"),
                            Status = reader.GetString("status"),
                            CreatedAt = reader.GetDateTime("created_at"),
                            ActualTime = reader.IsDBNull(reader.GetOrdinal("actual_time")) ? (DateTime?)null : reader.GetDateTime("actual_time")
                        };
                    }
                }
                return null;
            }
        }

        public bool UpdateBookingOnReturn(int bookingId, string status, DateTime actualTime)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "UPDATE bookings SET status = @status, actual_time = @actualTime WHERE booking_id = @bookingId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@actualTime", actualTime);
                cmd.Parameters.AddWithValue("@bookingId", bookingId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
