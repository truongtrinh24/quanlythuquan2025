using OfficeOpenXml;
using quanlyThuQuan.BUS;
using quanlyThuQuan.DAL;
using quanlyThuQuan.DTO;
using quanlyThuQuan.Utils;
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
    public partial class UC_ThanhVien : UserControl
    {
        public UC_ThanhVien()
        {
            InitializeComponent();
            this.Load += UC_ThanhVien_Load;

        }

        private void UC_ThanhVien_Load(object sender, EventArgs e)
        {
            LoadDanhSachThanhVien();
        }
        private void LoadDanhSachThanhVien()
        {
            ThanhVienBUS bus = new ThanhVienBUS();
            var danhSach = bus.LayDanhSachThanhVien();

            var bindingList = danhSach.Select((tv, index) => new
            {
                STT = index + 1,
                HoTen = tv.FullName,
                GioiTinh = tv.Gender,
                NgaySinh = tv.Birthday.ToString("M/d/yyyy"), // format giống trong DataGridView
                SoDienThoai = tv.Phone,
                Nganh = tv.Branch,
                Lop = tv.Class,
                Khoa = tv.Science,
                MSSV = tv.MSSV
            }).ToList();

            dgvThanhVien.DataSource = bindingList;

            // Cập nhật tiêu đề
            dgvThanhVien.Columns["STT"].HeaderText = "STT";
            dgvThanhVien.Columns["HoTen"].HeaderText = "Họ và Tên";
            dgvThanhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvThanhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvThanhVien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvThanhVien.Columns["Nganh"].HeaderText = "Ngành";
            dgvThanhVien.Columns["Lop"].HeaderText = "Lớp";
            dgvThanhVien.Columns["Khoa"].HeaderText = "Khoa";
            dgvThanhVien.Columns["MSSV"].HeaderText = "MSSV";

            // Tùy chỉnh độ rộng và canh giữa STT
            if (dgvThanhVien.Columns.Contains("STT"))
            {
                dgvThanhVien.Columns["STT"].Width = 40;
                dgvThanhVien.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvThanhVien.Columns.Contains("GioiTinh"))
            {
                dgvThanhVien.Columns["GioiTinh"].Width = 50; // Đặt độ rộng cột Giới Tính là 80px
                dgvThanhVien.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Canh giữa nội dung
            }
            if (dgvThanhVien.Columns.Contains("SoDienThoai"))
            {
                dgvThanhVien.Columns["SoDienThoai"].Width = 80; // Đặt độ rộng cột Giới Tính là 80px
                dgvThanhVien.Columns["SoDienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Canh giữa nội dung
            }
            if (dgvThanhVien.Columns.Contains("Lop"))
            {
                dgvThanhVien.Columns["Lop"].Width = 80; // Đặt độ rộng cột Giới Tính là 80px
                dgvThanhVien.Columns["Lop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Canh giữa nội dung
            }
        }


        private void TimKiemThanhVien(string keyword)
        {
            ThanhVienDAL dal = new ThanhVienDAL();
            var danhSach = dal.GetAllThanhVien();

            var ketQua = danhSach
               .Where(tv => tv.FullName.ToLower().Contains(keyword.ToLower()) ||
             tv.Phone.ToLower().Contains(keyword.ToLower()) ||
             tv.Gender.ToLower().Contains(keyword.ToLower()) ||
             tv.Science.ToLower().Contains(keyword.ToLower()) ||
             tv.Branch.ToLower().Contains(keyword.ToLower()))
                .Select((tv, index) => new
                {
                    STT = index + 1,
                    HoTen = tv.FullName,
                    GioiTinh = tv.Gender,
                    NgaySinh = tv.Birthday.ToString("dd/MM/yyyy"),
                    SoDienThoai = tv.Phone,
                    Nganh = tv.Science,
                    Lop = tv.Class,
                    Khoa = tv.Branch,
                    MSSV = tv.MSSV
                }).ToList();

            dgvThanhVien.DataSource = ketQua;

            if (dgvThanhVien.Columns.Contains("STT"))
            {
                dgvThanhVien.Columns["STT"].Width = 40;
                dgvThanhVien.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (dgvThanhVien.Columns.Contains("GioiTinh"))
            {
                dgvThanhVien.Columns["GioiTinh"].Width = 50; // Đặt độ rộng cột Giới Tính là 80px
                dgvThanhVien.Columns["GioiTinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Canh giữa nội dung
            }
            if (dgvThanhVien.Columns.Contains("GioiTinh"))
            {
                dgvThanhVien.Columns["SoDienThoai"].Width = 80; // Đặt độ rộng cột Giới Tính là 80px
                dgvThanhVien.Columns["SoDienThoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Canh giữa nội dung
            }
            if (dgvThanhVien.Columns.Contains("Lop"))
            {
                dgvThanhVien.Columns["Lop"].Width = 80; // Đặt độ rộng cột Giới Tính là 80px
                dgvThanhVien.Columns["Lop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Canh giữa nội dung
            }

            dgvThanhVien.Columns["HoTen"].HeaderText = "Họ và Tên";
            dgvThanhVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvThanhVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvThanhVien.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvThanhVien.Columns["Nganh"].HeaderText = "Ngành";
            dgvThanhVien.Columns["Lop"].HeaderText = "Lớp";
            dgvThanhVien.Columns["Khoa"].HeaderText = "Khoa";
            dgvThanhVien.Columns["MSSV"].HeaderText = "MSSV";

        }

        private void btnSearchTV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchTV.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadDanhSachThanhVien(); // Nếu để trống thì load lại toàn bộ
            }
            else
            {
                TimKiemThanhVien(keyword);
            }
        }

        private void txtSearchTV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchTV.PerformClick(); // Giả lập click nút tìm
                e.SuppressKeyPress = true; // Ngăn tiếng 'ding' khi Enter
            }
        }

        private void btnAddTV_Click(object sender, EventArgs e)
        {
            // Mở Form_ThemThanhVien như một cửa sổ con
            Form_ThemThanhVien form = new Form_ThemThanhVien(); // Tạo mới form thêm thành viên
            DialogResult result = form.ShowDialog();  // Hiển thị dưới dạng cửa sổ con

            if (result == DialogResult.OK) // Nếu thêm thành công
            {
                LoadDanhSachThanhVien();  // Reload lại danh sách thành viên
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LoadDanhSachThanhVien();
        }

        private void btnEditTV_Click(object sender, EventArgs e)
        {
            if (dgvThanhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thành viên để sửa.", "Thông báo");
                return;
            }

            // Lấy MSSV từ dòng được chọn
            string mssv = dgvThanhVien.CurrentRow.Cells["MSSV"].Value?.ToString();

            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Không thể lấy MSSV từ dòng được chọn.", "Lỗi");
                return;
            }

            ThanhVienBUS bus = new ThanhVienBUS();
            ThanhVienDTO tv = bus.TimThanhVienTheoMSSV(mssv);

            if (tv == null)
            {
                MessageBox.Show("Không tìm thấy thông tin thành viên.", "Lỗi");
                return;
            }

            Form_SuaThanhVien form = new Form_SuaThanhVien(tv);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadDanhSachThanhVien(); // Cập nhật lại danh sách sau khi sửa
            }
        }

        private void btnDeleteTV_Click(object sender, EventArgs e)
        {
            if (dgvThanhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn thành viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MSSV từ dòng được chọn
            string mssv = dgvThanhVien.CurrentRow.Cells["MSSV"].Value?.ToString();

            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Không thể lấy MSSV từ dòng được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm thông tin thành viên để lấy UserId
            ThanhVienBUS bus = new ThanhVienBUS();
            ThanhVienDTO tv = bus.TimThanhVienTheoMSSV(mssv);

            if (tv == null)
            {
                MessageBox.Show("Không tìm thấy thông tin thành viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị hộp thoại xác nhận
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa thành viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Gọi phương thức xóa
                string error;
                bool result = bus.XoaThanhVien(tv.UserId, out error);

                if (result)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachThanhVien(); // Load lại danh sách thành viên
                }
                else
                {
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn file Excel
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                openFileDialog.Title = "Chọn file Excel để nhập thành viên";

                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    // Đọc file Excel
                    using (var package = new OfficeOpenXml.ExcelPackage(new FileInfo(openFileDialog.FileName)))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Lấy sheet đầu tiên
                        int rowCount = worksheet.Dimension.Rows;
                        List<ThanhVienDTO> danhSachThanhVien = new List<ThanhVienDTO>();

                        // Đọc từ dòng thứ 2 (bỏ qua header)
                        for (int row = 2; row <= rowCount; row++)
                        {
                            // Kiểm tra dòng trống
                            if (string.IsNullOrWhiteSpace(worksheet.Cells[row, 1].Text) &&
                                string.IsNullOrWhiteSpace(worksheet.Cells[row, 2].Text))
                                continue; // Bỏ qua dòng trống

                            // Đọc dữ liệu từ file Excel
                            string birthdayStr = worksheet.Cells[row, 4].Text;
                            ThanhVienDTO tv = new ThanhVienDTO
                            {
                                FullName = worksheet.Cells[row, 1].Text, // Cột A (1): Họ và Tên
                                MSSV = worksheet.Cells[row, 2].Text,     // Cột B (2): MSSV
                                Gender = worksheet.Cells[row, 3].Text,   // Cột C (3): Giới Tính
                                Birthday = DateTime.TryParse(birthdayStr, out DateTime birthday) ? birthday : DateTime.Now, // Cột D (4): Ngày Sinh
                                Phone = worksheet.Cells[row, 5].Text,    // Cột E (5): Số Điện Thoại
                                Science = worksheet.Cells[row, 6].Text,  // Cột F (6): Ngành
                                Class = worksheet.Cells[row, 7].Text,    // Cột G (7): Lớp
                                Branch = worksheet.Cells[row, 8].Text     // Cột H (8): Khoa
                            };
                            danhSachThanhVien.Add(tv);
                        }

                        // Nếu không có dữ liệu để nhập
                        if (!danhSachThanhVien.Any())
                        {
                            MessageBox.Show("File Excel không chứa dữ liệu hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Gọi BUS để nhập danh sách thành viên
                        ThanhVienBUS bus = new ThanhVienBUS();
                        string error;
                        bool result = bus.NhapTVExcel(danhSachThanhVien, out error);

                        if (result)
                        {
                            MessageBox.Show("Nhập thành viên từ Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDanhSachThanhVien(); // Load lại danh sách
                        }
                        else
                        {
                            MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi nhập file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            Form_CheckIn form = new Form_CheckIn();
            DialogResult result = form.ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Form_MuonTra fMuonTra = new Form_MuonTra();
            fMuonTra.ShowDialog();
        }

        private void btnXoaTheoNam_Click(object sender, EventArgs e)
        {
            string yearText = txtNamKichHoat.Text.Trim();
            if (string.IsNullOrEmpty(yearText))
            {
                MessageBox.Show("Vui lòng nhập năm kích hoạt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(yearText, out int year))
            {
                MessageBox.Show("Năm kích hoạt phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirmResult = MessageBox.Show(
                $"Bạn có muốn xóa những thành viên trong năm {year} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            ThanhVienBUS thanhVienBUS = new ThanhVienBUS();
            var (success, error) = thanhVienBUS.DeleteThanhVienByYear(year);
            if (success)
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachThanhVien(); // Tải lại dữ liệu để cập nhật giao diện
            }
            else
            {
                MessageBox.Show(error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


       

            
        
    

