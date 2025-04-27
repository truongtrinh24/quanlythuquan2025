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

namespace quanlyThuQuan.GUI.ViPham
{
    public partial class UC_ViPham : UserControl
    {
        private ViolateBUS _viPham = new ViolateBUS();
        private ViolationDTO selectedViolation = new ViolationDTO();
        private ViolationRequest request = new ViolationRequest();
        public UC_ViPham()
        {
            InitializeComponent();
            LoadViolationList();
            LoadBookingList();
            viphamview.CellClick += viphamview_CellClick;
            dataViewBook.CellClick += dataViewBook_CellClick;

        }
        public void UC_ViPham_Load(object sender, EventArgs e)
        {

        }
        private void LoadBookingList()
        {
            try
            {
                dataViewBook.DataSource = null;
                var bookings = _viPham.GetLateBookings();
                dataViewBook.DataSource = bookings;
                var expectedColumns = new[] { "BookingId", "UserId", "DeviceId", "StartTime", "EndTime", "Status", "CreatedAt", "ActualTime" };
                foreach (var col in expectedColumns)
                {
                    if (dataViewBook.Columns.Contains(col))
                    {
                        dataViewBook.Columns[col].HeaderText = col;
                    }
                    else
                    {
                        MessageBox.Show($"Cột {col} không tồn tại trong DataGridView!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void LoadViolationList()
        {
            try
            {
                viphamview.DataSource = null;
                var violations = _viPham.GetAllViolations();
                viphamview.DataSource = violations;
                var expectedColumns = new[] { "ViolationId", "UserId", "DeviceId", "BookingId", "Description", "FineAmount", "ViolationTime" };
                foreach (var col in expectedColumns)
                {
                    if (viphamview.Columns.Contains(col))
                    {
                        viphamview.Columns[col].HeaderText = col;
                    }
                    else
                    {
                        MessageBox.Show($"Cột {col} không tồn tại trong DataGridView!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void add_button_Click(object sender, EventArgs e)
        {
          
        }
        // sửa
        private void update_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedViolation != null)
                {
                    ViolateGUI addForm = new ViolateGUI();
                    addForm.SelectedViolation = selectedViolation;
                    addForm.ShowDialog();
                    LoadViolationList();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn thành viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening add violation form: " + ex.Message);
            }
        }
        // xóa
        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedViolation == null || selectedViolation.ViolationId == 0)
                {
                    MessageBox.Show("Vui lòng chọn một vi phạm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa vi phạm với ID {selectedViolation.ViolationId} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _viPham.DeleteViolation(selectedViolation.ViolationId);
                    _viPham.UpdateUserStatus(selectedViolation.UserId, 1);
                    MessageBox.Show("Vi phạm đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadViolationList();
                    selectedViolation = new ViolationDTO();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa vi phạm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // reset
        private void reset_button_Click(object sender, EventArgs e)
        {
            LoadViolationList();
            txt_search.ResetText();
        }

        private void viphamview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = viphamview.Rows[e.RowIndex];
                    selectedViolation = new ViolationDTO
                    {
                        ViolationId = row.Cells["ViolationId"].Value != null &&
                                      int.TryParse(row.Cells["ViolationId"].Value.ToString(), out int violationId)
                                      ? violationId : 0,
                        UserId = row.Cells["UserId"].Value != null &&
                                 int.TryParse(row.Cells["UserId"].Value.ToString(), out int userId)
                                 ? userId : 0,

                        DeviceId = row.Cells["DeviceId"].Value != null &&
                                   int.TryParse(row.Cells["DeviceId"].Value.ToString(), out int deviceId)
                                   ? deviceId : 0,
                        BookingId = row.Cells["BookingId"].Value != null &&
                                    int.TryParse(row.Cells["BookingId"].Value.ToString(), out int bookingId)
                                    ? bookingId : 0,
                        Description = row.Cells["Description"].Value?.ToString() ?? "",
                        FineAmount = row.Cells["FineAmount"].Value != null &&
                                     decimal.TryParse(row.Cells["FineAmount"].Value.ToString(), out decimal fineAmount)
                                     ? fineAmount : 0,
                        ViolationTime = row.Cells["ViolationTime"].Value != null &&
                                        DateTime.TryParse(row.Cells["ViolationTime"].Value.ToString(), out DateTime violationTime)
                                        ? violationTime : DateTime.MinValue,

                     
                    };
                }
            }
            catch (Exception ex)
            {
                string errorDetails = $"Lỗi khi chọn hàng: {ex.Message}\n" +
                                     $"RowIndex: {e.RowIndex}\n" +
                                     $"Giá trị ô: {string.Join(", ", viphamview.Rows[e.RowIndex].Cells.Cast<DataGridViewCell>().Select(c => $"{c.OwningColumn.Name}: {c.Value ?? "null"}"))}\n" +
                                     $"Stack Trace: {ex.StackTrace}";
                MessageBox.Show(errorDetails);
                selectedViolation = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // tìm kiếm
        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_search.Text, out int userId))
                {
                    ViolateDAL violateDAL = new ViolateDAL();
                    List<ViolationDTO> violations = _viPham.getViolationByUserId(userId);
                    viphamview.DataSource = violations;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập user_id hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm vi phạm: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // thêm vi phạm
        private void btn_vipham_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedViolation != null)
                {
                    ViolateGUI addForm = new ViolateGUI();
                    addForm.ViolationRequest = request;
                    addForm.ShowDialog();
                    LoadViolationList();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 hàng để phạt");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening add violation form: " + ex.Message);
            }
        }

        private void dataViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    var row = dataViewBook.Rows[e.RowIndex];
                    request = new ViolationRequest
                    {
                        UserId = row.Cells["UserId"].Value != null &&
                                 int.TryParse(row.Cells["UserId"].Value.ToString(), out int userId)
                                 ? userId : 0,

                        DeviceId = row.Cells["DeviceId"].Value != null &&
                                   int.TryParse(row.Cells["DeviceId"].Value.ToString(), out int deviceId)
                                   ? deviceId : 0,
                        BookingId = row.Cells["BookingId"].Value != null &&
                                    int.TryParse(row.Cells["BookingId"].Value.ToString(), out int bookingId)
                                    ? bookingId : 0,
                    };
                }
            }
            catch
            {

            }
    } }
}
