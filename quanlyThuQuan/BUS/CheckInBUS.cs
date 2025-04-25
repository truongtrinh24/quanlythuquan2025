using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.BUS
{
    internal class CheckInBUS
    {
        private CheckInDAL dal = new CheckInDAL();

        public bool AddCheckIn(CheckInDTO checkIn, out string error)
        {
            error = "";
            if (checkIn.UserId <= 0)
            {
                error = "ID người dùng không hợp lệ!";
                return false;
            }

            if (checkIn.CheckInTime == default(DateTime))
            {
                error = "Thời gian check-in không hợp lệ!";
                return false;
            }

            ThanhVienDAL tvDal = new ThanhVienDAL();
            var thanhVien = tvDal.GetThanhVienById(checkIn.UserId);
            if (thanhVien == null)
            {
                error = "Thành viên không tồn tại!";
                return false;
            }

            if (!dal.AddCheckIn(checkIn))
            {
                error = "Không thể lưu thông tin check-in!";
                return false;
            }

            return true;
        }
    }
}
