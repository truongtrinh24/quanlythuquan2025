using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.BUS
{
    internal class BookingBUS
    {
        private ThanhVienDAL thanhVienDAL = new ThanhVienDAL();
        private DeviceDAL deviceDAL = new DeviceDAL();
        private BookingDAL bookingDAL = new BookingDAL();

        public (ThanhVienDTO thanhVien, DeviceDTO device, string error) ValidateAndGetInfo(string mssv, int deviceId, DateTime borrowTime, DateTime returnTime)
        {
            // Kiểm tra thời gian trả
            if (returnTime <= borrowTime)
            {
                return (null, null, "Thời gian trả phải sau thời gian mượn!");
            }

            // Kiểm tra thành viên
            ThanhVienDTO thanhVien = thanhVienDAL.GetThanhVienByMSSV(mssv);
            if (thanhVien == null)
            {
                return (null, null, "Không tìm thấy thành viên với MSSV này!");
            }
            if (thanhVien.Status == 0)
            {
                return (null, null, "Thành viên đang trong diện vi phạm, không thể mượn!");
            }

            // Kiểm tra thiết bị
            DeviceDTO device = deviceDAL.GetDeviceById(deviceId);
            if (device == null)
            {
                return (null, null, "Không tìm thấy thiết bị với mã này!");
            }
            if (device.StatusId == 2 || device.StatusId == 3)
            {
                return (null, null, "Thiết bị đang được mượn hoặc đang hư hỏng!");
            }

            return (thanhVien, device, null);
        }

        public bool CreateBooking(BookingDTO booking)
        {
            return bookingDAL.CreateBooking(booking);
        }
        public (ThanhVienDTO thanhVien, DeviceDTO device, BookingDTO booking, string trangThai, string error) ProcessReturn(string mssv, int deviceId, DateTime returnTime)
        {
            BookingDTO booking = bookingDAL.GetBookingByMSSVAndDeviceId(mssv, deviceId);
            if (booking == null)
            {
                return (null, null, null, null, "Thành viên này chưa mượn thiết bị này!");
            }

            if (booking.Status == "Đã trả")
            {
                return (null, null, null, null, "Thiết bị này đã được trả trước đó!");
            }

            ThanhVienDTO thanhVien = thanhVienDAL.GetThanhVienByMSSV(mssv);
            DeviceDTO device = deviceDAL.GetDeviceById(booking.DeviceId);

            string trangThai = returnTime > booking.EndTime ? "Trả muộn" : "Trả đúng thời hạn";

            bool success = bookingDAL.UpdateBookingOnReturn(booking.BookingId, "Đã trả", returnTime);
            if (!success)
            {
                return (null, null, null, null, "Đã xảy ra lỗi khi cập nhật thông tin trả!");
            }

            // Cập nhật trạng thái thiết bị về "Sẵn sàng" (status_id = 1)
            bool deviceUpdated = deviceDAL.UpdateDeviceStatus(deviceId, 1);
            if (!deviceUpdated)
            {
                return (null, null, null, null, "Đã xảy ra lỗi khi cập nhật trạng thái thiết bị!");
            }

            return (thanhVien, device, booking, trangThai, null);
        }
    }
}
