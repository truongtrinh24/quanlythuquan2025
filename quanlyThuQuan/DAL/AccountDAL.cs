using MySql.Data.MySqlClient;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DAL
{
    internal class AccountDAL
    {
        public bool KiemTraDangNhap(string username, string password, out AccountDTO account)
        {
            account = null;
            string query = "SELECT * FROM account WHERE username = @username AND password = @password AND role_id = 1";

            using (var conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        account = new AccountDTO
                        {
                            AccountId = Convert.ToInt32(reader["account_id"]),
                            Username = reader["username"].ToString(),
                            Password = reader["password"].ToString(),
                            RoleId = Convert.ToInt32(reader["role_id"]),
                            CreatedAt = Convert.ToDateTime(reader["created_at"])
                        };
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
