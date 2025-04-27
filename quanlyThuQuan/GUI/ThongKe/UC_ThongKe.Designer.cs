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
            label5 = new Label();
            tableThongKeThietBi = new DataGridView();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLoc = new Button();
            cbLoc = new ComboBox();
            dateEnd_TB = new DateTimePicker();
            dateStart_TB = new DateTimePicker();
            tabPage2 = new TabPage();
            charThongKeThanhVien = new Panel();
            btnReset = new Button();
            btnLocThanhVien = new Button();
            panel2 = new Panel();
            cbNganh = new ComboBox();
            label9 = new Label();
            cbKhoa = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateEnd_ThanhVien = new DateTimePicker();
            dateStart_ThanhVien = new DateTimePicker();
            tabPage1 = new TabPage();
            panel3 = new Panel();
            label10 = new Label();
            textDaXuLy = new TextBox();
            label11 = new Label();
            textTongTienPhat = new TextBox();
            textChuaXuLy = new TextBox();
            label12 = new Label();
            label13 = new Label();
            tableThongKeViPham = new DataGridView();
            panelCharThongKeViPham = new Panel();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeThietBi).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeViPham).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(tableThongKeThietBi);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(929, 598);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "  Thiết Bị";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(333, 147);
            label5.Name = "label5";
            label5.Size = new Size(230, 21);
            label5.TabIndex = 6;
            label5.Text = "Thống Kê Thiết Bị Được Mượn";
            // 
            // tableThongKeThietBi
            // 
            tableThongKeThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableThongKeThietBi.Location = new Point(25, 186);
            tableThongKeThietBi.Margin = new Padding(3, 2, 3, 2);
            tableThongKeThietBi.Name = "tableThongKeThietBi";
            tableThongKeThietBi.RowHeadersWidth = 51;
            tableThongKeThietBi.Size = new Size(877, 307);
            tableThongKeThietBi.TabIndex = 5;
            tableThongKeThietBi.CellContentClick += tableThongKeThietBi_CellContentClick;
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
            panel1.Location = new Point(13, 26);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 110);
            panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 68);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 23);
            textBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 68);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 12;
            label4.Text = "Tên thiết bị";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 68);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 11;
            label3.Text = "Loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 26);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 10;
            label2.Text = "đến";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 9;
            label1.Text = "Thời gian ";
            // 
            // btnLoc
            // 
            btnLoc.BackColor = Color.PaleGreen;
            btnLoc.Location = new Point(769, 39);
            btnLoc.Margin = new Padding(3, 2, 3, 2);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(88, 30);
            btnLoc.TabIndex = 8;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = false;
            btnLoc.Click += button1_Click;
            // 
            // cbLoc
            // 
            cbLoc.FormattingEnabled = true;
            cbLoc.Items.AddRange(new object[] { "Lọc theo thời gian", "Lọc theo tên thiết bị", "Lọc cả 2 điều kiện" });
            cbLoc.Location = new Point(469, 64);
            cbLoc.Margin = new Padding(3, 2, 3, 2);
            cbLoc.Name = "cbLoc";
            cbLoc.Size = new Size(229, 23);
            cbLoc.TabIndex = 7;
            cbLoc.Text = "Lọc cả 2 điều kiện";
            cbLoc.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dateEnd_TB
            // 
            dateEnd_TB.Location = new Point(469, 26);
            dateEnd_TB.Margin = new Padding(3, 2, 3, 2);
            dateEnd_TB.Name = "dateEnd_TB";
            dateEnd_TB.Size = new Size(229, 23);
            dateEnd_TB.TabIndex = 2;
            // 
            // dateStart_TB
            // 
            dateStart_TB.Location = new Point(149, 25);
            dateStart_TB.Margin = new Padding(3, 2, 3, 2);
            dateStart_TB.Name = "dateStart_TB";
            dateStart_TB.Size = new Size(219, 23);
            dateStart_TB.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(charThongKeThanhVien);
            tabPage2.Controls.Add(btnReset);
            tabPage2.Controls.Add(btnLocThanhVien);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(929, 598);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Thành Viên";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // charThongKeThanhVien
            // 
            charThongKeThanhVien.Location = new Point(48, 139);
            charThongKeThanhVien.Margin = new Padding(3, 2, 3, 2);
            charThongKeThanhVien.Name = "charThongKeThanhVien";
            charThongKeThanhVien.Size = new Size(811, 340);
            charThongKeThanhVien.TabIndex = 7;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(746, 82);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(114, 37);
            btnReset.TabIndex = 6;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button2_Click;
            // 
            // btnLocThanhVien
            // 
            btnLocThanhVien.Location = new Point(746, 26);
            btnLocThanhVien.Margin = new Padding(3, 2, 3, 2);
            btnLocThanhVien.Name = "btnLocThanhVien";
            btnLocThanhVien.Size = new Size(114, 38);
            btnLocThanhVien.TabIndex = 5;
            btnLocThanhVien.Text = "Lọc";
            btnLocThanhVien.UseVisualStyleBackColor = true;
            btnLocThanhVien.Click += btnLocThanhVien_Click;
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
            panel2.Location = new Point(48, 26);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 94);
            panel2.TabIndex = 4;
            // 
            // cbNganh
            // 
            cbNganh.FormattingEnabled = true;
            cbNganh.Location = new Point(399, 62);
            cbNganh.Margin = new Padding(3, 2, 3, 2);
            cbNganh.Name = "cbNganh";
            cbNganh.Size = new Size(215, 23);
            cbNganh.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(347, 64);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 6;
            label9.Text = "Ngành";
            label9.Click += label9_Click;
            // 
            // cbKhoa
            // 
            cbKhoa.FormattingEnabled = true;
            cbKhoa.Location = new Point(98, 59);
            cbKhoa.Margin = new Padding(3, 2, 3, 2);
            cbKhoa.Name = "cbKhoa";
            cbKhoa.Size = new Size(219, 23);
            cbKhoa.TabIndex = 5;
            cbKhoa.SelectedIndexChanged += cbKhoa_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 62);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 4;
            label8.Text = "Khoa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 14);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 0;
            label6.Text = "Thời gian";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 10);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 2;
            label7.Text = "đến";
            // 
            // dateEnd_ThanhVien
            // 
            dateEnd_ThanhVien.Location = new Point(399, 10);
            dateEnd_ThanhVien.Margin = new Padding(3, 2, 3, 2);
            dateEnd_ThanhVien.Name = "dateEnd_ThanhVien";
            dateEnd_ThanhVien.Size = new Size(219, 23);
            dateEnd_ThanhVien.TabIndex = 3;
            // 
            // dateStart_ThanhVien
            // 
            dateStart_ThanhVien.Location = new Point(98, 10);
            dateStart_ThanhVien.Margin = new Padding(3, 2, 3, 2);
            dateStart_ThanhVien.Name = "dateStart_ThanhVien";
            dateStart_ThanhVien.Size = new Size(219, 23);
            dateStart_ThanhVien.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(tableThongKeViPham);
            tabPage1.Controls.Add(panelCharThongKeViPham);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(929, 598);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vi Phạm";
            tabPage1.UseVisualStyleBackColor = true;
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
            panel3.Location = new Point(673, 25);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 171);
            panel3.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 7);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 1;
            label10.Text = "Đã xử lý";
            // 
            // textDaXuLy
            // 
            textDaXuLy.Location = new Point(97, 7);
            textDaXuLy.Margin = new Padding(3, 2, 3, 2);
            textDaXuLy.Name = "textDaXuLy";
            textDaXuLy.ReadOnly = true;
            textDaXuLy.Size = new Size(110, 23);
            textDaXuLy.TabIndex = 3;
            textDaXuLy.TextAlign = HorizontalAlignment.Center;
            textDaXuLy.TextChanged += textDaXuLy_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 40);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 2;
            label11.Text = "Chưa xử lý";
            // 
            // textTongTienPhat
            // 
            textTongTienPhat.Location = new Point(19, 106);
            textTongTienPhat.Margin = new Padding(3, 2, 3, 2);
            textTongTienPhat.Name = "textTongTienPhat";
            textTongTienPhat.ReadOnly = true;
            textTongTienPhat.Size = new Size(198, 23);
            textTongTienPhat.TabIndex = 6;
            textTongTienPhat.TextAlign = HorizontalAlignment.Center;
            // 
            // textChuaXuLy
            // 
            textChuaXuLy.Location = new Point(97, 40);
            textChuaXuLy.Margin = new Padding(3, 2, 3, 2);
            textChuaXuLy.Name = "textChuaXuLy";
            textChuaXuLy.ReadOnly = true;
            textChuaXuLy.Size = new Size(110, 23);
            textChuaXuLy.TabIndex = 4;
            textChuaXuLy.TextAlign = HorizontalAlignment.Center;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(55, 76);
            label12.Name = "label12";
            label12.Size = new Size(122, 21);
            label12.TabIndex = 5;
            label12.Text = "Tổng tiền phạt";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(380, 311);
            label13.Name = "label13";
            label13.Size = new Size(179, 25);
            label13.TabIndex = 8;
            label13.Text = "Danh Sách Vi Phạm";
            // 
            // tableThongKeViPham
            // 
            tableThongKeViPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableThongKeViPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableThongKeViPham.Location = new Point(58, 337);
            tableThongKeViPham.Margin = new Padding(3, 2, 3, 2);
            tableThongKeViPham.Name = "tableThongKeViPham";
            tableThongKeViPham.RowHeadersWidth = 51;
            tableThongKeViPham.Size = new Size(816, 202);
            tableThongKeViPham.TabIndex = 7;
            // 
            // panelCharThongKeViPham
            // 
            panelCharThongKeViPham.Location = new Point(16, 25);
            panelCharThongKeViPham.Margin = new Padding(3, 2, 3, 2);
            panelCharThongKeViPham.Name = "panelCharThongKeViPham";
            panelCharThongKeViPham.Size = new Size(614, 268);
            panelCharThongKeViPham.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 2);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(937, 626);
            tabControl1.TabIndex = 0;
            // 
            // UC_ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UC_ThongKe";
            Size = new Size(942, 630);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeThietBi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableThongKeViPham).EndInit();
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
