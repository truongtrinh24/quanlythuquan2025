using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using quanlyThuQuan.DTO;

namespace quanlyThuQuan.DAL
{
    internal class StatisticalDAL
    {
        public List<object> GetDeviceByCondition(DateTimePicker dateStart = null, DateTimePicker dateEnd = null, string deviceName = null, string type = null)
        {
            List<object> list = new List<object>();

           
            string query = @"
            SELECT b.booking_id, b.user_id, b.device_id, b.start_time, b.end_time, 
                   b.status, b.created_at, b.actual_time, d.device_name 
            FROM bookings b
            JOIN devices d ON b.device_id = d.device_id 
            WHERE 1=1";

  
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (type == "Lọc cả 2 điều kiện" && dateStart != null && dateEnd != null && !string.IsNullOrEmpty(deviceName))
            {
            
                query += " AND b.start_time <= @DateEnd AND b.end_time >= @DateStart";
          
                query += " AND LOWER(d.device_name) LIKE LOWER(@DeviceName)";

                parameters.Add(new MySqlParameter("@DateStart", dateStart.Value.Date));
                parameters.Add(new MySqlParameter("@DateEnd", dateEnd.Value.Date));
                parameters.Add(new MySqlParameter("@DeviceName", "%" + deviceName.ToLower() + "%"));
            }
            else if (type == "Lọc theo thời gian" && dateStart != null && dateEnd != null)
            {
                query += " AND b.start_time >= @DateStart AND b.end_time <= @DateEnd";

                parameters.Add(new MySqlParameter("@DateStart", dateStart.Value.Date));
                parameters.Add(new MySqlParameter("@DateEnd", dateEnd.Value.Date));
            }
            else if (type == "Lọc theo tên thiết bị" && !string.IsNullOrEmpty(deviceName))
            {
                query += " AND d.device_name LIKE @DeviceName";

                parameters.Add(new MySqlParameter("@DeviceName", "%" + deviceName + "%"));
            }


            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var booking = new
                            {
                                BookingId = reader.GetInt32("booking_id"),
                                UserId = reader.GetInt32("user_id"),
                                DeviceId = reader.GetInt32("device_id"),
                                DeviceName = reader.GetString("device_name"),
                                StartTime = reader.GetDateTime("start_time"),
                                EndTime = reader.GetDateTime("end_time"),
                                Status = reader.GetString("status"),
                                CreatedAt = reader.GetDateTime("created_at"),
                                ActualTime = reader.IsDBNull(reader.GetOrdinal("actual_time")) ? (DateTime?)null : reader.GetDateTime("actual_time")
                            };
                            list.Add(booking);
                        }
                    }
                }
            }

            return list;
        }


        //load data member in study


        public Dictionary<DateTime, int> GetMemberCheckInCountByDate(DateTime dateStart, DateTime dateEnd, string branch, string science)
        {
            Dictionary<DateTime, int> memberCountByDate = new Dictionary<DateTime, int>();

            // Kiểm tra đầu vào
            if (dateStart > dateEnd)
            {
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
            }

            // Truy vấn cơ bản
            string query = @"
                SELECT DATE(c.checkin_time) AS CheckInDate, 
                       COUNT(DISTINCT c.user_id) AS MemberCount
                FROM checkins c
                JOIN users u ON c.user_id = u.user_id
                WHERE c.checkin_time BETWEEN @DateStart AND @DateEnd";

                    List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@DateStart", dateStart.Date),
                new MySqlParameter("@DateEnd", dateEnd.Date.AddDays(1).AddSeconds(-1)) // Bao gồm cả ngày cuối
            };

            // Thêm điều kiện lọc theo branch (khoa)
            if (!string.IsNullOrEmpty(branch) && branch != "Tất cả")
            {
                query += " AND u.branch = @Branch";
                parameters.Add(new MySqlParameter("@Branch", branch));
            }

            // Thêm điều kiện lọc theo science (ngành)
            if (!string.IsNullOrEmpty(science) && science != "Tất cả")
            {
                query += " AND u.science = @Science";
                parameters.Add(new MySqlParameter("@Science", science));
            }

            query += " GROUP BY DATE(c.checkin_time) ORDER BY CheckInDate";

            // Thực thi truy vấn
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime checkInDate = reader.GetDateTime("CheckInDate");
                            int memberCount = reader.GetInt32("MemberCount");
                            memberCountByDate[checkInDate] = memberCount;
                        }
                    }
                }
            }

            // Đảm bảo có dữ liệu cho tất cả các ngày trong khoảng thời gian, nếu không có thì gán 0
            for (DateTime date = dateStart.Date; date <= dateEnd.Date; date = date.AddDays(1))
            {
                if (!memberCountByDate.ContainsKey(date))
                {
                    memberCountByDate[date] = 0;
                }
            }

            return memberCountByDate;
        }

        // Hàm GetMemberCheckInDetails (đã có từ trước, giữ nguyên để BUS sử dụng)
        public List<object> GetMemberCheckInDetails(DateTime dateStart, DateTime dateEnd, string science , string branch)
        {
            List<object> memberDetails = new List<object>();

            string query = @"
                SELECT u.full_name AS FullName, u.mssv AS MSSV, u.branch AS Branch, u.science AS Science, c.checkin_time AS CheckInTime
                FROM checkins c
                JOIN users u ON c.user_id = u.user_id
                WHERE c.checkin_time BETWEEN @DateStart AND @DateEnd";

            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@DateStart", dateStart.Date),
                new MySqlParameter("@DateEnd", dateEnd.Date.AddDays(1).AddSeconds(-1))
            };

            if (!string.IsNullOrEmpty(branch) && branch != "Tất cả")
            {
                query += " AND u.branch = @Branch";
                parameters.Add(new MySqlParameter("@Branch", branch));
            }

            if (!string.IsNullOrEmpty(science) && science != "Tất cả")
            {
                query += " AND u.science = @Science";
                parameters.Add(new MySqlParameter("@Science", science));
            }

            query += " ORDER BY c.checkin_time";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var member = new
                            {
                                FullName = reader.GetString("FullName"),
                                MSSV = reader.GetString("MSSV"),
                                Branch = reader.GetString("Branch"),
                                Science = reader.GetString("Science"),
                                CheckInTime = reader.GetDateTime("CheckInTime")
                            };
                            memberDetails.Add(member);
                        }
                    }
                }
            }

            return memberDetails;
        }
        public List<string> GetBranches()
        {
            List<string> branches = new List<string>();

            string query = "SELECT DISTINCT branch FROM users WHERE branch IS NOT NULL ORDER BY branch";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            branches.Add(reader.GetString("branch"));
                        }
                    }
                }
            }

            return branches;
        }

        // Lấy danh sách Science duy nhất
        public List<string> GetSciences()
        {
            List<string> sciences = new List<string>();

            string query = "SELECT DISTINCT science FROM users WHERE science IS NOT NULL ORDER BY science";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sciences.Add(reader.GetString("science"));
                        }
                    }
                }
            }

            return sciences;
        }

        public Dictionary<DateTime, (int MemberCount, List<object> MemberDetails)> GetAllMemberCheckInStats()
        {
            Dictionary<DateTime, (int MemberCount, List<object> MemberDetails)> stats = new Dictionary<DateTime, (int, List<object>)>();

            // Truy vấn lấy số lượng thành viên duy nhất và chi tiết thành viên mỗi ngày
            string query = @"
    SELECT DATE(c.checkin_time) AS CheckInDate,
           COUNT(DISTINCT c.user_id) AS MemberCount,
           u.user_id, u.full_name, u.gender, u.birthday, u.phone, u.branch, u.science, u.class, u.mssv, u.date_create, u.status,
           MIN(c.checkin_time) AS CheckInTime
    FROM checkins c
    JOIN users u ON c.user_id = u.user_id
    GROUP BY DATE(c.checkin_time), u.user_id
    ORDER BY DATE(c.checkin_time), u.user_id";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Dictionary<DateTime, List<object>> tempDetails = new Dictionary<DateTime, List<object>>();

                        while (reader.Read())
                        {
                            DateTime checkInDate = reader.GetDateTime("CheckInDate");
                            int memberCount = reader.GetInt32("MemberCount");

                            var memberDetail = new
                            {
                                UserId = reader.GetInt32("user_id"),
                                FullName = reader.GetString("full_name"),
                                Gender = reader.GetString("gender"),
                                Birthday = reader.IsDBNull(reader.GetOrdinal("birthday")) ? DateTime.MinValue : reader.GetDateTime("birthday"),
                                Phone = reader.IsDBNull(reader.GetOrdinal("phone")) ? "" : reader.GetString("phone"),
                                Branch = reader.IsDBNull(reader.GetOrdinal("branch")) ? "" : reader.GetString("branch"),
                                Science = reader.IsDBNull(reader.GetOrdinal("science")) ? "" : reader.GetString("science"),
                                Class = reader.IsDBNull(reader.GetOrdinal("class")) ? "" : reader.GetString("class"),
                                MSSV = reader.IsDBNull(reader.GetOrdinal("mssv")) ? "" : reader.GetString("mssv"),
                                DateCreate = reader.IsDBNull(reader.GetOrdinal("date_create")) ? DateTime.MinValue : reader.GetDateTime("date_create"),
                                Status = reader.GetInt32("status"),
                                CheckInTime = reader.GetDateTime("CheckInTime")
                            };

                            if (!tempDetails.ContainsKey(checkInDate))
                            {
                                tempDetails[checkInDate] = new List<object>();
                            }
                            tempDetails[checkInDate].Add(memberDetail);
                        }

          
                        foreach (var date in tempDetails.Keys)
                        {
                            int memberCount = tempDetails[date].Count; // Số lượng thành viên duy nhất
                            stats[date] = (memberCount, tempDetails[date]);
                        }
                    }
                }
            }

            return stats;
        }


        public List<object> GetViolationStatistics()
        {
            List<object> list = new List<object>();

            string query = @"
            SELECT v.description, 
                   COUNT(CASE WHEN v.handled_by IS NOT NULL THEN 1 END) as ProcessedCount,
                   COUNT(CASE WHEN v.handled_by IS NULL THEN 1 END) as UnprocessedCount,
                   SUM(v.fine_amount) as TotalFine
            FROM violations v
            GROUP BY v.description";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var violationStats = new
                            {
                                Description = reader.GetString("description"),
                                ProcessedCount = reader.GetInt32("ProcessedCount"),
                                UnprocessedCount = reader.GetInt32("UnprocessedCount"),
                                TotalFine = reader.IsDBNull(reader.GetOrdinal("TotalFine")) ? 0 : reader.GetDecimal("TotalFine")
                            };
                            list.Add(violationStats);
                        }
                    }
                }
            }

            return list;
        }

        public List<object> GetViolationDetails()
        {
            List<object> list = new List<object>();

            string query = @"
                SELECT v.violation_id, v.user_id, u.full_name, v.description, v.fine_amount, v.handled_by
                FROM violations v
                LEFT JOIN users u ON v.user_id = u.user_id";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var violation = new
                            {
                                ViolationId = reader.GetInt32("violation_id"),
                                UserId = reader.GetInt32("user_id"),
                                UserName = reader.IsDBNull(reader.GetOrdinal("full_name")) ? "Không xác định" : reader.GetString("full_name"),
                                Description = reader.GetString("description"),
                                FineAmount = reader.IsDBNull(reader.GetOrdinal("fine_amount")) ? 0 : reader.GetDecimal("fine_amount"),
                                HandledBy = reader.IsDBNull(reader.GetOrdinal("handled_by")) ? (int?)null : reader.GetInt32("handled_by")
                            };
                            list.Add(violation);
                        }
                    }
                }
            }

            return list;
        }
    }

}
