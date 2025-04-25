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
    public partial class Form_MuonTra : Form
    {
        private BookingBUS bookingBUS;
        public Form_MuonTra()
        {
            InitializeComponent();
            bookingBUS = new BookingBUS();
        }

        private void btnMuonTB_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string deviceIdText = txtMaTB.Text.Trim();
            DateTime borrowTime = DateTime.Now;
            DateTime returnTime = dtpTraTB.Value;

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(deviceIdText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và Mã thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(deviceIdText, out int deviceId))
            {
                MessageBox.Show("Mã thiết bị phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra và lấy thông tin
            var (thanhVien, device, error) = bookingBUS.ValidateAndGetInfo(mssv, deviceId, borrowTime, returnTime);
            if (error != null)
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông tin
            txtThanhVien.Text = thanhVien.FullName;
            txtThietBi.Text = device.DeviceName;
            txtTimeMuon.Text = borrowTime.ToString("yyyy-MM-dd HH:mm:ss");

            // Lưu vào bảng bookings
            BookingDTO booking = new BookingDTO
            {
                UserId = thanhVien.UserId,
                DeviceId = device.DeviceId,
                StartTime = borrowTime,
                EndTime = returnTime,
                Status = "Đang mượn",
                CreatedAt = borrowTime
            };

            bool success = bookingBUS.CreateBooking(booking);
            if (success)
            {
                MessageBox.Show("Mượn thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi lưu thông tin mượn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraTB_Click(object sender, EventArgs e)
        {
            string mssv = txtNhapMSSV.Text.Trim();
            string deviceIdText = txtNhapTB.Text.Trim(); // Sửa thành txtNhapMaTB
            DateTime returnTime = DateTime.Now; 

            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(deviceIdText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và Mã thiết bị!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(deviceIdText, out int deviceId))
            {
                MessageBox.Show("Mã thiết bị phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var (thanhVien, device, booking, trangThai, error) = bookingBUS.ProcessReturn(mssv, deviceId, returnTime);
            if (error != null)
            {
                MessageBox.Show(error, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtMaMuon.Text = booking.BookingId.ToString();
            txtTenTB.Text = device.DeviceName;
            txtTenTV.Text = thanhVien.FullName;
            txtTimeEnd.Text = booking.EndTime.ToString("yyyy-MM-dd HH:mm:ss"); // Sửa thành txtHanDuKien
            txtActualTime.Text = returnTime.ToString("yyyy-MM-dd HH:mm:ss"); // Sửa thành txtThoi GianTra
            txtStatus.Text = trangThai; // Sửa thành txtTrangThai

            MessageBox.Show("Trả thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
