using MySql.Data.MySqlClient;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DAL
{
    internal class CheckInDAL
    {
        public bool AddCheckIn(CheckInDTO checkIn)
        {
            try
            {
                MySqlConnection conn = DBHelper.GetConnection();
                string query = "INSERT INTO checkins (user_id, checkin_time) VALUES (@UserId, @CheckInTime)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", checkIn.UserId);
                cmd.Parameters.AddWithValue("@CheckInTime", checkIn.CheckInTime);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddCheckIn: {ex.Message}");
                return false;
            }
        }
    }
}
