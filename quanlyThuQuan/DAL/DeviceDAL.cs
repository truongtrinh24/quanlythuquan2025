using MySql.Data.MySqlClient;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.DAL
{
    internal class DeviceDAL
    {
        public DeviceDTO GetDeviceById(int deviceId)
        {
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                string query = "SELECT device_name, status_id FROM devices WHERE device_id = @deviceId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@deviceId", deviceId);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DeviceDTO device = new DeviceDTO
                        {
                            DeviceId = deviceId,
                            DeviceName = reader.GetString("device_name"),
                            StatusId = reader.GetInt32("status_id")
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
    }
}
