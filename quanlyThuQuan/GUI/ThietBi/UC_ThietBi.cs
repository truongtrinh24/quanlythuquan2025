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
using OfficeOpenXml;

namespace quanlyThuQuan.GUI.ThietBi
{
    public partial class UC_ThietBi : UserControl
    {
        private DeviceBUS deviceBUS;
        private BindingSource deviceBindingSource;
        private CategoryDeviceBUS categoryBUS;
        public UC_ThietBi()
        {
            InitializeComponent();
            deviceBUS = new DeviceBUS();
            categoryBUS = new CategoryDeviceBUS(); // Khởi tạo CategoryDeviceBUS
            deviceBindingSource = new BindingSource();
            this.Load += UC_ThietBi_Load;
        }

        private void UC_ThietBi_Load(object sender, EventArgs e)
        {
            LoadDeviceData("", "");
            LoadCategoriesForDelete();

        }
        private void LoadCategoriesForDelete()
        {
            var categories = categoryBUS.GetAllCategories();
            cbDltMQĐ.DataSource = categories;
            cbDltMQĐ.DisplayMember = "CategoryName";
            cbDltMQĐ.ValueMember = "CategoryId";
            cbDltMQĐ.SelectedIndex = -1; // Không chọn mặc định
        }
        public void LoadDeviceData(string keyword = "", string categoryId = "")
        {
            // Sửa: Gọi SearchDevices thay vì GetAllDevices
            List<DeviceDTO> devices = deviceBUS.SearchDevices(keyword, categoryId);
            deviceBindingSource.DataSource = devices;
            dgvThietBi.DataSource = deviceBindingSource;

            // Tùy chỉnh tiêu đề cột
            dgvThietBi.Columns["DeviceId"].HeaderText = "Mã thiết bị";
            dgvThietBi.Columns["DeviceName"].HeaderText = "Tên thiết bị";
            if (dgvThietBi.Columns.Contains("StatusId"))
            {
                dgvThietBi.Columns["StatusId"].Visible = false;
            }
            dgvThietBi.Columns["StatusName"].HeaderText = "Trạng thái";
            dgvThietBi.Columns["Description"].HeaderText = "Mô tả";
            if (dgvThietBi.Columns.Contains("CreatedAt"))
            {
                dgvThietBi.Columns["CreatedAt"].HeaderText = "Ngày tạo";
                dgvThietBi.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (dgvThietBi.Columns.Contains("CategoryId"))
            {
                dgvThietBi.Columns["CategoryId"].HeaderText = "Mã quy định";  // Hiển thị category_id
            }
            if (dgvThietBi.Columns.Contains("CategoryName"))
            {
                dgvThietBi.Columns["CategoryName"].Visible = false;
            }

            // Ẩn cột IsDeleted nếu có
            if (dgvThietBi.Columns.Contains("IsDeleted"))
            {
                dgvThietBi.Columns["IsDeleted"].Visible = false;
            }

            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.ScrollBars = ScrollBars.Vertical;
        }

        private void btnAddTB_Click(object sender, EventArgs e)
        {
            Form_ThemThietBi formThem = new Form_ThemThietBi();
            if (formThem.ShowDialog() == DialogResult.OK)
            {
                LoadDeviceData("", "");
            }
        }

        private void btnEditTB_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvThietBi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một thiết bị để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy device_id của dòng đã chọn
            int deviceID = Convert.ToInt32(dgvThietBi.SelectedRows[0].Cells["DeviceId"].Value);

            // Mở form sửa và truyền device_id
            Form_SuaThietBi formsuaTB = new Form_SuaThietBi(deviceID);
            if (formsuaTB.ShowDialog() == DialogResult.OK)
            {
                LoadDeviceData("", ""); // Làm mới bảng sau khi sửa thành công
            }
        }

        private void btnDeleteTB_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn trong DataGridView không
            if (dgvThietBi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một thiết bị để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy device_id của dòng đã chọn
            int deviceID = Convert.ToInt32(dgvThietBi.SelectedRows[0].Cells["DeviceId"].Value);

            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thiết bị với ID {deviceID}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                // Gọi phương thức xóa từ DeviceBUS
                if (deviceBUS.DeleteDevice(deviceID))
                {
                    MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDeviceData("", ""); // Làm mới bảng sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa thiết bị thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapTBExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở hộp thoại chọn file Excel
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                    openFileDialog.Title = "Chọn file Excel để nhập thiết bị";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // Đọc file Excel
                        using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                        {
                            var worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                            int rowCount = worksheet.Dimension.Rows;

                            List<DeviceDTO> devices = new List<DeviceDTO>();

                            // Bắt đầu đọc từ dòng thứ 2 (dòng 1 là tiêu đề)
                            for (int row = 2; row <= rowCount; row++)
                            {
                                // Kiểm tra dòng có dữ liệu không
                                if (string.IsNullOrWhiteSpace(worksheet.Cells[row, 1].Text))
                                {
                                    continue; // Bỏ qua dòng trống
                                }

                                DeviceDTO device = new DeviceDTO
                                {
                                    DeviceName = worksheet.Cells[row, 1].Text, // device_name
                                    StatusId = int.Parse(worksheet.Cells[row, 2].Text), // status_id
                                    Description = string.IsNullOrWhiteSpace(worksheet.Cells[row, 3].Text) ? "Không có mô tả" : worksheet.Cells[row, 3].Text, // description
                                    CategoryId = string.IsNullOrWhiteSpace(worksheet.Cells[row, 4].Text) ? null : worksheet.Cells[row, 4].Text, // category_id
                                    CreatedAt = DateTime.Now // Gán thời gian hiện tại
                                };

                                devices.Add(device);
                            }

                            // Nhập danh sách thiết bị vào cơ sở dữ liệu
                            int successCount = 0;
                            foreach (var device in devices)
                            {
                                if (deviceBUS.AddDevice(device))
                                {
                                    successCount++;
                                }
                            }

                            MessageBox.Show($"Nhập thành công {successCount}/{devices.Count} thiết bị từ Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDeviceData("", ""); // Làm mới bảng sau khi nhập
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập từ Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhapTBExcel_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Mở hộp thoại chọn file Excel
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                    openFileDialog.Title = "Chọn file Excel để nhập thiết bị";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;

                        // Đọc file Excel
                        using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                        {
                            var worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                            int rowCount = worksheet.Dimension.Rows;

                            List<DeviceDTO> devices = new List<DeviceDTO>();

                            // Bắt đầu đọc từ dòng thứ 2 (dòng 1 là tiêu đề)
                            for (int row = 2; row <= rowCount; row++)
                            {
                                // Kiểm tra dòng có dữ liệu không
                                if (string.IsNullOrWhiteSpace(worksheet.Cells[row, 1].Text))
                                {
                                    continue; // Bỏ qua dòng trống
                                }

                                DeviceDTO device = new DeviceDTO
                                {
                                    DeviceName = worksheet.Cells[row, 1].Text, // device_name
                                    StatusId = int.Parse(worksheet.Cells[row, 2].Text), // status_id
                                    Description = string.IsNullOrWhiteSpace(worksheet.Cells[row, 3].Text) ? "Không có mô tả" : worksheet.Cells[row, 3].Text, // description
                                    CategoryId = string.IsNullOrWhiteSpace(worksheet.Cells[row, 4].Text) ? null : worksheet.Cells[row, 4].Text, // category_id
                                    CreatedAt = DateTime.Now // Gán thời gian hiện tại
                                };

                                devices.Add(device);
                            }

                            // Nhập danh sách thiết bị vào cơ sở dữ liệu
                            int successCount = 0;
                            foreach (var device in devices)
                            {
                                if (deviceBUS.AddDevice(device))
                                {
                                    successCount++;
                                }
                            }

                            MessageBox.Show($"Nhập thành công {successCount}/{devices.Count} thiết bị từ Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDeviceData("", ""); // Làm mới bảng sau khi nhập
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nhập từ Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddMQĐ_Click(object sender, EventArgs e)
        {
            Form_ThemMQD formThemMQD = new Form_ThemMQD();
            formThemMQD.ShowDialog();

        }

        private void btnDltMQĐ_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn mã quy định chưa
                if (cbDltMQĐ.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn mã quy định để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedCategoryId = cbDltMQĐ.SelectedValue.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tất cả thiết bị thuộc mã quy định '{selectedCategoryId}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Gọi BUS để xóa mềm
                    if (deviceBUS.SoftDeleteDevicesByCategory(selectedCategoryId))
                    {
                        MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDeviceData("", ""); // Làm mới DataGridView
                        LoadCategoriesForDelete(); // Làm mới ComboBox
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchTB_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchTB.Text.Trim();
            string categoryId = cbDltMQĐ.SelectedIndex != -1 ? cbDltMQĐ.SelectedValue.ToString() : "";
            LoadDeviceData(keyword, categoryId);
        }

        private void txtSearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchTB_Click(sender, e);
                e.Handled = true;
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadDeviceData("", "");
        }
    }
}
