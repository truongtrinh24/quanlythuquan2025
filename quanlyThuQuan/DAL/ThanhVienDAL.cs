using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using quanlyThuQuan.DTO;

namespace quanlyThuQuan.DAL
{
    internal class ThanhVienDAL
    {
        public List<ThanhVienDTO> GetAllThanhVien()
        {
            List<ThanhVienDTO> list = new List<ThanhVienDTO>();
            string query = "SELECT user_id, full_name, gender, birthday, phone, branch, class, science, mssv  FROM users WHERE status = 1";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ThanhVienDTO tv = new ThanhVienDTO
                    {
                        UserId = reader.GetInt32("user_id"),
                        FullName = reader.GetString("full_name"),
                        Gender = reader.GetString("gender"),
                        Birthday = reader.GetDateTime("birthday"),
                        Phone = reader.GetString("phone"),
                        Branch = reader.GetString("branch"),
                        Class = reader.GetString("class"),
                        Science = reader.GetString("science"),
                        MSSV = reader.GetString("mssv")
                    };
                    list.Add(tv);
                }
            }

            return list;
        }

        public ThanhVienDTO GetThanhVienByMSSV(string mssv)
        {
            string query = "SELECT * FROM users WHERE mssv = @mssv";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mssv", mssv);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ThanhVienDTO
                        {
                            UserId = reader.GetInt32("user_id"), // Thêm dòng này để lấy UserId
                            FullName = reader["full_name"].ToString(),
                            MSSV = reader["mssv"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Birthday = reader.GetDateTime("birthday"),
                            Gender = reader["gender"].ToString(),
                            Branch = reader["branch"].ToString(),
                            Class = reader["class"].ToString(),
                            Science = reader["science"].ToString(),
                            Status = reader.GetInt32("status") // Thêm dòng này để lấy cột status

                        };
                    }
                }
            }

            return null;  // Trả về null nếu không tìm thấy
        }
        public ThanhVienDTO GetThanhVienByTenVaSDT(string fullName, string phone)
{
    string query = "SELECT * FROM users WHERE full_name = @name AND phone = @phone";

    using (MySqlConnection conn = DBHelper.GetConnection())
    {
        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@name", fullName);
        cmd.Parameters.AddWithValue("@phone", phone);

        using (MySqlDataReader reader = cmd.ExecuteReader())
        {
            if (reader.Read())
            {
                return new ThanhVienDTO
                {
                    FullName = reader["full_name"].ToString(),
                    MSSV = reader["mssv"].ToString(),
                    Gender = reader["gender"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Birthday = Convert.ToDateTime(reader["birthday"]),
                    Branch = reader["branch"].ToString(),
                    Class = reader["class"].ToString(),
                    Science = reader["science"].ToString()
                };
            }
        }
    }

    return null;
}
         public ThanhVienDTO GetThanhVienById(int id)
        {
            ThanhVienDTO thanhVien = null;
            MySqlDataReader reader = null;
            try
            {
                MySqlConnection conn = DBHelper.GetConnection();
                string query = "SELECT * FROM users WHERE user_id = @Id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    thanhVien = new ThanhVienDTO
                    {
                        FullName = reader["full_name"].ToString(),
                        MSSV = reader["mssv"].ToString(),
                        Gender = reader["gender"].ToString(),
                        Birthday = Convert.ToDateTime(reader["birthday"]),
                        Phone = reader["phone"].ToString(),
                        Science = reader["science"].ToString(),
                        Class = reader["class"].ToString(),
                        Branch = reader["branch"].ToString(),
                        DateCreate = Convert.ToDateTime(reader["date_create"])
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetThanhVienById: {ex.Message}");
                return null;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
            }
            return thanhVien;
        }
        public bool ThemThanhVien(ThanhVienDTO tv)
        {
            string query = "INSERT INTO users (full_name, mssv, phone, branch, class, science, gender, birthday, status) " +
                           "VALUES (@fullName, @mssv, @phone, @branch, @class, @science, @gender, @birthday, 1)"; // status = 1 là hoạt động

            using (var conn = DBHelper.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Thêm tham số vào câu truy vấn
                    cmd.Parameters.AddWithValue("@fullName", tv.FullName);
                    cmd.Parameters.AddWithValue("@mssv", tv.MSSV);
                    cmd.Parameters.AddWithValue("@phone", tv.Phone);
                    cmd.Parameters.AddWithValue("@branch", tv.Branch);
                    cmd.Parameters.AddWithValue("@class", tv.Class);
                    cmd.Parameters.AddWithValue("@science", tv.Science);
                    cmd.Parameters.AddWithValue("@gender", tv.Gender);
                    cmd.Parameters.AddWithValue("@birthday", tv.Birthday);

                    return cmd.ExecuteNonQuery() > 0;  // Nếu số dòng bị ảnh hưởng > 0 thì trả về true
                }
            }
        }
        public bool UpdateThanhVien(ThanhVienDTO tv)
        {
            string query = @"UPDATE users 
              SET full_name = @name, phone = @phone, birthday = @birthday, 
                  gender = @gender, branch = @branch, class = @class, science = @science, mssv = @mssv 
              WHERE user_id = @userId";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", tv.FullName);
                cmd.Parameters.AddWithValue("@phone", tv.Phone);
                cmd.Parameters.AddWithValue("@birthday", tv.Birthday);
                cmd.Parameters.AddWithValue("@gender", tv.Gender);
                cmd.Parameters.AddWithValue("@branch", tv.Branch);
                cmd.Parameters.AddWithValue("@class", tv.Class);
                cmd.Parameters.AddWithValue("@science", tv.Science);
                cmd.Parameters.AddWithValue("@mssv", tv.MSSV); // ✅ FIXED!
                cmd.Parameters.AddWithValue("@userId", tv.UserId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteThanhVien(int userId)
        {
            string query = "UPDATE users SET status = 0 WHERE user_id = @userId";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteThanhVienByYear(int year)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "UPDATE users SET status = 0 WHERE YEAR(date_create) = @year AND status = 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@year", year);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }


    }
}
