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
    public partial class Form_SuaThietBi : Form
    {
        private DeviceBUS deviceBUS = new DeviceBUS();
        private int deviceID;
        public Form_SuaThietBi(int deviceID)
        {
            InitializeComponent();
            this.deviceID = deviceID;
            LoadFormData();
        }
        private void LoadFormData()
        {
            try
            {
                // Lấy thông tin thiết bị
                DeviceDTO device = deviceBUS.GetDeviceByID(deviceID);
                if (device == null)
                {
                    MessageBox.Show("Không tìm thấy thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Điền thông tin vào các ô nhập liệu
                txtNameTb.Text = device.DeviceName;
                txtDesTB.Text = device.Description;

                // Load danh sách trạng thái vào cbStatusTB
                var statuses = deviceBUS.GetDeviceStatuses();
                cbMQDTB.DataSource = null;
                cbStatusTB.DataSource = statuses;
                cbStatusTB.DisplayMember = "DisplayStatus"; // Hiển thị dạng "status_id - status_name"
                cbStatusTB.ValueMember = "StatusId";
                cbStatusTB.SelectedValue = device.StatusId;

                // Load danh sách danh mục vào cbMQDTB
                var categories = deviceBUS.GetDeviceCategories();
                cbMQDTB.DataSource = null;
                cbMQDTB.DataSource = categories;
                cbMQDTB.DisplayMember = "DisplayCategory"; // Hiển thị dạng "category_id - category_name"
                cbMQDTB.ValueMember = "CategoryId";
                if (device.CategoryId != null)
                {
                    cbMQDTB.SelectedValue = device.CategoryId;
                }
                else
                {
                    cbMQDTB.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnLuuTB_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng DeviceDTO với thông tin mới
                DeviceDTO device = new DeviceDTO
                {
                    DeviceId = deviceID,
                    DeviceName = txtNameTb.Text,
                    CategoryId = cbMQDTB.SelectedValue?.ToString(),
                    StatusId = Convert.ToInt32(cbStatusTB.SelectedValue),
                    Description = txtDesTB.Text
                };

                // Cập nhật thiết bị
                if (deviceBUS.UpdateDevice(device))
                {
                    MessageBox.Show("Cập nhật thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thiết bị thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
