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
    internal class DeviceDAL
    {
        // Lấy danh sách tất cả thiết bị dưới dạng List<DeviceDTO>
        public List<DeviceDTO> GetAllDevices()
        {
            List<DeviceDTO> devices = new List<DeviceDTO>();
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = @"
                SELECT d.device_id, d.device_name, d.status_id, ds.status_name, d.description, d.created_at, d.category_id
                FROM devices d
                LEFT JOIN device_status ds ON d.status_id = ds.status_id
                WHERE d.is_deleted = 0"; // Chỉ lấy thiết bị chưa bị xóa
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DeviceDTO device = new DeviceDTO
                                {
                                    DeviceId = reader.GetInt32("device_id"),
                                    DeviceName = reader.GetString("device_name"),
                                    StatusId = reader.GetInt32("status_id"),
                                    StatusName = reader.GetString("status_name"),
                                    Description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description"),
                                    CreatedAt = reader.GetDateTime("created_at"),
                                    CategoryId = reader.IsDBNull(reader.GetOrdinal("category_id")) ? null : reader.GetString("category_id")
                                };
                                devices.Add(device);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách thiết bị: " + ex.Message);
            }
            return devices;
        }
        // Lấy danh sách danh mục thiết bị
        public List<CategoryDeviceDTO> GetDeviceCategories()
        {
            List<CategoryDeviceDTO> categories = new List<CategoryDeviceDTO>();
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT id, category_id, category_name FROM category_device";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CategoryDeviceDTO category = new CategoryDeviceDTO
                                {
                                    Id = reader.GetInt32("id"),
                                    CategoryId = reader.GetString("category_id"),
                                    CategoryName = reader.GetString("category_name")
                                };
                                categories.Add(category);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách danh mục thiết bị: " + ex.Message);
            }
            return categories;
        }
        public DeviceDTO GetDeviceById(int deviceId)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "SELECT device_id, device_name, status_id, category_id, description FROM devices WHERE device_id = @deviceId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@deviceId", deviceId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DeviceDTO device = new DeviceDTO
                        {
                            DeviceId = reader.GetInt32("device_id"),
                            DeviceName = reader.GetString("device_name"),
                            StatusId = reader.GetInt32("status_id"),
                            CategoryId = reader.IsDBNull(reader.GetOrdinal("category_id")) ? null : reader.GetString("category_id"),
                            Description = reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString("description")
                        };
                        return device;
                    }
                }
                return null;
            }
        }
        public bool UpdateDeviceStatus(int deviceId, int statusId)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "UPDATE devices SET status_id = @statusId WHERE device_id = @deviceId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@statusId", statusId);
                cmd.Parameters.AddWithValue("@deviceId", deviceId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Lấy danh sách trạng thái thiết bị
        public List<DeviceStatusDTO> GetDeviceStatuses()
        {
            List<DeviceStatusDTO> statuses = new List<DeviceStatusDTO>();
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT status_id, status_name FROM device_status";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DeviceStatusDTO status = new DeviceStatusDTO
                                {
                                    StatusId = reader.GetInt32("status_id"),
                                    StatusName = reader.GetString("status_name")
                                };
                                statuses.Add(status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách trạng thái: " + ex.Message);
            }
            return statuses;
        }

        // Thêm thiết bị mới
        public bool AddDevice(DeviceDTO device)
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "INSERT INTO devices (device_name, status_id, description, created_at, category_id) " +
                                   "VALUES (@DeviceName, 1, @Description, @CreatedAt, @CategoryId)"; // status_id mặc định là 1 (Sẵn sàng)
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DeviceName", device.DeviceName);
                        cmd.Parameters.AddWithValue("@Description", device.Description);
                        cmd.Parameters.AddWithValue("@CreatedAt", device.CreatedAt);
                        cmd.Parameters.AddWithValue("@CategoryId", device.CategoryId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thiết bị: " + ex.Message);
            }
        }
        // Cập nhật thông tin thiết bị
        public bool UpdateDevice(DeviceDTO device)
        {
            MySqlConnection conn = DBHelper.GetConnection();
            try
            {
                string query = "UPDATE devices SET device_name = @DeviceName, category_id = @CategoryID, status_id = @StatusID, description = @Description WHERE device_id = @DeviceID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DeviceID", device.DeviceId);
                cmd.Parameters.AddWithValue("@DeviceName", device.DeviceName);
                cmd.Parameters.AddWithValue("@CategoryID", (object)device.CategoryId ?? DBNull.Value); // Xử lý null
                cmd.Parameters.AddWithValue("@StatusID", device.StatusId);
                cmd.Parameters.AddWithValue("@Description", device.Description ?? (object)DBNull.Value);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            finally
            {
                DBHelper.CloseConnection();
            }

        }
        public bool IsDeviceBeingBorrowed(int deviceId)
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM bookings WHERE device_id = @DeviceId AND status = 'Đang Mượn'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DeviceId", deviceId);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra trạng thái mượn thiết bị: " + ex.Message);
            }
        }
        public bool DeleteDevice(int deviceId)
        {
            try
            {
                using (MySqlConnection conn = DBHelper.GetConnection())
                {
                    string query = "UPDATE devices SET is_deleted = 1 WHERE device_id = @DeviceId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DeviceId", deviceId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thiết bị: " + ex.Message);
            }
        }
        public bool IsDeviceBorrowed(int deviceId)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                // Sử dụng cột 'status' thay vì 'status_id'
                string query = "SELECT COUNT(*) FROM bookings WHERE device_id = @DeviceId AND status = 'Đang mượn'";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DeviceId", deviceId);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool SoftDeleteDevicesByCategory(string categoryId)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                // Chỉ cập nhật các thiết bị chưa bị xóa mềm (is_deleted = 0)
                string query = "UPDATE devices SET is_deleted = 1 WHERE category_id = @CategoryId AND is_deleted = 0";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public List<DeviceDTO> SearchDevices(string keyword = "", string categoryId = "")
        {
            List<DeviceDTO> devices = new List<DeviceDTO>();

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = @"
            SELECT d.device_id, d.device_name, d.status_id, d.description, d.category_id, d.created_at, d.is_deleted, s.status_name
            FROM devices d
            JOIN device_status s ON d.status_id = s.status_id
            WHERE d.is_deleted = 0";

                // Thêm điều kiện tìm kiếm theo tên thiết bị
                if (!string.IsNullOrWhiteSpace(keyword))
                {
                    query += " AND d.device_name LIKE @Keyword";
                }

                // Thêm điều kiện lọc theo mã quy định
                if (!string.IsNullOrWhiteSpace(categoryId))
                {
                    query += " AND d.category_id = @CategoryId";
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    }

                    if (!string.IsNullOrWhiteSpace(categoryId))
                    {
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DeviceDTO device = new DeviceDTO
                            {
                                DeviceId = Convert.ToInt32(reader["device_id"]),
                                DeviceName = reader["device_name"].ToString(),
                                StatusId = Convert.ToInt32(reader["status_id"]),
                                Description = reader["description"].ToString(),
                                CategoryId = reader["category_id"].ToString(),
                                CreatedAt = Convert.ToDateTime(reader["created_at"]),
                                IsDeleted = Convert.ToInt32(reader["is_deleted"]),
                                StatusName = reader["status_name"].ToString()
                            };
                            devices.Add(device);
                        }
                    }
                }
            }

            return devices;
        }
    }
}
