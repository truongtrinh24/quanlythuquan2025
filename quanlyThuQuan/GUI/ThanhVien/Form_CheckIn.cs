using MySql.Data.MySqlClient;
using quanlyThuQuan.BUS;
using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyThuQuan.GUI.ThanhVien
{
    public partial class Form_CheckIn : Form
    {
        public Form_CheckIn()
        {
            InitializeComponent();
        }

        private void panelNhapMa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtInputMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                string mssv = txtInputMSSV.Text.Trim();
                if (string.IsNullOrWhiteSpace(mssv))
                {
                    MessageBox.Show("Vui lòng nhập MSSV!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ThanhVienDAL tvDal = new ThanhVienDAL();
                ThanhVienDTO thanhVien = tvDal.GetThanhVienByMSSV(mssv);
                if (thanhVien == null)
                {
                    MessageBox.Show("Thành viên không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int userId = 0;
                try
                {
                    MySqlConnection conn = DBHelper.GetConnection();
                    string query = "SELECT user_id FROM users WHERE mssv = @MSSV";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MSSV", mssv);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi lấy MSSV thành viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (userId == 0)
                {
                    MessageBox.Show("Không tìm thấy MSSV của thành viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (thanhVien.Status == 0)
                {
                    MessageBox.Show("Thành viên này hiện đang bị cảnh báo vi phạm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInputMSSV.Clear();
                    return;
                }

                txtFullName.Text = thanhVien.FullName ?? "";
                txtGender.Text = thanhVien.Gender ?? "";
                txtBirthday.Text = thanhVien.Birthday.ToString("yyyy-MM-dd");
                txtBranch.Text = thanhVien.Branch ?? "";
                txtClass.Text = thanhVien.Class ?? "";
                txtScience.Text = thanhVien.Science ?? "";
                txtPhone.Text = thanhVien.Phone ?? "";

                DateTime checkInTime = DateTime.Now;
                txtTimeIn.Text = checkInTime.ToString("yyyy-MM-dd HH:mm:ss");

                CheckInDTO checkIn = new CheckInDTO
                {
                    UserId = userId,
                    CheckInTime = checkInTime
                };

                CheckInBUS bus = new CheckInBUS();
                string error;
                if (bus.AddCheckIn(checkIn, out error))
                {
                    MessageBox.Show("Check-in thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Check-in thất bại: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DBHelper.CloseConnection();
        }

        private void txtInputMSSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    


