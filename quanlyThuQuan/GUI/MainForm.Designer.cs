namespace quanlyThuQuan.GUI
{
    partial class MainForm
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
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            btnDangXuat = new Button();
            btnThongKe = new Button();
            btnViPham = new Button();
            btnThietBi = new Button();
            btnThanhVien = new Button();
            pnlMain = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Bisque;
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnViPham);
            panelMenu.Controls.Add(btnThietBi);
            panelMenu.Controls.Add(btnThanhVien);
            panelMenu.Location = new Point(0, -1);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 685);
            panelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Red;
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(0, 620);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(219, 65);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += button5_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(0, 434);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(219, 65);
            btnThongKe.TabIndex = 3;
            btnThongKe.Text = "THỐNG KÊ";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnViPham
            // 
            btnViPham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViPham.Location = new Point(0, 339);
            btnViPham.Name = "btnViPham";
            btnViPham.Size = new Size(219, 65);
            btnViPham.TabIndex = 2;
            btnViPham.Text = "QUẢN LÝ VI PHẠM";
            btnViPham.UseVisualStyleBackColor = true;
            btnViPham.Click += btnViPham_Click;
            // 
            // btnThietBi
            // 
            btnThietBi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThietBi.Location = new Point(0, 248);
            btnThietBi.Name = "btnThietBi";
            btnThietBi.Size = new Size(219, 65);
            btnThietBi.TabIndex = 1;
            btnThietBi.Text = "QUẢN LÝ THIẾT BỊ";
            btnThietBi.UseVisualStyleBackColor = true;
            btnThietBi.Click += btnThietBi_Click;
            // 
            // btnThanhVien
            // 
            btnThanhVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhVien.Location = new Point(0, 154);
            btnThanhVien.Name = "btnThanhVien";
            btnThanhVien.Size = new Size(219, 65);
            btnThanhVien.TabIndex = 0;
            btnThanhVien.Text = "QUẢN LÝ THÀNH VIÊN";
            btnThanhVien.UseVisualStyleBackColor = true;
            btnThanhVien.Click += btnThanhVien_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(pictureBox2);
            pnlMain.Location = new Point(218, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(929, 684);
            pnlMain.TabIndex = 1;
            pnlMain.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(165, 88);
            label1.Name = "label1";
            label1.Size = new Size(571, 30);
            label1.TabIndex = 1;
            label1.Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG QUẢN LÝ THƯ QUÁN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_removebg_preview;
            pictureBox2.Location = new Point(193, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(524, 331);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 683);
            Controls.Add(pnlMain);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private Button btnDangXuat;
        private Button btnThongKe;
        private Button btnViPham;
        private Button btnThietBi;
        private Button btnThanhVien;
        private Label label1;
        private PictureBox pictureBox2;
    }
}