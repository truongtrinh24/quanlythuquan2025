namespace quanlyThuQuan.GUI.ThietBi
{
    partial class UC_ThietBi
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
            dgvThietBi = new DataGridView();
            btnAddTB = new Button();
            btnEditTB = new Button();
            btnDeleteTB = new Button();
            btnNhapTBExcel = new Button();
            txtSearchTB = new TextBox();
            label2 = new Label();
            btnSearchTB = new Button();
            btnReLoad = new Button();
            cbDltMQĐ = new ComboBox();
            label3 = new Label();
            btnDltMQĐ = new Button();
            btnAddMQĐ = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(338, 39);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THIẾT BỊ";
            // 
            // dgvThietBi
            // 
            dgvThietBi.AllowUserToAddRows = false;
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Dock = DockStyle.Bottom;
            dgvThietBi.Location = new Point(0, 387);
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.RowHeadersVisible = false;
            dgvThietBi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThietBi.Size = new Size(929, 297);
            dgvThietBi.TabIndex = 2;
            // 
            // btnAddTB
            // 
            btnAddTB.BackColor = Color.SpringGreen;
            btnAddTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTB.Image = Properties.Resources._4115237_add_plus_icon;
            btnAddTB.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddTB.Location = new Point(30, 201);
            btnAddTB.Name = "btnAddTB";
            btnAddTB.Size = new Size(130, 42);
            btnAddTB.TabIndex = 3;
            btnAddTB.Text = "THÊM THIẾT BỊ";
            btnAddTB.UseVisualStyleBackColor = false;
            btnAddTB.Click += btnAddTB_Click;
            // 
            // btnEditTB
            // 
            btnEditTB.BackColor = Color.Gold;
            btnEditTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditTB.Image = Properties.Resources._8666681_edit_icon;
            btnEditTB.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditTB.Location = new Point(204, 201);
            btnEditTB.Name = "btnEditTB";
            btnEditTB.Size = new Size(147, 42);
            btnEditTB.TabIndex = 4;
            btnEditTB.Text = "SỬA THÀNH VIÊN";
            btnEditTB.UseVisualStyleBackColor = false;
            btnEditTB.Click += btnEditTB_Click;
            // 
            // btnDeleteTB
            // 
            btnDeleteTB.BackColor = Color.Red;
            btnDeleteTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTB.Image = Properties.Resources._185090_delete_garbage_icon;
            btnDeleteTB.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteTB.Location = new Point(407, 201);
            btnDeleteTB.Name = "btnDeleteTB";
            btnDeleteTB.Size = new Size(130, 42);
            btnDeleteTB.TabIndex = 5;
            btnDeleteTB.Text = "XÓA THIẾT BỊ";
            btnDeleteTB.UseVisualStyleBackColor = false;
            btnDeleteTB.Click += btnDeleteTB_Click;
            // 
            // btnNhapTBExcel
            // 
            btnNhapTBExcel.BackColor = Color.MediumSeaGreen;
            btnNhapTBExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhapTBExcel.Image = Properties.Resources._7422413_exel_spreadsheet_sheets_table_icon;
            btnNhapTBExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapTBExcel.Location = new Point(597, 201);
            btnNhapTBExcel.Name = "btnNhapTBExcel";
            btnNhapTBExcel.Size = new Size(130, 42);
            btnNhapTBExcel.TabIndex = 6;
            btnNhapTBExcel.Text = "NHẬP EXCEL";
            btnNhapTBExcel.UseVisualStyleBackColor = false;
            btnNhapTBExcel.Click += btnNhapTBExcel_Click_1;
            // 
            // txtSearchTB
            // 
            txtSearchTB.Location = new Point(324, 126);
            txtSearchTB.Name = "txtSearchTB";
            txtSearchTB.Size = new Size(274, 23);
            txtSearchTB.TabIndex = 7;
            txtSearchTB.KeyDown += txtSearchTB_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 129);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "TÌM KIẾM:";
            // 
            // btnSearchTB
            // 
            btnSearchTB.BackColor = SystemColors.ActiveCaption;
            btnSearchTB.Image = Properties.Resources.icons8_search_24;
            btnSearchTB.Location = new Point(622, 114);
            btnSearchTB.Name = "btnSearchTB";
            btnSearchTB.Size = new Size(75, 45);
            btnSearchTB.TabIndex = 9;
            btnSearchTB.UseVisualStyleBackColor = false;
            btnSearchTB.Click += btnSearchTB_Click;
            // 
            // btnReLoad
            // 
            btnReLoad.BackColor = SystemColors.ActiveCaption;
            btnReLoad.Image = Properties.Resources._134221_refresh_reload_repeat_update_arrow_icon;
            btnReLoad.Location = new Point(738, 39);
            btnReLoad.Name = "btnReLoad";
            btnReLoad.Size = new Size(58, 41);
            btnReLoad.TabIndex = 10;
            btnReLoad.UseVisualStyleBackColor = false;
            btnReLoad.Click += btnReLoad_Click;
            // 
            // cbDltMQĐ
            // 
            cbDltMQĐ.FormattingEnabled = true;
            cbDltMQĐ.Location = new Point(352, 321);
            cbDltMQĐ.Name = "cbDltMQĐ";
            cbDltMQĐ.Size = new Size(246, 23);
            cbDltMQĐ.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 324);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 12;
            label3.Text = "XÓA THEO MÃ QUI ĐỊNH";
            // 
            // btnDltMQĐ
            // 
            btnDltMQĐ.BackColor = SystemColors.ActiveCaption;
            btnDltMQĐ.Location = new Point(645, 312);
            btnDltMQĐ.Name = "btnDltMQĐ";
            btnDltMQĐ.Size = new Size(72, 38);
            btnDltMQĐ.TabIndex = 13;
            btnDltMQĐ.Text = "XÓA";
            btnDltMQĐ.UseVisualStyleBackColor = false;
            btnDltMQĐ.Click += btnDltMQĐ_Click;
            // 
            // btnAddMQĐ
            // 
            btnAddMQĐ.BackColor = Color.SpringGreen;
            btnAddMQĐ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMQĐ.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMQĐ.Location = new Point(781, 201);
            btnAddMQĐ.Name = "btnAddMQĐ";
            btnAddMQĐ.Size = new Size(130, 42);
            btnAddMQĐ.TabIndex = 14;
            btnAddMQĐ.Text = "THÊM QĐ THIẾT BỊ";
            btnAddMQĐ.UseVisualStyleBackColor = false;
            btnAddMQĐ.Click += btnAddMQĐ_Click;
            // 
            // UC_ThietBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddMQĐ);
            Controls.Add(btnDltMQĐ);
            Controls.Add(label3);
            Controls.Add(cbDltMQĐ);
            Controls.Add(btnReLoad);
            Controls.Add(btnSearchTB);
            Controls.Add(label2);
            Controls.Add(txtSearchTB);
            Controls.Add(btnNhapTBExcel);
            Controls.Add(btnDeleteTB);
            Controls.Add(btnEditTB);
            Controls.Add(btnAddTB);
            Controls.Add(dgvThietBi);
            Controls.Add(label1);
            Name = "UC_ThietBi";
            Size = new Size(929, 684);
            Load += UC_ThietBi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvThietBi;
        private Button btnAddTB;
        private Button btnEditTB;
        private Button btnDeleteTB;
        private Button btnNhapTBExcel;
        private TextBox txtSearchTB;
        private Label label2;
        private Button btnSearchTB;
        private Button btnReLoad;
        private ComboBox cbDltMQĐ;
        private Label label3;
        private Button btnDltMQĐ;
        private Button btnAddMQĐ;
    }
}
