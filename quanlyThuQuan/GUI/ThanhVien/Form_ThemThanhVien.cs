using quanlyThuQuan.BUS;
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
    public partial class Form_ThemThanhVien : Form
    {
        public Form_ThemThanhVien()
        {
            InitializeComponent();
        }

        private void Form_ThemThanhVien_Load(object sender, EventArgs e)
        {
            // Thêm giá trị vào ComboBox giới tính
            cmbGender.Items.Add("Nam");
            cmbGender.Items.Add("Nữ");

            // Đặt giá trị mặc định (tùy chọn, ví dụ là Nam)
            cmbGender.SelectedIndex = 0;
        }

        private void btnAddTV_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập liệu
            string fullName = txtFullName.Text.Trim();
            string mssv = txtMSSV.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string branch = txtBranch.Text.Trim();
            string className = txtClass.Text.Trim();
            string science = txtScience.Text.Trim();
            string gender = cmbGender.SelectedItem.ToString();
            DateTime birthday = dtpBirthday.Value;

            // Tạo đối tượng ThanhVienDTO
            ThanhVienDTO thanhVien = new ThanhVienDTO()
            {
                FullName = fullName,
                MSSV = mssv,
                Phone = phone,
                Branch = branch,
                Class = className,
                Science = science,
                Gender = gender,
                Birthday = birthday
            };

            // Gọi phương thức thêm thành viên từ BUS
            ThanhVienBUS bus = new ThanhVienBUS();
            string error;
            bool result = bus.ThemThanhVien(thanhVien, out error);

            // Kiểm tra kết quả và hiển thị thông báo
            if (result)
            {
                MessageBox.Show("Thêm thành viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();  // Đóng form sau khi thêm thành công
            }
            else
            {
                MessageBox.Show($"Thêm thành viên thất bại: {error}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
