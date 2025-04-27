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
    public partial class Form_ThemMQD : Form
    {
        private CategoryDeviceBUS categoryBUS;
        public Form_ThemMQD()
        {
            InitializeComponent();
            categoryBUS = new CategoryDeviceBUS();
        }

        private void Form_ThemMQD_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLuuMQD_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các trường nhập liệu
                string categoryId = txtInputMQD.Text.Trim();
                string categoryName = txtInputTenMQD.Text.Trim();

                // Tạo đối tượng CategoryDeviceDTO
                CategoryDeviceDTO category = new CategoryDeviceDTO
                {
                    CategoryId = categoryId,
                    CategoryName = categoryName
                };

                // Gọi BUS để thêm danh mục
                if (categoryBUS.AddCategory(category))
                {
                    MessageBox.Show("Thêm mã quy định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Đặt kết quả trả về
                    this.Close(); // Đóng form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
