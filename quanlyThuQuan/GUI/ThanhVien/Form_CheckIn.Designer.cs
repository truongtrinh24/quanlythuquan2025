namespace quanlyThuQuan.GUI.ThanhVien
{
    partial class Form_CheckIn
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
            panelNhapMa = new Panel();
            label2 = new Label();
            txtTimeIn = new TextBox();
            label1 = new Label();
            txtInputMSSV = new TextBox();
            panelInfor = new Panel();
            pictureBox1 = new PictureBox();
            txtPhone = new TextBox();
            txtScience = new TextBox();
            txtClass = new TextBox();
            txtBranch = new TextBox();
            txtBirthday = new TextBox();
            txtGender = new TextBox();
            txtFullName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panelNhapMa.SuspendLayout();
            panelInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNhapMa
            // 
            panelNhapMa.BackColor = SystemColors.ActiveCaption;
            panelNhapMa.Controls.Add(label2);
            panelNhapMa.Controls.Add(txtTimeIn);
            panelNhapMa.Controls.Add(label1);
            panelNhapMa.Controls.Add(txtInputMSSV);
            panelNhapMa.Location = new Point(0, 0);
            panelNhapMa.Name = "panelNhapMa";
            panelNhapMa.Size = new Size(288, 650);
            panelNhapMa.TabIndex = 0;
            panelNhapMa.Paint += panelNhapMa_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 527);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "thời gian vào: ";
            // 
            // txtTimeIn
            // 
            txtTimeIn.Location = new Point(35, 554);
            txtTimeIn.Name = "txtTimeIn";
            txtTimeIn.Size = new Size(182, 23);
            txtTimeIn.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 65);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Nhập MSSV:";
            // 
            // txtInputMSSV
            // 
            txtInputMSSV.Location = new Point(113, 62);
            txtInputMSSV.Name = "txtInputMSSV";
            txtInputMSSV.Size = new Size(168, 23);
            txtInputMSSV.TabIndex = 0;
            txtInputMSSV.KeyDown += txtInputMSSV_KeyDown;
            // 
            // panelInfor
            // 
            panelInfor.BackColor = SystemColors.ActiveCaption;
            panelInfor.Controls.Add(pictureBox1);
            panelInfor.Controls.Add(txtPhone);
            panelInfor.Controls.Add(txtScience);
            panelInfor.Controls.Add(txtClass);
            panelInfor.Controls.Add(txtBranch);
            panelInfor.Controls.Add(txtBirthday);
            panelInfor.Controls.Add(txtGender);
            panelInfor.Controls.Add(txtFullName);
            panelInfor.Controls.Add(label9);
            panelInfor.Controls.Add(label8);
            panelInfor.Controls.Add(label7);
            panelInfor.Controls.Add(label6);
            panelInfor.Controls.Add(label5);
            panelInfor.Controls.Add(label4);
            panelInfor.Controls.Add(label3);
            panelInfor.Location = new Point(287, 0);
            panelInfor.Name = "panelInfor";
            panelInfor.Size = new Size(854, 653);
            panelInfor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._172628_user_male_icon;
            pictureBox1.Location = new Point(609, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(145, 392);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(365, 23);
            txtPhone.TabIndex = 12;
            // 
            // txtScience
            // 
            txtScience.Location = new Point(145, 335);
            txtScience.Name = "txtScience";
            txtScience.Size = new Size(365, 23);
            txtScience.TabIndex = 11;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(145, 286);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(365, 23);
            txtClass.TabIndex = 10;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(145, 234);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(365, 23);
            txtBranch.TabIndex = 9;
            // 
            // txtBirthday
            // 
            txtBirthday.Location = new Point(145, 176);
            txtBirthday.Name = "txtBirthday";
            txtBirthday.Size = new Size(141, 23);
            txtBirthday.TabIndex = 8;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(145, 126);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(141, 23);
            txtGender.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(145, 70);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(365, 23);
            txtFullName.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(77, 395);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 6;
            label9.Text = "SĐT:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(75, 338);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 5;
            label8.Text = "KHOA:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(71, 286);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 4;
            label7.Text = "LỚP :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 237);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 3;
            label6.Text = "NGÀNH:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 179);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 2;
            label5.Text = "NGÀY SINH:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 129);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 1;
            label4.Text = "PHÁI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 73);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "HỌ TÊN:";
            // 
            // Form_CheckIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 650);
            Controls.Add(panelInfor);
            Controls.Add(panelNhapMa);
            Name = "Form_CheckIn";
            Text = "Form_CheckIn";
            panelNhapMa.ResumeLayout(false);
            panelNhapMa.PerformLayout();
            panelInfor.ResumeLayout(false);
            panelInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNhapMa;
        private Panel panelInfor;
        private TextBox txtInputMSSV;
        private Label label1;
        private TextBox txtTimeIn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtFullName;
        private TextBox txtGender;
        private TextBox txtBirthday;
        private TextBox txtBranch;
        private TextBox txtPhone;
        private TextBox txtScience;
        private TextBox txtClass;
        private PictureBox pictureBox1;
    }
}