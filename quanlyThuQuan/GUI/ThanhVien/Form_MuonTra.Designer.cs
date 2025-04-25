namespace quanlyThuQuan.GUI.ThanhVien
{
    partial class Form_MuonTra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelInfo = new Panel();
            label4 = new Label();
            dtpTraTB = new DateTimePicker();
            btnMuonTB = new Button();
            label3 = new Label();
            txtMaTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtMSSV = new TextBox();
            tabMuonTraTB = new TabControl();
            tabMuonTB = new TabPage();
            panelMenu = new Panel();
            txtTimeMuon = new TextBox();
            txtThietBi = new TextBox();
            txtThanhVien = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabTraTB = new TabPage();
            panelThongTin = new Panel();
            label18 = new Label();
            txtStatus = new TextBox();
            txtActualTime = new TextBox();
            txtTimeEnd = new TextBox();
            txtTenTV = new TextBox();
            txtTenTB = new TextBox();
            txtMaMuon = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            panelNhapTT = new Panel();
            btnTraTB = new Button();
            txtNhapTB = new TextBox();
            txtNhapMSSV = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panelInfo.SuspendLayout();
            tabMuonTraTB.SuspendLayout();
            tabMuonTB.SuspendLayout();
            panelMenu.SuspendLayout();
            tabTraTB.SuspendLayout();
            panelThongTin.SuspendLayout();
            panelNhapTT.SuspendLayout();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.RosyBrown;
            panelInfo.Controls.Add(label4);
            panelInfo.Controls.Add(dtpTraTB);
            panelInfo.Controls.Add(btnMuonTB);
            panelInfo.Controls.Add(label3);
            panelInfo.Controls.Add(txtMaTB);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(label1);
            panelInfo.Controls.Add(txtMSSV);
            panelInfo.Location = new Point(3, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(528, 596);
            panelInfo.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 322);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 7;
            label4.Text = "THỜI GIAN TRẢ:";
            // 
            // dtpTraTB
            // 
            dtpTraTB.Location = new Point(150, 316);
            dtpTraTB.Name = "dtpTraTB";
            dtpTraTB.Size = new Size(312, 23);
            dtpTraTB.TabIndex = 6;
            // 
            // btnMuonTB
            // 
            btnMuonTB.BackColor = Color.LightGreen;
            btnMuonTB.Location = new Point(198, 420);
            btnMuonTB.Name = "btnMuonTB";
            btnMuonTB.Size = new Size(105, 53);
            btnMuonTB.TabIndex = 5;
            btnMuonTB.Text = "MƯỢN THIẾT BỊ";
            btnMuonTB.UseVisualStyleBackColor = false;
            btnMuonTB.Click += btnMuonTB_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 52);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 4;
            label3.Text = "MƯỢN THIẾT BỊ";
            // 
            // txtMaTB
            // 
            txtMaTB.Location = new Point(147, 237);
            txtMaTB.Name = "txtMaTB";
            txtMaTB.Size = new Size(315, 23);
            txtMaTB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 240);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "MÃ THIẾT BỊ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 152);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "NHẬP MSSV:";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(147, 149);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(315, 23);
            txtMSSV.TabIndex = 0;
            // 
            // tabMuonTraTB
            // 
            tabMuonTraTB.Controls.Add(tabMuonTB);
            tabMuonTraTB.Controls.Add(tabTraTB);
            tabMuonTraTB.Location = new Point(1, -1);
            tabMuonTraTB.Name = "tabMuonTraTB";
            tabMuonTraTB.SelectedIndex = 0;
            tabMuonTraTB.Size = new Size(1152, 620);
            tabMuonTraTB.TabIndex = 2;
            // 
            // tabMuonTB
            // 
            tabMuonTB.Controls.Add(panelMenu);
            tabMuonTB.Controls.Add(panelInfo);
            tabMuonTB.Location = new Point(4, 24);
            tabMuonTB.Name = "tabMuonTB";
            tabMuonTB.Padding = new Padding(3);
            tabMuonTB.Size = new Size(1144, 592);
            tabMuonTB.TabIndex = 0;
            tabMuonTB.Text = "Mượn Thiết Bị";
            tabMuonTB.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.PeachPuff;
            panelMenu.Controls.Add(txtTimeMuon);
            panelMenu.Controls.Add(txtThietBi);
            panelMenu.Controls.Add(txtThanhVien);
            panelMenu.Controls.Add(label8);
            panelMenu.Controls.Add(label7);
            panelMenu.Controls.Add(label6);
            panelMenu.Controls.Add(label5);
            panelMenu.Location = new Point(534, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(610, 592);
            panelMenu.TabIndex = 1;
            // 
            // txtTimeMuon
            // 
            txtTimeMuon.Location = new Point(233, 319);
            txtTimeMuon.Name = "txtTimeMuon";
            txtTimeMuon.Size = new Size(305, 23);
            txtTimeMuon.TabIndex = 6;
            // 
            // txtThietBi
            // 
            txtThietBi.Location = new Point(233, 237);
            txtThietBi.Name = "txtThietBi";
            txtThietBi.Size = new Size(305, 23);
            txtThietBi.TabIndex = 5;
            // 
            // txtThanhVien
            // 
            txtThanhVien.Location = new Point(233, 149);
            txtThanhVien.Name = "txtThanhVien";
            txtThanhVien.Size = new Size(305, 23);
            txtThanhVien.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(89, 322);
            label8.Name = "label8";
            label8.Size = new Size(113, 15);
            label8.TabIndex = 3;
            label8.Text = "THỜI GIAN MƯỢN:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(144, 240);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 2;
            label7.Text = "THIẾT BỊ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 154);
            label6.Name = "label6";
            label6.Size = new Size(87, 13);
            label6.TabIndex = 1;
            label6.Text = "THÀNH VIÊN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(195, 47);
            label5.Name = "label5";
            label5.Size = new Size(296, 30);
            label5.TabIndex = 0;
            label5.Text = "THÔNG TIN MƯỢN THIẾT BỊ";
            // 
            // tabTraTB
            // 
            tabTraTB.Controls.Add(panelThongTin);
            tabTraTB.Controls.Add(panelNhapTT);
            tabTraTB.Location = new Point(4, 24);
            tabTraTB.Name = "tabTraTB";
            tabTraTB.Padding = new Padding(3);
            tabTraTB.Size = new Size(1144, 592);
            tabTraTB.TabIndex = 1;
            tabTraTB.Text = "Trả Thiết Bị";
            tabTraTB.UseVisualStyleBackColor = true;
            // 
            // panelThongTin
            // 
            panelThongTin.BackColor = Color.Silver;
            panelThongTin.Controls.Add(label18);
            panelThongTin.Controls.Add(txtStatus);
            panelThongTin.Controls.Add(txtActualTime);
            panelThongTin.Controls.Add(txtTimeEnd);
            panelThongTin.Controls.Add(txtTenTV);
            panelThongTin.Controls.Add(txtTenTB);
            panelThongTin.Controls.Add(txtMaMuon);
            panelThongTin.Controls.Add(label17);
            panelThongTin.Controls.Add(label16);
            panelThongTin.Controls.Add(label15);
            panelThongTin.Controls.Add(label14);
            panelThongTin.Controls.Add(label13);
            panelThongTin.Controls.Add(label12);
            panelThongTin.Location = new Point(572, 1);
            panelThongTin.Name = "panelThongTin";
            panelThongTin.Size = new Size(572, 592);
            panelThongTin.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(51, 528);
            label18.Name = "label18";
            label18.Size = new Size(108, 15);
            label18.TabIndex = 14;
            label18.Text = "TRẠNG THÁI TRẢ:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(193, 525);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(261, 23);
            txtStatus.TabIndex = 13;
            // 
            // txtActualTime
            // 
            txtActualTime.Location = new Point(193, 447);
            txtActualTime.Name = "txtActualTime";
            txtActualTime.Size = new Size(261, 23);
            txtActualTime.TabIndex = 12;
            // 
            // txtTimeEnd
            // 
            txtTimeEnd.Location = new Point(193, 381);
            txtTimeEnd.Name = "txtTimeEnd";
            txtTimeEnd.Size = new Size(261, 23);
            txtTimeEnd.TabIndex = 11;
            // 
            // txtTenTV
            // 
            txtTenTV.Location = new Point(193, 321);
            txtTenTV.Name = "txtTenTV";
            txtTenTV.Size = new Size(261, 23);
            txtTenTV.TabIndex = 10;
            // 
            // txtTenTB
            // 
            txtTenTB.Location = new Point(193, 248);
            txtTenTB.Name = "txtTenTB";
            txtTenTB.Size = new Size(261, 23);
            txtTenTB.TabIndex = 9;
            // 
            // txtMaMuon
            // 
            txtMaMuon.Location = new Point(193, 177);
            txtMaMuon.Name = "txtMaMuon";
            txtMaMuon.Size = new Size(261, 23);
            txtMaMuon.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(61, 450);
            label17.Name = "label17";
            label17.Size = new Size(98, 15);
            label17.TabIndex = 7;
            label17.Text = "THỜI GIAN TRẢ:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(46, 384);
            label16.Name = "label16";
            label16.Size = new Size(113, 15);
            label16.TabIndex = 6;
            label16.Text = "HẠN TRẢ DỰ KIẾN:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(77, 324);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 5;
            label15.Text = "THÀNH VIÊN:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(101, 251);
            label14.Name = "label14";
            label14.Size = new Size(58, 15);
            label14.TabIndex = 4;
            label14.Text = "THIẾT BỊ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(172, 51);
            label13.Name = "label13";
            label13.Size = new Size(268, 30);
            label13.TabIndex = 3;
            label13.Text = "THÔNG TIN TRẢ THIẾT BỊ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(89, 180);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 2;
            label12.Text = "MÃ MƯỢN:";
            // 
            // panelNhapTT
            // 
            panelNhapTT.BackColor = Color.MistyRose;
            panelNhapTT.Controls.Add(btnTraTB);
            panelNhapTT.Controls.Add(txtNhapTB);
            panelNhapTT.Controls.Add(txtNhapMSSV);
            panelNhapTT.Controls.Add(label11);
            panelNhapTT.Controls.Add(label10);
            panelNhapTT.Controls.Add(label9);
            panelNhapTT.Location = new Point(1, 1);
            panelNhapTT.Name = "panelNhapTT";
            panelNhapTT.Size = new Size(572, 592);
            panelNhapTT.TabIndex = 0;
            // 
            // btnTraTB
            // 
            btnTraTB.BackColor = Color.IndianRed;
            btnTraTB.Location = new Point(203, 384);
            btnTraTB.Name = "btnTraTB";
            btnTraTB.Size = new Size(112, 47);
            btnTraTB.TabIndex = 5;
            btnTraTB.Text = "TRẢ THIẾT BỊ";
            btnTraTB.UseVisualStyleBackColor = false;
            btnTraTB.Click += btnTraTB_Click;
            // 
            // txtNhapTB
            // 
            txtNhapTB.Location = new Point(157, 248);
            txtNhapTB.Name = "txtNhapTB";
            txtNhapTB.Size = new Size(261, 23);
            txtNhapTB.TabIndex = 4;
            // 
            // txtNhapMSSV
            // 
            txtNhapMSSV.Location = new Point(157, 177);
            txtNhapMSSV.Name = "txtNhapMSSV";
            txtNhapMSSV.Size = new Size(261, 23);
            txtNhapMSSV.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(16, 251);
            label11.Name = "label11";
            label11.Size = new Size(116, 15);
            label11.TabIndex = 2;
            label11.Text = "NHẬP MÃ THIẾT BỊ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(53, 180);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 1;
            label10.Text = "NHẬP MSSV:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(95, 51);
            label9.Name = "label9";
            label9.Size = new Size(335, 30);
            label9.TabIndex = 0;
            label9.Text = "NHẬP THÔNG TIN TRẢ THIẾT BỊ";
            // 
            // Form_MuonTra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 617);
            Controls.Add(tabMuonTraTB);
            Name = "Form_MuonTra";
            Text = "Form_MuonTra";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            tabMuonTraTB.ResumeLayout(false);
            tabMuonTB.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            tabTraTB.ResumeLayout(false);
            panelThongTin.ResumeLayout(false);
            panelThongTin.PerformLayout();
            panelNhapTT.ResumeLayout(false);
            panelNhapTT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private TextBox txtMSSV;
        private Label label1;
        private TextBox txtMaTB;
        private Label label2;
        private Label label3;
        private Button btnMuonTB;
        private TabControl tabMuonTraTB;
        private TabPage tabMuonTB;
        private TabPage tabTraTB;
        private DateTimePicker dtpTraTB;
        private Label label4;
        private Panel panelMenu;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTimeMuon;
        private TextBox txtThietBi;
        private TextBox txtThanhVien;
        private Panel panelNhapTT;
        private Panel panelThongTin;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtNhapTB;
        private TextBox txtNhapMSSV;
        private Button btnTraTB;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtActualTime;
        private TextBox txtTimeEnd;
        private TextBox txtTenTV;
        private TextBox txtTenTB;
        private TextBox txtMaMuon;
        private Label label18;
        private TextBox txtStatus;
    }
}