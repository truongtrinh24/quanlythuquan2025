using quanlyThuQuan.BUS;

namespace quanlyThuQuan.GUI.ThongKe
{
    partial class UC_ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        private StatisticalBUS statisticalBUS = new StatisticalBUS();
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage3 = new TabPage();
            panel1 = new Panel();
            dateStart_TB = new DateTimePicker();
            dateEnd_TB = new DateTimePicker();
            cbLoc = new ComboBox();
            btnLoc = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            tableThongKeThietBi = new DataGridView();
            label5 = new Label();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            dateStart_ThanhVien = new DateTimePicker();
            dateEnd_ThanhVien = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            cbKhoa = new ComboBox();
            label9 = new Label();
            cbNganh = new ComboBox();
            btnLocThanhVien = new Button();
            btnReset = new Button();
            charThongKeThanhVien = new Panel();
            tabPage1 = new TabPage();
            panelCharThongKeViPham = new Panel();
            tableThongKeViPham = new DataGridView();
            label13 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            textChuaXuLy = new TextBox();
            textTongTienPhat = new TextBox();
            label11 = new Label();
            textDaXuLy = new TextBox();
            label10 = new Label();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeThietBi).BeginInit();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeViPham).BeginInit();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(tableThongKeThietBi);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1063, 801);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "  Thiết Bị";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLoc);
            panel1.Controls.Add(cbLoc);
            panel1.Controls.Add(dateEnd_TB);
            panel1.Controls.Add(dateStart_TB);
            panel1.Location = new Point(15, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 146);
            panel1.TabIndex = 4;
            // 
            // dateStart_TB
            // 
            dateStart_TB.Location = new Point(170, 33);
            dateStart_TB.Name = "dateStart_TB";
            dateStart_TB.Size = new Size(250, 27);
            dateStart_TB.TabIndex = 1;
            // 
            // dateEnd_TB
            // 
            dateEnd_TB.Location = new Point(536, 35);
            dateEnd_TB.Name = "dateEnd_TB";
            dateEnd_TB.Size = new Size(261, 27);
            dateEnd_TB.TabIndex = 2;
            // 
            // cbLoc
            // 
            cbLoc.FormattingEnabled = true;
            cbLoc.Items.AddRange(new object[] { "Lọc theo thời gian", "Lọc theo tên thiết bị", "Lọc cả 2 điều kiện" });
            cbLoc.Location = new Point(536, 86);
            cbLoc.Name = "cbLoc";
            cbLoc.Size = new Size(261, 28);
            cbLoc.TabIndex = 7;
            cbLoc.Text = "Lọc cả 2 điều kiện";
            cbLoc.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.PaleGreen;
            btnLoc.Location = new Point(879, 52);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(100, 40);
            btnLoc.TabIndex = 8;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 9;
            label1.Text = "Thời gian ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 35);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 10;
            label2.Text = "đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 90);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 11;
            label3.Text = "Loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 90);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 12;
            label4.Text = "Tên thiết bị";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 13;
            // 
            // tableThongKeThietBi
            // 
            tableThongKeThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableThongKeThietBi.Location = new Point(29, 248);
            tableThongKeThietBi.Name = "tableThongKeThietBi";
            tableThongKeThietBi.RowHeadersWidth = 51;
            tableThongKeThietBi.Size = new Size(1002, 409);
            tableThongKeThietBi.TabIndex = 5;
            tableThongKeThietBi.CellContentClick += tableThongKeThietBi_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(381, 196);
            label5.Name = "label5";
            label5.Size = new Size(288, 28);
            label5.TabIndex = 6;
            label5.Text = "Thống Kê Thiết Bị Được Mượn";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(charThongKeThanhVien);
            tabPage2.Controls.Add(btnReset);
            tabPage2.Controls.Add(btnLocThanhVien);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1063, 801);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thành Viên";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbNganh);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cbKhoa);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dateEnd_ThanhVien);
            panel2.Controls.Add(dateStart_ThanhVien);
            panel2.Location = new Point(55, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(737, 125);
            panel2.TabIndex = 4;
            // 
            // dateStart_ThanhVien
            // 
            dateStart_ThanhVien.Location = new Point(112, 14);
            dateStart_ThanhVien.Name = "dateStart_ThanhVien";
            dateStart_ThanhVien.Size = new Size(250, 27);
            dateStart_ThanhVien.TabIndex = 1;
            // 
            // dateEnd_ThanhVien
            // 
            dateEnd_ThanhVien.Location = new Point(456, 14);
            dateEnd_ThanhVien.Name = "dateEnd_ThanhVien";
            dateEnd_ThanhVien.Size = new Size(250, 27);
            dateEnd_ThanhVien.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 14);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 2;
            label7.Text = "đến";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 19);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 0;
            label6.Text = "Thời gian";
            label6.Click += label6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 82);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 4;
            label8.Text = "Khoa";
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(112, 79);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(250, 28);
            cbKhoa.TabIndex = 5;
            cbKhoa.SelectedIndexChanged += cbKhoa_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(397, 85);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 6;
            label9.Text = "Ngành";
            label9.Click += label9_Click;
            // 
            // cbNganh
            // 
            cbNganh.FormattingEnabled = true;
            cbNganh.Location = new Point(456, 82);
            cbNganh.Name = "cbNganh";
            cbNganh.Size = new Size(245, 28);
            cbNganh.TabIndex = 7;
            // 
            // btnLocThanhVien
            // 
            btnLocThanhVien.Location = new Point(852, 34);
            btnLocThanhVien.Name = "btnLocThanhVien";
            btnLocThanhVien.Size = new Size(130, 51);
            btnLocThanhVien.TabIndex = 5;
            btnLocThanhVien.Text = "Lọc";
            btnLocThanhVien.UseVisualStyleBackColor = true;
            btnLocThanhVien.Click += btnLocThanhVien_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(852, 110);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 49);
            btnReset.TabIndex = 6;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button2_Click;
            // 
            // charThongKeThanhVien
            // 
            charThongKeThanhVien.Location = new Point(55, 185);
            charThongKeThanhVien.Name = "charThongKeThanhVien";
            charThongKeThanhVien.Size = new Size(927, 454);
            charThongKeThanhVien.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(tableThongKeViPham);
            tabPage1.Controls.Add(panelCharThongKeViPham);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1063, 801);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vi Phạm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelCharThongKeViPham
            // 
            panelCharThongKeViPham.Location = new Point(18, 33);
            panelCharThongKeViPham.Name = "panelCharThongKeViPham";
            panelCharThongKeViPham.Size = new Size(702, 357);
            panelCharThongKeViPham.TabIndex = 0;
            // 
            // tableThongKeViPham
            // 
            tableThongKeViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableThongKeViPham.Location = new Point(66, 449);
            tableThongKeViPham.Name = "tableThongKeViPham";
            tableThongKeViPham.RowHeadersWidth = 51;
            tableThongKeViPham.Size = new Size(932, 270);
            tableThongKeViPham.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(434, 415);
            label13.Name = "label13";
            label13.Size = new Size(215, 31);
            label13.TabIndex = 8;
            label13.Text = "Danh Sách Vi Phạm";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textDaXuLy);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textTongTienPhat);
            panel3.Controls.Add(textChuaXuLy);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(769, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 227);
            panel3.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(63, 102);
            label12.Name = "label12";
            label12.Size = new Size(152, 28);
            label12.TabIndex = 5;
            label12.Text = "Tổng tiền phạt";
            label12.Click += label12_Click;
            // 
            // textChuaXuLy
            // 
            textChuaXuLy.Location = new Point(111, 54);
            textChuaXuLy.Name = "textChuaXuLy";
            textChuaXuLy.ReadOnly = true;
            textChuaXuLy.Size = new Size(125, 27);
            textChuaXuLy.TabIndex = 4;
            textChuaXuLy.TextAlign = HorizontalAlignment.Center;
            // 
            // textTongTienPhat
            // 
            textTongTienPhat.Location = new Point(22, 142);
            textTongTienPhat.Name = "textTongTienPhat";
            textTongTienPhat.ReadOnly = true;
            textTongTienPhat.Size = new Size(226, 27);
            textTongTienPhat.TabIndex = 6;
            textTongTienPhat.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 54);
            label11.Name = "label11";
            label11.Size = new Size(78, 20);
            label11.TabIndex = 2;
            label11.Text = "Chưa xử lý";
            // 
            // textDaXuLy
            // 
            textDaXuLy.Location = new Point(111, 9);
            textDaXuLy.Name = "textDaXuLy";
            textDaXuLy.ReadOnly = true;
            textDaXuLy.Size = new Size(125, 27);
            textDaXuLy.TabIndex = 3;
            textDaXuLy.TextAlign = HorizontalAlignment.Center;
            textDaXuLy.TextChanged += textDaXuLy_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 9);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 1;
            label10.Text = "Đã xử lý";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 834);
            tabControl1.TabIndex = 0;
            // 
            // UC_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_ThongKe";
            Size = new Size(1077, 840);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeThietBi).EndInit();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeViPham).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private Label label5;
        private DataGridView tableThongKeThietBi;
        private Panel panel1;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLoc;
        private ComboBox cbLoc;
        private DateTimePicker dateEnd_TB;
        private DateTimePicker dateStart_TB;
        private TabPage tabPage2;
        private Panel charThongKeThanhVien;
        private Button btnReset;
        private Button btnLocThanhVien;
        private Panel panel2;
        private ComboBox cbNganh;
        private Label label9;
        private ComboBox cbKhoa;
        private Label label8;
        private Label label6;
        private Label label7;
        private DateTimePicker dateEnd_ThanhVien;
        private DateTimePicker dateStart_ThanhVien;
        private TabPage tabPage1;
        private Panel panel3;
        private Label label10;
        private TextBox textDaXuLy;
        private Label label11;
        private TextBox textTongTienPhat;
        private TextBox textChuaXuLy;
        private Label label12;
        private Label label13;
        private DataGridView tableThongKeViPham;
        private Panel panelCharThongKeViPham;
        private TabControl tabControl1;
    }
}
