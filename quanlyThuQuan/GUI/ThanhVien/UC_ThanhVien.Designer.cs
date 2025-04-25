
namespace quanlyThuQuan.GUI.ThanhVien
{
    partial class UC_ThanhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            txtSearchTV = new TextBox();
            btnSearchTV = new Button();
            dgvThanhVien = new DataGridView();
            btnAddTV = new Button();
            btnEditTV = new Button();
            btnDeleteTV = new Button();
            btnImportExcel = new Button();
            txtNamKichHoat = new TextBox();
            btnXoaTheoNam = new Button();
            label2 = new Label();
            btnReLoad = new Button();
            btnCheckIn = new Button();
            btnBorrow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThanhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 46);
            label1.Name = "label1";
            label1.Size = new Size(242, 30);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THÀNH VIÊN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(208, 152);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 1;
            label3.Text = "TÌM KIẾM : ";
            // 
            // txtSearchTV
            // 
            txtSearchTV.Location = new Point(297, 149);
            txtSearchTV.Name = "txtSearchTV";
            txtSearchTV.Size = new Size(276, 23);
            txtSearchTV.TabIndex = 2;
            txtSearchTV.KeyDown += txtSearchTV_KeyDown;
            // 
            // btnSearchTV
            // 
            btnSearchTV.Location = new Point(601, 141);
            btnSearchTV.Name = "btnSearchTV";
            btnSearchTV.Size = new Size(75, 41);
            btnSearchTV.TabIndex = 3;
            btnSearchTV.Text = "TÌM KIẾM";
            btnSearchTV.UseVisualStyleBackColor = true;
            btnSearchTV.Click += btnSearchTV_Click;
            // 
            // dgvThanhVien
            // 
            dgvThanhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhVien.Location = new Point(0, 376);
            dgvThanhVien.Name = "dgvThanhVien";
            dgvThanhVien.ReadOnly = true;
            dgvThanhVien.RowHeadersVisible = false;
            dgvThanhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThanhVien.Size = new Size(929, 308);
            dgvThanhVien.TabIndex = 4;
            // 
            // btnAddTV
            // 
            btnAddTV.BackColor = Color.MediumSpringGreen;
            btnAddTV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTV.Image = Properties.Resources._4115237_add_plus_icon;
            btnAddTV.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddTV.Location = new Point(38, 264);
            btnAddTV.Name = "btnAddTV";
            btnAddTV.Size = new Size(122, 46);
            btnAddTV.TabIndex = 5;
            btnAddTV.Text = "Thêm Thành Viên";
            btnAddTV.TextAlign = ContentAlignment.MiddleRight;
            btnAddTV.UseVisualStyleBackColor = false;
            btnAddTV.Click += btnAddTV_Click;
            // 
            // btnEditTV
            // 
            btnEditTV.BackColor = Color.Gold;
            btnEditTV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditTV.Image = Properties.Resources._8666681_edit_icon;
            btnEditTV.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditTV.Location = new Point(297, 264);
            btnEditTV.Name = "btnEditTV";
            btnEditTV.Size = new Size(115, 46);
            btnEditTV.TabIndex = 6;
            btnEditTV.Text = "Sửa Thành Viên";
            btnEditTV.TextAlign = ContentAlignment.MiddleRight;
            btnEditTV.UseVisualStyleBackColor = false;
            btnEditTV.Click += btnEditTV_Click;
            // 
            // btnDeleteTV
            // 
            btnDeleteTV.BackColor = Color.Red;
            btnDeleteTV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTV.Image = Properties.Resources._185090_delete_garbage_icon;
            btnDeleteTV.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteTV.Location = new Point(506, 264);
            btnDeleteTV.Name = "btnDeleteTV";
            btnDeleteTV.Size = new Size(115, 46);
            btnDeleteTV.TabIndex = 7;
            btnDeleteTV.Text = "Xóa Thành Viên";
            btnDeleteTV.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteTV.UseVisualStyleBackColor = false;
            btnDeleteTV.Click += btnDeleteTV_Click;
            // 
            // btnImportExcel
            // 
            btnImportExcel.BackColor = Color.MediumSeaGreen;
            btnImportExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImportExcel.Image = Properties.Resources._7422413_exel_spreadsheet_sheets_table_icon;
            btnImportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnImportExcel.Location = new Point(771, 264);
            btnImportExcel.Name = "btnImportExcel";
            btnImportExcel.Size = new Size(98, 46);
            btnImportExcel.TabIndex = 8;
            btnImportExcel.Text = "Nhập Excel";
            btnImportExcel.TextAlign = ContentAlignment.MiddleRight;
            btnImportExcel.UseVisualStyleBackColor = false;
            btnImportExcel.Click += btnImportExcel_Click;
            // 
            // txtNamKichHoat
            // 
            txtNamKichHoat.Location = new Point(386, 333);
            txtNamKichHoat.Name = "txtNamKichHoat";
            txtNamKichHoat.Size = new Size(111, 23);
            txtNamKichHoat.TabIndex = 9;
            // 
            // btnXoaTheoNam
            // 
            btnXoaTheoNam.BackColor = Color.IndianRed;
            btnXoaTheoNam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoaTheoNam.Location = new Point(520, 324);
            btnXoaTheoNam.Name = "btnXoaTheoNam";
            btnXoaTheoNam.Size = new Size(75, 39);
            btnXoaTheoNam.TabIndex = 10;
            btnXoaTheoNam.Text = "XÓA";
            btnXoaTheoNam.UseVisualStyleBackColor = false;
            btnXoaTheoNam.Click += btnXoaTheoNam_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 336);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 11;
            label2.Text = "nhập năm kích hoạt :";
            // 
            // btnReLoad
            // 
            btnReLoad.BackColor = SystemColors.ActiveCaption;
            btnReLoad.Image = Properties.Resources._134221_refresh_reload_repeat_update_arrow_icon;
            btnReLoad.Location = new Point(771, 44);
            btnReLoad.Name = "btnReLoad";
            btnReLoad.Size = new Size(75, 43);
            btnReLoad.TabIndex = 12;
            btnReLoad.UseVisualStyleBackColor = false;
            btnReLoad.Click += btnReLoad_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = SystemColors.ActiveCaption;
            btnCheckIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckIn.Image = Properties.Resources._928438_checkin_gps_location_map_navigation_icon;
            btnCheckIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckIn.Location = new Point(148, 192);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(197, 50);
            btnCheckIn.TabIndex = 13;
            btnCheckIn.Text = "VÀO KHU VỰC HỌC TẬP";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = SystemColors.ActiveCaption;
            btnBorrow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.Image = Properties.Resources._928438_checkin_gps_location_map_navigation_icon;
            btnBorrow.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrow.Location = new Point(539, 192);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(197, 50);
            btnBorrow.TabIndex = 14;
            btnBorrow.Text = "QUẢN LÝ MƯỢN/TRẢ";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // UC_ThanhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBorrow);
            Controls.Add(btnCheckIn);
            Controls.Add(btnReLoad);
            Controls.Add(label2);
            Controls.Add(btnXoaTheoNam);
            Controls.Add(txtNamKichHoat);
            Controls.Add(btnImportExcel);
            Controls.Add(btnDeleteTV);
            Controls.Add(btnEditTV);
            Controls.Add(btnAddTV);
            Controls.Add(dgvThanhVien);
            Controls.Add(btnSearchTV);
            Controls.Add(txtSearchTV);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UC_ThanhVien";
            Size = new Size(929, 684);
            Load += UC_ThanhVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThanhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSearchTV;
        private Button btnSearchTV;
        private DataGridView dgvThanhVien;
        private Button btnAddTV;
        private Button btnEditTV;
        private Button btnDeleteTV;
        private Button btnImportExcel;
        private TextBox txtNamKichHoat;
        private Button btnXoaTheoNam;
        private Button btnReLoad;
        private Button btnCheckIn;
        private Button btnBorrow;
    }
}
