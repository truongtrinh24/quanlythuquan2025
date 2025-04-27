using MySql.Data.MySqlClient;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DAL
{
    public class ViolateDAL
    {
        public void UpdateViolation(DTO.ViolationDTO violation)
        {
            var connection = DBHelper.GetConnection();
            try
            {
                string query = "UPDATE violations " +
                               "SET fine_amount = @fine_amount, description = @description, " +
                               "violation_time = @violation_time " +
                               "WHERE violation_id = @violation_id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@fine_amount", violation.FineAmount);
                    command.Parameters.AddWithValue("@description", violation.Description ?? (object)DBNull.Value);  
                   
                    command.Parameters.AddWithValue("@violation_time", DateTime.Now);  
                    command.Parameters.AddWithValue("@violation_id", violation.ViolationId);  
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật vi phạm: " + ex.Message);
            }
            finally
            {
                DBHelper.CloseConnection();
            }
        }
        public void UpdateUserStatus(int? userId, byte status)
        {
            var connection = DBHelper.GetConnection();
            try
            {
                string query = "UPDATE users SET status = @status WHERE user_id = @user_id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật trạng thái người dùng: " + ex.Message);
            }
            finally
            {
                DBHelper.CloseConnection();
            }
        }

        public void DeleteViolation(int? violationId)
        {
            var connection = DBHelper.GetConnection();
            try
            {
                string query = "DELETE FROM violations WHERE violation_id = @violation_id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@violation_id", violationId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa vi phạm: " + ex.Message);
            }
            finally
            {
                DBHelper.CloseConnection();
            }
        }

        public List<DTO.ViolationDTO> GetAllViolations()
        {
            var connection = DBHelper.GetConnection();
            List<ViolationDTO> list = new List<ViolationDTO>();
            try
            {
                string query = "SELECT * FROM violations";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ViolationDTO
                            {
                                ViolationId = reader["violation_id"] != DBNull.Value ? reader.GetInt32("violation_id") : null,
                                UserId = reader["user_id"] != DBNull.Value ? reader.GetInt32("user_id") : null,
                                DeviceId = reader["device_id"] != DBNull.Value ? reader.GetInt32("device_id") : null,
                                BookingId = reader["booking_id"] != DBNull.Value ? reader.GetInt32("booking_id") : null,
                                Description = reader["description"] != DBNull.Value ? reader.GetString("description") : null,
                                FineAmount = reader["fine_amount"] != DBNull.Value ? reader.GetDecimal("fine_amount") : null,
                                ViolationTime = reader["violation_time"] != DBNull.Value ? reader.GetDateTime("violation_time") : null,
                             
                            });
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách vi phạm: " + ex.Message);
            }
            finally
            {
                DBHelper.CloseConnection();
            }
        }


        public List<DTO.ViolationDTO> GetViolationsByUserId(int? userId)
        {
            var connection = DBHelper.GetConnection();
            List<ViolationDTO> list = new List<ViolationDTO>();
            try
            {
                string query = "SELECT * FROM violations WHERE user_id = @user_id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", userId ?? (object)DBNull.Value);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new ViolationDTO
                            {
                                ViolationId = reader["violation_id"] != DBNull.Value ? reader.GetInt32("violation_id") : null,
                                UserId = reader["user_id"] != DBNull.Value ? reader.GetInt32("user_id") : null,
                                DeviceId = reader["device_id"] != DBNull.Value ? reader.GetInt32("device_id") : null,
                                BookingId = reader["booking_id"] != DBNull.Value ? reader.GetInt32("booking_id") : null,
                                Description = reader["description"] != DBNull.Value ? reader.GetString("description") : null,
                                FineAmount = reader["fine_amount"] != DBNull.Value ? reader.GetDecimal("fine_amount") : null,
                                ViolationTime = reader["violation_time"] != DBNull.Value ? reader.GetDateTime("violation_time") : null,
                              
                            });
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách vi phạm theo user_id: " + ex.Message);
            }
            finally
            {
                DBHelper.CloseConnection();
            }
        }


        public List<BookingDTO> GetLateBookings()
        {
            var connection = DBHelper.GetConnection();
            List<BookingDTO> list = new List<BookingDTO>();
            try
            {
                string query = "SELECT * FROM bookings ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new BookingDTO
                            {
                                BookingId = reader.GetInt32("booking_id"),
                                UserId = reader.GetInt32("user_id"),
                                DeviceId = reader.GetInt32("device_id"),
                                StartTime = reader.GetDateTime("start_time"),
                                EndTime = reader.GetDateTime("end_time"),
                                Status = reader.GetString("status"),
                                CreatedAt = reader.GetDateTime("created_at"),
                                ActualTime = reader.GetDateTime("actual_time")
                            });
                        }
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách booking trả muộn: " + ex.Message);
            }
            finally
            {
                DBHelper.CloseConnection();
            }
        }
        public void AddViolation(DTO.ViolationDTO violation)
        {
            var connection = DBHelper.GetConnection();
            try
            {
                string query = "INSERT INTO violations (user_id, device_id, booking_id, fine_amount, description, violation_time) " +
                              "VALUES (@user_id, @device_id, @booking_id, @fine_amount, @description, @violation_time)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@user_id", violation.UserId ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@device_id", violation.DeviceId ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@booking_id", violation.BookingId ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@fine_amount", violation.FineAmount ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@description", violation.Description ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@violation_time", violation.ViolationTime ?? DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm vi phạm: " + ex.Message);
            }
            finally
            {
                DBHelper.CloseConnection();
            }
        }
    }
}

