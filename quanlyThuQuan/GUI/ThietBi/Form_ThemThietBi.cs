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

namespace quanlyThuQuan.GUI.ThietBi
{

    public partial class Form_ThemThietBi : Form
    {
        private DeviceBUS deviceBUS;
        public Form_ThemThietBi()
        {
            InitializeComponent();
            deviceBUS = new DeviceBUS();
        }

        private void Form_ThemThietBi_Load(object sender, EventArgs e)
        {
            var categories = deviceBUS.GetDeviceCategories();
            cbMQĐ.DataSource = categories;
            cbMQĐ.DisplayMember = "DisplayCategory"; // Hiển thị dạng "category_id-category_name"
            cbMQĐ.ValueMember = "CategoryId";        // Giá trị là CategoryId
            cbMQĐ.DropDownStyle = ComboBoxStyle.DropDownList; // Không cho phép chỉnh sửa
        }

        private void btnAddTB_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng DeviceDTO
            DeviceDTO newDevice = new DeviceDTO
            {
                DeviceName = txtNameTB.Text.Trim(),
                Description = txtDescriptionTB.Text.Trim(),
                CreatedAt = DateTime.Now,
                CategoryId = cbMQĐ.SelectedValue?.ToString() // Lấy CategoryId từ ComboBox
            };

            // Thêm thiết bị mới
            bool success = deviceBUS.AddDevice(newDevice);
            if (success)
            {
                MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Trả về kết quả OK để UC_ThietBi biết cần tải lại
                this.Close();
            }
        }
    }
}
