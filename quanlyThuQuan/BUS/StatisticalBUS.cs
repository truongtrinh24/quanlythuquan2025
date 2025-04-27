using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;

namespace quanlyThuQuan.BUS
{
    internal class StatisticalBUS
    {
        private StatisticalDAL dal = new StatisticalDAL();

        public List<Object> GetDeviceByCondition(DateTimePicker dateStart = null, DateTimePicker dateEnd = null, string deviceName = null, string type = null)
        {
            // Kiểm tra đầu vào nếu cần
            if (dateStart != null && dateEnd != null && dateStart.Value > dateEnd.Value)
            {
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
            }

            if (type == "Lọc theo tên thiết bị" && string.IsNullOrWhiteSpace(deviceName))
            {
                throw new ArgumentException("Tên thiết bị không được để trống khi lọc theo tên.");
            }

            // Gọi DAL để lấy danh sách booking
            return dal.GetDeviceByCondition(dateStart, dateEnd, deviceName, type);
        }

        public List<object> GetAllMemberInStudy(DateTimePicker dateStart = null, DateTimePicker dateEnd = null, string deviceName = null, string type = null)
        {
            return dal.GetDeviceByCondition(dateStart, dateEnd, deviceName, type);
        }

    

        public List<string> LayDanhSachKhoa()
        {
            return dal.GetBranches();
        }

        // Lấy danh sách Science
        public List<string> LayDanhSachNganh()
        {
            return dal.GetSciences();
        }

        public Dictionary<DateTime, (int MemberCount, List<object> MemberDetails)> GetDataAllMemberCheckIn()
        {
            try
            {
                // Gọi hàm từ tầng DAL để lấy dữ liệu thống kê
                return dal.GetAllMemberCheckInStats();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                throw new Exception("Lỗi khi lấy dữ liệu thống kê check-in: " + ex.Message);
            }
        }

        public Dictionary<DateTime, (int MemberCount, List<object> MemberDetails)> GetMemberCheckInCountByDate(DateTime dateStart, DateTime dateEnd, string branch , string science)
        {
            try
            {
                // Kiểm tra ngày hợp lệ
                if (dateStart > dateEnd)
                {
                    throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
                }

                // Lấy số lượng thành viên check-in theo ngày
                var memberCountByDate = dal.GetMemberCheckInCountByDate(dateStart, dateEnd, science, branch);

                // Lấy chi tiết thành viên
                var memberDetails = dal.GetMemberCheckInDetails(dateStart, dateEnd, science, branch); // Sửa ở đây

                // Kết hợp dữ liệu
                var result = new Dictionary<DateTime, (int MemberCount, List<object> MemberDetails)>();

                // Duyệt qua các ngày trong khoảng thời gian
                for (DateTime date = dateStart.Date; date <= dateEnd.Date; date = date.AddDays(1))
                {
                    // Lấy số lượng thành viên cho ngày hiện tại (nếu không có thì gán 0)
                    int memberCount = memberCountByDate.ContainsKey(date) ? memberCountByDate[date] : 0;

                    // Lấy chi tiết thành viên cho ngày hiện tại
                    var detailsForDate = memberDetails
                        .Where(m => ((dynamic)m).CheckInTime.Date == date)
                        .ToList();

                    // Thêm vào kết quả
                    result[date] = (memberCount, detailsForDate);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu thống kê check-in: " + ex.Message);
            }
        }


        public List<object> GetViolationStatistics()
        {
            return dal.GetViolationStatistics();
        }

        public List<object> GetViolationDetails()
        {
            return dal.GetViolationDetails();
        }

    }


}
