using MySql.Data.MySqlClient;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DAL
{
    internal class CategoryDeviceDAL
    {
            public List<CategoryDeviceDTO> GetAllCategories()
            {
                List<CategoryDeviceDTO> categories = new List<CategoryDeviceDTO>();

                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT * FROM category_device";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CategoryDeviceDTO category = new CategoryDeviceDTO
                                {
                                    CategoryId = reader["category_id"].ToString(),
                                    CategoryName = reader["category_name"].ToString()
                                };
                                categories.Add(category);
                            }
                        }
                    }
                }

                return categories;
            }

            public bool AddCategory(CategoryDeviceDTO category)
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "INSERT INTO category_device (category_id, category_name) VALUES (@CategoryId, @CategoryName)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryId", category.CategoryId);
                        cmd.Parameters.AddWithValue("@CategoryName", category.CategoryName);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
    }
}

