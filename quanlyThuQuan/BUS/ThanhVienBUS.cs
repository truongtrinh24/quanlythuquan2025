using quanlyThuQuan.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanlyThuQuan.DTO;

namespace quanlyThuQuan.BUS
{
    internal class ThanhVienBUS
    {
        private ThanhVienDAL dal = new ThanhVienDAL();

        public List<ThanhVienDTO> LayDanhSachThanhVien()
        {
            return dal.GetAllThanhVien();
        }

        public ThanhVienDTO TimThanhVienTheoMSSV(string mssv)
        {
            // Gọi DAL để tìm thành viên theo MSSV
            ThanhVienDAL dal = new ThanhVienDAL();
            return dal.GetThanhVienByMSSV(mssv);  // Trả về thông tin thành viên
        }
        public ThanhVienDTO TimThanhVienTheoTenVaSDT(string fullName, string phone)
        {
            return new ThanhVienDAL().GetThanhVienByTenVaSDT(fullName, phone);
        }

        public bool ThemThanhVien(ThanhVienDTO tv, out string error)
        {
            error = "";

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrWhiteSpace(tv.FullName))
            {
                error = "Họ và tên không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(tv.MSSV))
            {
                error = "MSSV không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(tv.Phone))
            {
                error = "Số điện thoại không được để trống!";
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(tv.Phone, @"^\d{10}$"))
            {
                error = "Số điện thoại phải có 10 chữ số!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(tv.Branch))
            {
                error = "Khoa không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(tv.Class))
            {
                error = "Lớp không được để trống!";
                return false;
            }
            if (string.IsNullOrWhiteSpace(tv.Science))
            {
                error = "Ngành học không được để trống!";
                return false;
            }

            // Nếu tất cả các kiểm tra hợp lệ, tiếp tục thêm thành viên vào cơ sở dữ liệu
            try
            {
                ThanhVienDAL dal = new ThanhVienDAL();
                bool result = dal.ThemThanhVien(tv);
                return result;
            }
            catch (Exception ex)
            {
                error = "Lỗi khi thêm thành viên: " + ex.Message;
                return false;
            }
        }
        public bool CapNhatThanhVien(ThanhVienDTO tv, out string error)
        {
            error = "";

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrWhiteSpace(tv.FullName) || string.IsNullOrWhiteSpace(tv.MSSV))
            {
                error = "Vui lòng nhập đầy đủ thông tin!";
                return false;
            }

            // Kiểm tra UserId
            if (tv.UserId <= 0)
            {
                error = "Không tìm thấy UserId hợp lệ để cập nhật!";
                return false;
            }

            // Cập nhật thông tin thành viên
            ThanhVienDAL dal = new ThanhVienDAL();
            bool result = dal.UpdateThanhVien(tv);

            if (!result)
            {
                error = "Cập nhật thất bại! Vui lòng thử lại.";
            }

            return result;
        }
        public bool XoaThanhVien(int userId, out string error)
        {
            error = "";

            try
            {
                ThanhVienDAL dal = new ThanhVienDAL();
                bool result = dal.DeleteThanhVien(userId);

                if (!result)
                {
                    error = "Xóa thành viên thất bại! Vui lòng thử lại.";
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                error = "Lỗi khi xóa thành viên: " + ex.Message;
                return false;
            }
        }
        public bool NhapTVExcel(List<ThanhVienDTO> danhSach, out string error)
        {
            error = "";
            bool allSuccess = true;

            foreach (var tv in danhSach)
            {
                string singleError;
                if (!ThemThanhVien(tv, out singleError))
                {
                    error += $"Lỗi khi thêm thành viên {tv.FullName} (MSSV: {tv.MSSV}): {singleError}\n";
                    allSuccess = false;
                }
            }

            return allSuccess;
        }
        private List<string> KiemTraThanhVien(ThanhVienDTO tv, int row)
        {
            List<string> errors = new List<string>();

            // Kiểm tra dữ liệu trống
            if (string.IsNullOrWhiteSpace(tv.FullName) || string.IsNullOrWhiteSpace(tv.MSSV) ||
                string.IsNullOrWhiteSpace(tv.Phone) || string.IsNullOrWhiteSpace(tv.Science) ||
                string.IsNullOrWhiteSpace(tv.Class) || string.IsNullOrWhiteSpace(tv.Branch))
            {
                errors.Add($"Dòng {row}: Vui lòng nhập đầy đủ thông tin!");
                return errors; // Dừng kiểm tra nếu thiếu thông tin
            }

            // Kiểm tra MSSV trùng lặp
            if (TimThanhVienTheoMSSV(tv.MSSV) != null)
            {
                errors.Add($"Dòng {row}: MSSV {tv.MSSV} đã tồn tại!");
            }

            // Kiểm tra giới tính
            if (tv.Gender != "Nam" && tv.Gender != "Nữ")
            {
                errors.Add($"Dòng {row}: Giới tính phải là 'Nam' hoặc 'Nữ'!");
            }

            // Kiểm tra số điện thoại (đã có trong ThemThanhVien, nhưng thêm vào đây để báo lỗi sớm)
            if (!System.Text.RegularExpressions.Regex.IsMatch(tv.Phone, @"^\d{10}$"))
            {
                errors.Add($"Dòng {row}: Số điện thoại phải là 10 chữ số!");
            }

            // Ngày sinh đã được kiểm tra ở tầng giao diện, không cần kiểm tra lại ở đây
            // Nếu cần kiểm tra thêm các ràng buộc khác (ví dụ: độ dài FullName, giá trị hợp lệ của Science, Class, Branch), anh có thể thêm vào đây

            return errors;
        }
        public (bool success, string error) DeleteThanhVienByYear(int year)
        {
            // Kiểm tra năm hợp lệ
            if (year < 1900 || year > DateTime.Now.Year)
            {
                return (false, "Năm kích hoạt không hợp lệ! Vui lòng nhập một năm hợp lệ (1900 - hiện tại).");
            }
            ThanhVienDAL thanhVienDAL = new ThanhVienDAL();
            bool result = thanhVienDAL.DeleteThanhVienByYear(year);
            if (!result)
            {
                return (false, $"Không tìm thấy thành viên nào được kích hoạt trong năm {year}!");
            }

            return (true, $"Đã xóa tất cả thành viên được kích hoạt trong năm {year}!");
        }


    }
}
