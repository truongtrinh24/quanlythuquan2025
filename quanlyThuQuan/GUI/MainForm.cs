using quanlyThuQuan.GUI.ThanhVien;
using quanlyThuQuan.GUI.ThietBi;
using quanlyThuQuan.GUI.ThongKe;
using quanlyThuQuan.GUI.ViPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyThuQuan.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void LoadUserControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(uc);
        }

        private void ResetButtonColor()
        {
            btnThanhVien.BackColor = Color.White;
            btnThietBi.BackColor = Color.White;
            btnViPham.BackColor = Color.White;
            btnThongKe.BackColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login.isAuthenticated = false; // reset lại trạng thái
                Login loginForm = new Login();
                loginForm.ShowDialog();

                if (Login.isAuthenticated)
                {
                    this.Show(); // đăng nhập lại thành công thì tiếp tục
                }
                else
                {
                    this.Close(); // không đăng nhập lại → thoát
                }
            }
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            ResetButtonColor();
            btnThanhVien.BackColor = Color.LightBlue; // hoặc bất kỳ màu highlight nào sếp thích
            LoadUserControl(new UC_ThanhVien());
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            ResetButtonColor();
            btnThietBi.BackColor = Color.LightBlue;
            LoadUserControl(new UC_ThietBi());
        }

        private void btnViPham_Click(object sender, EventArgs e)
        {
            ResetButtonColor();
            btnViPham.BackColor = Color.LightBlue;
            LoadUserControl(new UC_ViPham());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ResetButtonColor();
            btnThongKe.BackColor = Color.LightBlue;
            LoadUserControl(new UC_ThongKe());
        }
    }
}
