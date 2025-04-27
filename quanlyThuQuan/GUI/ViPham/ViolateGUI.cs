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

namespace quanlyThuQuan.GUI.ViPham
{
    public partial class ViolateGUI : Form
    {
        ViolateBUS violateBUS = new ViolateBUS();
        public ViolationDTO SelectedViolation { get; set; }
        public ViolationRequest ViolationRequest { get; set; }
        public ViolateGUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ViolateGUI_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
            {
                "Khóa thẻ 1 tháng",
                "Khóa thẻ 2 tháng",
                "Khóa thẻ vĩnh viễn",
                "bồi thường",
                "Khóa thẻ 1 tháng và bồi thường",
                "Khóa thẻ 2 tháng và bồi thường",
                "Khóa thẻ vĩnh viễn và bồi thường"
            });
            amount.Enabled = false;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            if (SelectedViolation != null)
            {
                if (!string.IsNullOrEmpty(SelectedViolation.Description))
                {
                    if (comboBox1.Items.Contains(SelectedViolation.Description))
                    {
                        comboBox1.SelectedItem = SelectedViolation.Description;
                    }
                    else
                    {
                        comboBox1.Text = SelectedViolation.Description;
                        MessageBox.Show("Loại vi phạm không khớp với danh sách, vui lòng kiểm tra!");
                    }
                }
                if (!string.IsNullOrEmpty(SelectedViolation.Description) && SelectedViolation.Description.Contains("bồi thường"))
                {
                    amount.Enabled = true;
                    amount.Text = SelectedViolation.FineAmount > 0 ? SelectedViolation.FineAmount.ToString() : string.Empty;
                }
            }
            else
            {
                SelectedViolation = new ViolationDTO();
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedOption = comboBox1.SelectedItem?.ToString();
            if (selectedOption != null && selectedOption.Contains("bồi thường"))
            {
                amount.Enabled = true;
            }
            else
            {
                amount.Enabled = false;
                amount.Text = string.Empty;
            }
        }
        // thêm
        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn loại vi phạm!");
                    return;
                }
                string description = comboBox1.SelectedItem.ToString();
                decimal fineAmount = 0;
                bool requiresCompensation = description.Contains("bồi thường");

                if (requiresCompensation && string.IsNullOrWhiteSpace(amount.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tiền bồi thường!");
                    return;
                }
                if (requiresCompensation && !decimal.TryParse(amount.Text, out fineAmount))
                {
                    MessageBox.Show("Số tiền phạt không hợp lệ!");
                    return;
                }
                SelectedViolation.Description = description;
                SelectedViolation.ViolationTime = DateTime.Now;

                SelectedViolation.FineAmount = requiresCompensation ? fineAmount : 0;

                SelectedViolation.BookingId = ViolationRequest.BookingId;
                SelectedViolation.UserId = ViolationRequest.UserId;
                SelectedViolation.DeviceId = ViolationRequest.DeviceId;

                violateBUS.AddViolation(SelectedViolation);
                violateBUS.UpdateUserStatus(SelectedViolation.UserId, 0);
                MessageBox.Show("Vi phạm đã được lưu thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vi phạm: " + ex.Message);
            }
        }
        // close
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // sửa
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn loại vi phạm!");
                    return;
                }
                string description = comboBox1.SelectedItem.ToString();
                decimal fineAmount = 0;
                bool requiresCompensation = description.Contains("bồi thường");

                if (requiresCompensation && string.IsNullOrWhiteSpace(amount.Text))
                {
                    MessageBox.Show("Vui lòng nhập số tiền bồi thường!");
                    return;
                }
                if (requiresCompensation && !decimal.TryParse(amount.Text, out fineAmount))
                {
                    MessageBox.Show("Số tiền phạt không hợp lệ!");
                    return;
                }
                SelectedViolation.Description = description;
                SelectedViolation.ViolationTime = DateTime.Now;

                SelectedViolation.FineAmount = requiresCompensation ? fineAmount : 0;

                violateBUS.UpdateViolation(SelectedViolation);
                violateBUS.UpdateUserStatus(SelectedViolation.UserId, 0);
                MessageBox.Show("Vi phạm đã được sửa thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vi phạm: " + ex.Message);
            }
        }
    }
}
