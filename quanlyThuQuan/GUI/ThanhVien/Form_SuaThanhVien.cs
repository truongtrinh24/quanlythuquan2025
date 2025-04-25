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
    public partial class Form_SuaThanhVien : Form
    {
        private ThanhVienDTO thanhVien;

        // Nhận thông tin thành viên từ ngoài khi gọi form
        public Form_SuaThanhVien(ThanhVienDTO tv)
        {
            InitializeComponent();
            thanhVien = tv;
            // Gán các giá trị cho các TextBox và ComboBox
            txtFullName.Text = tv.FullName;
            txtMSSV.Text = tv.MSSV;
            txtPhone.Text = tv.Phone;
            txtBranch.Text = tv.Branch;
            txtClass.Text = tv.Class;
            txtScience.Text = tv.Science;
            dtpBirthday.Value = tv.Birthday;
            cmbGender.Items.Clear();
            cmbGender.Items.Add("Nam");
            cmbGender.Items.Add("Nữ");
            cmbGender.SelectedItem = tv.Gender;
            txtMSSV.ReadOnly = true;
            txtMSSV.Enabled = false; // hoặc .BackColor = Color.LightGray;

        }

        private void Form_SuaThanhVien_Load(object sender, EventArgs e)
        {
            // Điền thông tin của thành viên vào các ô nhập liệu
            txtFullName.Text = thanhVien.FullName;
            txtMSSV.Text = thanhVien.MSSV;
            txtPhone.Text = thanhVien.Phone;
            dtpBirthday.Value = thanhVien.Birthday;
            cmbGender.SelectedItem = thanhVien.Gender;
            txtBranch.Text = thanhVien.Branch;
            txtClass.Text = thanhVien.Class;
            txtScience.Text = thanhVien.Science;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox và ComboBox
            thanhVien.FullName = txtFullName.Text;
            thanhVien.MSSV = txtMSSV.Text;
            thanhVien.Phone = txtPhone.Text;
            thanhVien.Birthday = dtpBirthday.Value;
            thanhVien.Gender = cmbGender.SelectedItem.ToString();
            thanhVien.Branch = txtBranch.Text;
            thanhVien.Class = txtClass.Text;
            thanhVien.Science = txtScience.Text;

            // Cập nhật thành viên
            ThanhVienBUS bus = new ThanhVienBUS();
            string error;
            bool result = bus.CapNhatThanhVien(thanhVien, out error);

            if (result)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Để đóng form và trả kết quả OK
                this.Close();
            }
            else
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
