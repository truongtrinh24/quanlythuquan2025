namespace quanlyThuQuan.GUI.ThanhVien
{
    partial class Form_ThemThanhVien
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtFullName = new TextBox();
            txtMSSV = new TextBox();
            txtPhone = new TextBox();
            dtpBirthday = new DateTimePicker();
            cmbGender = new ComboBox();
            txtBranch = new TextBox();
            txtClass = new TextBox();
            txtScience = new TextBox();
            btnAddTV = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 47);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 0;
            label1.Text = "FORM THÊM THÀNH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 132);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "HỌ VÀ TÊN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 186);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "MSSV:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 233);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "SĐT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 278);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "NGÀY SINH:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 324);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "GIỚI TÍNH:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(154, 379);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 6;
            label7.Text = "NGÀNH:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(175, 430);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 7;
            label8.Text = "LỚP:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(164, 477);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 8;
            label9.Text = "KHOA:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(249, 129);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(369, 23);
            txtFullName.TabIndex = 9;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(249, 183);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(369, 23);
            txtMSSV.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(249, 230);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(369, 23);
            txtPhone.TabIndex = 11;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(249, 272);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(216, 23);
            dtpBirthday.TabIndex = 12;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(249, 321);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(369, 23);
            cmbGender.TabIndex = 13;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(249, 376);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(369, 23);
            txtBranch.TabIndex = 14;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(249, 427);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(369, 23);
            txtClass.TabIndex = 15;
            // 
            // txtScience
            // 
            txtScience.Location = new Point(249, 474);
            txtScience.Name = "txtScience";
            txtScience.Size = new Size(369, 23);
            txtScience.TabIndex = 16;
            // 
            // btnAddTV
            // 
            btnAddTV.BackColor = Color.LimeGreen;
            btnAddTV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTV.Location = new Point(384, 540);
            btnAddTV.Name = "btnAddTV";
            btnAddTV.Size = new Size(108, 39);
            btnAddTV.TabIndex = 17;
            btnAddTV.Text = "THÊM";
            btnAddTV.UseVisualStyleBackColor = false;
            btnAddTV.Click += btnAddTV_Click;
            // 
            // Form_ThemThanhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnAddTV);
            Controls.Add(txtScience);
            Controls.Add(txtClass);
            Controls.Add(txtBranch);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthday);
            Controls.Add(txtPhone);
            Controls.Add(txtMSSV);
            Controls.Add(txtFullName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_ThemThanhVien";
            Text = "Form_ThemThanhVien";
            Load += Form_ThemThanhVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtFullName;
        private TextBox txtMSSV;
        private TextBox txtPhone;
        private DateTimePicker dtpBirthday;
        private ComboBox cmbGender;
        private TextBox txtBranch;
        private TextBox txtClass;
        private TextBox txtScience;
        private Button btnAddTV;
    }
}