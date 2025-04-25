using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyThuQuan.BUS
{
    
    internal class AccountBUS
    {
        private AccountDAL dal = new AccountDAL();

        public bool DangNhap(string username, string password, out AccountDTO account, out string error)
        {
            error = "";
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                error = "Tài khoản hoặc mật khẩu không được để trống!";
                account = null;
                return false;
            }

            bool result = dal.KiemTraDangNhap(username, password, out account);

            if (!result)
                error = "Tài khoản hoặc mật khẩu không đúng, hoặc không phải tài khoản admin.";

            return result;
        }
    }
}
