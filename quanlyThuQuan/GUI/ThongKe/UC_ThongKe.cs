using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using quanlyThuQuan.BUS;
using quanlyThuQuan.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace quanlyThuQuan.GUI.ThongKe
{
    public partial class UC_ThongKe : UserControl
    {
        private Chart chartThongKe;
        public UC_ThongKe()
        {
            InitializeComponent();
            LoadBookingData();
            chartThongKe = new Chart();
            charThongKeThanhVien.Controls.Add(chartThongKe);

            charThongKeThanhVien.Controls.Add(chartThongKe);
            //charThongKeThanhVien.Location = new Point(15, 50);
            charThongKeThanhVien.Name = "panelChartThongKe";
            charThongKeThanhVien.Size = new Size(950, 550);
            charThongKeThanhVien.TabIndex = 0;
            charThongKeThanhVien.BorderStyle = BorderStyle.FixedSingle;

            // chartThongKe
            chartThongKe.Dock = DockStyle.Fill; // Đặt Dock để lấp đầy panelChartThongKe
            chartThongKe.Location = new Point(0, 0);
            chartThongKe.Name = "chartThongKe";
            chartThongKe.Size = new Size(1000, 600); // Kích thước sẽ tự động điều chỉnh nhờ Dock
            chartThongKe.TabIndex = 0;


            DrawMemberCountChart();


            // load data khoa + nganh
            LoadKhoa();
            LoadNganh();


            //chart area thống kê vi phạm
            CreatePieChart();

            //load datat thong ke vi pham

            LoadDataViPham();
        }

        private void CreatePieChart()
        {
            try
            {
                var violationStats = statisticalBUS.GetViolationStatistics();

                // Kiểm tra dữ liệu
                if (violationStats == null || violationStats.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu vi phạm để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Debug dữ liệu
                foreach (var stats in violationStats)
                {
                    var stat = (dynamic)stats;
                    Console.WriteLine($"Description: {stat.Description}, Processed: {stat.ProcessedCount}, Unprocessed: {stat.UnprocessedCount}");
                }

                // Kiểm tra panel
                Console.WriteLine($"Panel Size: {panelCharThongKeViPham.Size}");
                panelCharThongKeViPham.Visible = true;

                // Tạo Chart control
                Chart pieChart = new Chart();
                pieChart.Size = panelCharThongKeViPham.Size;
                pieChart.Location = new System.Drawing.Point(0, 0);

                // Tạo ChartArea
                ChartArea chartArea = new ChartArea();
                pieChart.ChartAreas.Add(chartArea);

                // Tạo Series cho "Đã xử lý" (màu xanh)
                Series seriesProcessed = new Series("Đã xử lý");
                seriesProcessed.ChartType = SeriesChartType.Pie;
                seriesProcessed.Color = System.Drawing.Color.Green; // Màu xanh cho đã xử lý

                // Tạo Series cho "Chưa xử lý" (màu vàng)
                Series seriesUnprocessed = new Series("Chưa xử lý");
                seriesUnprocessed.ChartType = SeriesChartType.Pie;
                seriesUnprocessed.Color = System.Drawing.Color.Yellow; // Màu vàng cho chưa xử lý

                // Thêm dữ liệu vào các Series
                foreach (var stats in violationStats)
                {
                    var stat = (dynamic)stats;
                    if (stat.ProcessedCount > 0)
                    {
                        seriesProcessed.Points.AddXY(stat.Description, stat.ProcessedCount);
                    }
                    if (stat.UnprocessedCount > 0)
                    {
                        seriesUnprocessed.Points.AddXY(stat.Description, stat.UnprocessedCount);
                    }
                }

                // Tùy chỉnh hiển thị cho Series
                seriesProcessed["PieLabelStyle"] = "Outside";
                seriesProcessed["PieLineColor"] = "Black";
                seriesProcessed.IsValueShownAsLabel = true;
                seriesProcessed.LabelFormat = "{0}";

                seriesUnprocessed["PieLabelStyle"] = "Outside";
                seriesUnprocessed["PieLineColor"] = "Black";
                seriesUnprocessed.IsValueShownAsLabel = true;
                seriesUnprocessed.LabelFormat = "{0}";

                // Thêm các Series vào chart
                pieChart.Series.Add(seriesProcessed);
                pieChart.Series.Add(seriesUnprocessed);

                // Tùy chỉnh tiêu đề
                pieChart.Titles.Add("Thống kê vi phạm");
                pieChart.Titles[0].Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

                // Thêm chú thích (Legend) để hiển thị ý nghĩa màu sắc
                Legend legend = new Legend();
                legend.Title = "Chú thích";
                pieChart.Legends.Add(legend);
                pieChart.Legends[0].Docking = Docking.Right; // Đặt chú thích bên phải biểu đồ

                // Xóa biểu đồ cũ và thêm biểu đồ mới vào panel
                panelCharThongKeViPham.Controls.Clear();
                panelCharThongKeViPham.Controls.Add(pieChart);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawMemberCountChart()
        {
            try
            {
                // Giả định bạn có một Chart control tên là "memberChart" trong form
                chartThongKe.Series.Clear();
                chartThongKe.ChartAreas.Clear();

                // Tạo ChartArea
                ChartArea chartArea = new ChartArea();
                chartArea.Name = "MemberCheckInArea";
                chartArea.AxisX.Title = "Ngày";
                chartArea.AxisY.Title = "Số lượng thành viên";
                chartArea.AxisX.Interval = 1; // Hiển thị mỗi ngày
                chartArea.AxisX.LabelStyle.Format = "yyyy-MM-dd"; // Định dạng ngày
                chartThongKe.ChartAreas.Add(chartArea);

                // Tạo Series
                Series series = new Series("MemberCount");
                series.ChartType = SeriesChartType.Column; // Biểu đồ cột, có thể thay bằng Line, Area, v.v.
                series.XValueType = ChartValueType.DateTime;
                series.YValueType = ChartValueType.Int32;
                series.BorderWidth = 2;
                series.Color = System.Drawing.Color.Blue;

                // Lấy dữ liệu từ StatisticalBUS
                var memberCheckInStats = statisticalBUS.GetDataAllMemberCheckIn();

                // Thêm dữ liệu vào Series
                foreach (var entry in memberCheckInStats)
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(entry.Key, entry.Value.MemberCount);
                    point.ToolTip = $"Ngày: {entry.Key:yyyy-MM-dd}\nSố thành viên: {entry.Value.MemberCount}";
                    series.Points.Add(point);
                }

                // Thêm Series vào Chart
                chartThongKe.Series.Add(series);

                // Cấu hình thêm cho Chart
                chartThongKe.Titles.Clear();
                chartThongKe.Titles.Add("Thống kê số lượng thành viên check-in");
                chartThongKe.Titles[0].Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi vẽ biểu đồ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ cbLoc
            string filterType = cbLoc.SelectedItem?.ToString();

            // Kiểm tra nếu filterType là null (tránh lỗi khi chưa chọn gì)
            if (string.IsNullOrEmpty(filterType))
            {
                // Mặc định vô hiệu hóa tất cả control nếu chưa chọn gì
                textBox1.Enabled = false;
                dateStart_TB.Enabled = false;
                dateEnd_TB.Enabled = false;
                return;
            }

            // Xử lý từng trường hợp
            if (filterType == "Lọc theo thời gian")
            {
                // Chỉ cho phép chọn thời gian, vô hiệu hóa nhập tên thiết bị
                textBox1.Enabled = false;
                dateStart_TB.Enabled = true;
                dateEnd_TB.Enabled = true;
            }
            else if (filterType == "Lọc theo tên thiết bị")
            {
                // Chỉ cho phép nhập tên thiết bị, vô hiệu hóa chọn thời gian
                textBox1.Enabled = true;
                dateStart_TB.Enabled = false;
                dateEnd_TB.Enabled = false;
            }
            else if (filterType == "Lọc cả 2 điều kiện")
            {
                // Cho phép sử dụng cả thời gian và tên thiết bị
                textBox1.Enabled = true;
                dateStart_TB.Enabled = true;
                dateEnd_TB.Enabled = true;
            }
            else
            {
                // Trường hợp không xác định (dự phòng nếu có giá trị khác)
                textBox1.Enabled = false;
                dateStart_TB.Enabled = false;
                dateEnd_TB.Enabled = false;
            }
        }


        private void LoadBookingData()
        {
            try
            {
                // Gọi BUS để lấy tất cả bản ghi (không áp dụng bộ lọc)
                var bookings = statisticalBUS.GetDeviceByCondition();

                // Thêm STT và định dạng ngày tháng
                var bindingList = bookings.Select((booking, index) => new
                {
                    STT = index + 1,
                    BookingId = booking.GetType().GetProperty("BookingId")?.GetValue(booking),
                    UserId = booking.GetType().GetProperty("UserId")?.GetValue(booking),
                    DeviceId = booking.GetType().GetProperty("DeviceId")?.GetValue(booking),
                    DeviceName = booking.GetType().GetProperty("DeviceName")?.GetValue(booking),
                    StartTime = Convert.ToDateTime(booking.GetType().GetProperty("StartTime")?.GetValue(booking)).ToString("M/d/yyyy"),
                    EndTime = Convert.ToDateTime(booking.GetType().GetProperty("EndTime")?.GetValue(booking)).ToString("M/d/yyyy"),
                    Status = booking.GetType().GetProperty("Status")?.GetValue(booking),
                    CreatedAt = Convert.ToDateTime(booking.GetType().GetProperty("CreatedAt")?.GetValue(booking)).ToString("M/d/yyyy"),
                    ActualTime = booking.GetType().GetProperty("ActualTime")?.GetValue(booking) != null
                        ? Convert.ToDateTime(booking.GetType().GetProperty("ActualTime")?.GetValue(booking)).ToString("M/d/yyyy")
                        : null
                }).ToList();

                // Gán dữ liệu vào DataGridView
                tableThongKeThietBi.DataSource = bindingList;

                // Tùy chỉnh tiêu đề cột
                tableThongKeThietBi.Columns["STT"].HeaderText = "STT";
                tableThongKeThietBi.Columns["BookingId"].HeaderText = "Mã Đặt";
                tableThongKeThietBi.Columns["UserId"].HeaderText = "Mã Người Dùng";
                tableThongKeThietBi.Columns["DeviceId"].HeaderText = "Mã Thiết Bị";
                tableThongKeThietBi.Columns["DeviceName"].HeaderText = "Tên Thiết Bị";
                tableThongKeThietBi.Columns["StartTime"].HeaderText = "Thời Gian Mượn";
                tableThongKeThietBi.Columns["EndTime"].HeaderText = "Thời Gian Trả";
                tableThongKeThietBi.Columns["Status"].HeaderText = "Trạng Thái";
                tableThongKeThietBi.Columns["CreatedAt"].HeaderText = "Ngày Tạo";
                tableThongKeThietBi.Columns["ActualTime"].HeaderText = "Thời Gian Thực Tế";

                // Tùy chỉnh độ rộng và canh giữa cho một số cột
                if (tableThongKeThietBi.Columns.Contains("STT"))
                {
                    tableThongKeThietBi.Columns["STT"].Width = 40;
                    tableThongKeThietBi.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("BookingId"))
                {
                    tableThongKeThietBi.Columns["BookingId"].Width = 60;
                    tableThongKeThietBi.Columns["BookingId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("UserId"))
                {
                    tableThongKeThietBi.Columns["UserId"].Width = 80;
                    tableThongKeThietBi.Columns["UserId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("DeviceId"))
                {
                    tableThongKeThietBi.Columns["DeviceId"].Width = 80;
                    tableThongKeThietBi.Columns["DeviceId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("Status"))
                {
                    tableThongKeThietBi.Columns["Status"].Width = 80;
                    tableThongKeThietBi.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi load dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateStart_TB.Value > dateEnd_TB.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy dữ liệu từ các control
                string deviceName = textBox1.Text.Trim();
                string filterType = cbLoc.SelectedItem?.ToString() ?? "Lọc cả 2 điều kiện";

                if (filterType == "Lọc cả 2 điều kiện" && string.IsNullOrEmpty(deviceName))
                {
                    MessageBox.Show("Tên thiết bị không được để trống khi lọc cả 2 điều kiện!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gọi BUS để lấy danh sách booking
                var bookings = statisticalBUS.GetDeviceByCondition(dateStart_TB, dateEnd_TB, deviceName, filterType);

                // Thêm STT và định dạng ngày tháng
                var bindingList = bookings.Select((booking, index) => new
                {
                    STT = index + 1,
                    BookingId = booking.GetType().GetProperty("BookingId")?.GetValue(booking),
                    UserId = booking.GetType().GetProperty("UserId")?.GetValue(booking),
                    DeviceId = booking.GetType().GetProperty("DeviceId")?.GetValue(booking),
                    DeviceName = booking.GetType().GetProperty("DeviceName")?.GetValue(booking),
                    StartTime = Convert.ToDateTime(booking.GetType().GetProperty("StartTime")?.GetValue(booking)).ToString("M/d/yyyy"),
                    EndTime = Convert.ToDateTime(booking.GetType().GetProperty("EndTime")?.GetValue(booking)).ToString("M/d/yyyy"),
                    Status = booking.GetType().GetProperty("Status")?.GetValue(booking),
                    CreatedAt = Convert.ToDateTime(booking.GetType().GetProperty("CreatedAt")?.GetValue(booking)).ToString("M/d/yyyy"),
                    ActualTime = booking.GetType().GetProperty("ActualTime")?.GetValue(booking) != null
                        ? Convert.ToDateTime(booking.GetType().GetProperty("ActualTime")?.GetValue(booking)).ToString("M/d/yyyy")
                        : null
                }).ToList();

                // Gán dữ liệu vào DataGridView
                tableThongKeThietBi.DataSource = bindingList;

                // Tùy chỉnh tiêu đề cột
                tableThongKeThietBi.Columns["STT"].HeaderText = "STT";
                tableThongKeThietBi.Columns["BookingId"].HeaderText = "Mã Đặt";
                tableThongKeThietBi.Columns["UserId"].HeaderText = "Mã Người Dùng";
                tableThongKeThietBi.Columns["DeviceId"].HeaderText = "Mã Thiết Bị";
                tableThongKeThietBi.Columns["DeviceName"].HeaderText = "Tên Thiết Bị";
                tableThongKeThietBi.Columns["StartTime"].HeaderText = "Thời Gian Mượn";
                tableThongKeThietBi.Columns["EndTime"].HeaderText = "Thời Gian Trả";
                tableThongKeThietBi.Columns["Status"].HeaderText = "Trạng Thái";
                tableThongKeThietBi.Columns["CreatedAt"].HeaderText = "Ngày Tạo";
                tableThongKeThietBi.Columns["ActualTime"].HeaderText = "Thời Gian Thực Tế";

                // Tùy chỉnh độ rộng và canh giữa cho một số cột
                if (tableThongKeThietBi.Columns.Contains("STT"))
                {
                    tableThongKeThietBi.Columns["STT"].Width = 40;
                    tableThongKeThietBi.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("BookingId"))
                {
                    tableThongKeThietBi.Columns["BookingId"].Width = 60;
                    tableThongKeThietBi.Columns["BookingId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("UserId"))
                {
                    tableThongKeThietBi.Columns["UserId"].Width = 80;
                    tableThongKeThietBi.Columns["UserId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("DeviceId"))
                {
                    tableThongKeThietBi.Columns["DeviceId"].Width = 80;
                    tableThongKeThietBi.Columns["DeviceId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (tableThongKeThietBi.Columns.Contains("Status"))
                {
                    tableThongKeThietBi.Columns["Status"].Width = 80;
                    tableThongKeThietBi.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableThongKeThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbKhoa.SelectedItem = "Tất cả";
            cbNganh.SelectedItem = "Tất cả";

            DrawMemberCountChart();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void LoadKhoa()
        {
            cbKhoa.Items.Clear();
            cbKhoa.Items.Add("Tất cả"); // Thêm giá trị mặc định "Tất cả"
            cbKhoa.Items.AddRange(statisticalBUS.LayDanhSachKhoa().ToArray());
            cbKhoa.SelectedIndex = 0; // Chọn "Tất cả" làm giá trị mặc định
        }

        public void LoadNganh()
        {
            cbNganh.Items.Clear();
            cbNganh.Items.Add("Tất cả"); // Thêm giá trị mặc định "Tất cả"
            cbNganh.Items.AddRange(statisticalBUS.LayDanhSachNganh().ToArray());
            cbNganh.SelectedIndex = 0; // Chọn "Tất cả" làm giá trị mặc định
        }

        private void btnLocThanhVien_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateStart = dateStart_ThanhVien.Value.Date;
                DateTime dateEnd = dateEnd_ThanhVien.Value.Date;
                string branch = cbKhoa.SelectedItem?.ToString() ?? "Tất cả";
                string science = cbNganh.SelectedItem?.ToString() ?? "Tất cả";

                if (dateStart > dateEnd)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                chartThongKe.Series.Clear();
                chartThongKe.ChartAreas.Clear();

                ChartArea chartArea = new ChartArea();
                chartArea.Name = "MemberCheckInArea";
                chartArea.AxisX.Title = "Ngày";
                chartArea.AxisY.Title = "Số lượng thành viên";
                chartArea.AxisX.Interval = 1;
                chartArea.AxisX.LabelStyle.Format = "yyyy-MM-dd";
                chartArea.AxisX.Minimum = dateStart.ToOADate();
                chartArea.AxisX.Maximum = dateEnd.ToOADate();
                chartThongKe.ChartAreas.Add(chartArea);
                

                Series series = new Series("MemberCount");
                series.ChartType = SeriesChartType.Column; 
                series.XValueType = ChartValueType.DateTime;
                series.YValueType = ChartValueType.Int32;
                series.Color = System.Drawing.Color.Blue;

          
                var memberCheckInStats = statisticalBUS.GetMemberCheckInCountByDate(dateStart, dateEnd, branch, science);

                Console.WriteLine("Quantity memember :", memberCheckInStats);
            
                foreach (var entry in memberCheckInStats)
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(entry.Key, entry.Value.MemberCount); 
                    point.ToolTip = $"Ngày: {entry.Key:yyyy-MM-dd}\nSố thành viên: {entry.Value.MemberCount}"; // Sử dụng MemberCount
                    series.Points.Add(point);
                }

      
                chartThongKe.Series.Add(series);

            
                chartThongKe.Titles.Clear();
                string title = "Thống kê số lượng thành viên check-in";
                if (branch != "Tất cả") title += $" (Khoa: {branch})";
                if (science != "Tất cả") title += $" (Ngành: {science})";
                chartThongKe.Titles.Add(title);
                chartThongKe.Titles[0].Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataViPham()
        {
            try
            {
                // Lấy dữ liệu từ BUS
                var violationDetails = statisticalBUS.GetViolationDetails();

                // Kiểm tra dữ liệu
                if (violationDetails == null || violationDetails.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu vi phạm để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Tạo DataTable để chứa dữ liệu hiển thị trên DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("STT", typeof(int));
                dt.Columns.Add("Mã VP", typeof(int));
                dt.Columns.Add("Mã TV", typeof(int));
                dt.Columns.Add("Tên thành viên", typeof(string));
                dt.Columns.Add("Hình thức XL", typeof(string));
                dt.Columns.Add("Số tiền phạt", typeof(decimal));
                dt.Columns.Add("Trạng thái XL", typeof(string));

                // Tính tổng các giá trị để gán vào TextBox
                int totalProcessed = 0;
                int totalUnprocessed = 0;
                decimal totalFine = 0;

                // Duyệt qua dữ liệu và thêm vào DataTable
                int stt = 1;
                foreach (var detail in violationDetails)
                {
                    var violation = (dynamic)detail;
                    string status = violation.HandledBy == null ? "Chưa xử lý" : "Đã xử lý";

                    dt.Rows.Add(stt++, violation.ViolationId, violation.UserId, violation.UserName, violation.Description, violation.FineAmount, status);

                    // Cộng dồn để tính tổng
                    if (status == "Đã xử lý")
                    {
                        totalProcessed++;
                    }
                    else
                    {
                        totalUnprocessed++;
                    }
                    totalFine += violation.FineAmount;
                }

                // Gán dữ liệu vào DataGridView
                tableThongKeViPham.DataSource = dt;

                // Định dạng cột "Số tiền phạt" để hiển thị dạng tiền tệ
                tableThongKeViPham.Columns["Số tiền phạt"].DefaultCellStyle.Format = "N0"; // Định dạng số không thập phân

                // Đổi tên hiển thị của cột
                tableThongKeViPham.Columns["STT"].HeaderText = "STT";
                tableThongKeViPham.Columns["Mã VP"].HeaderText = "MÃ VP";
                tableThongKeViPham.Columns["Mã TV"].HeaderText = "MÃ TV";
                tableThongKeViPham.Columns["Tên thành viên"].HeaderText = "Tên thành viên";
                tableThongKeViPham.Columns["Hình thức XL"].HeaderText = "Hình Thức XL";
                tableThongKeViPham.Columns["Số tiền phạt"].HeaderText = "Số Tiền Phạt";
                tableThongKeViPham.Columns["Trạng thái XL"].HeaderText = "Trạng Thái XL";

                // Gán tổng vào các TextBox
                textDaXuLy.Text = totalProcessed.ToString();
                textChuaXuLy.Text = totalUnprocessed.ToString();
                textTongTienPhat.Text = totalFine.ToString("N0"); // Định dạng tiền phạt không thập phân
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textDaXuLy_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
