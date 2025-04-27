namespace quanlyThuQuan.GUI.ThietBi
{
    partial class Form_SuaThietBi
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
            txtNameTb = new TextBox();
            txtDesTB = new TextBox();
            cbMQDTB = new ComboBox();
            cbStatusTB = new ComboBox();
            btnLuuTB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 55);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN SỬA THIẾT BỊ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 153);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "TÊN THIẾT BỊ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 223);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 2;
            label3.Text = "MÃ QUI ĐỊNH THIẾT BỊ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(95, 294);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "MÔ TẢ THIẾT BỊ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 373);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "TRẠNG THÁI:";
            // 
            // txtNameTb
            // 
            txtNameTb.Location = new Point(227, 150);
            txtNameTb.Name = "txtNameTb";
            txtNameTb.Size = new Size(358, 23);
            txtNameTb.TabIndex = 5;
            // 
            // txtDesTB
            // 
            txtDesTB.Location = new Point(227, 291);
            txtDesTB.Name = "txtDesTB";
            txtDesTB.Size = new Size(358, 23);
            txtDesTB.TabIndex = 6;
            // 
            // cbMQDTB
            // 
            cbMQDTB.FormattingEnabled = true;
            cbMQDTB.Location = new Point(227, 220);
            cbMQDTB.Name = "cbMQDTB";
            cbMQDTB.Size = new Size(358, 23);
            cbMQDTB.TabIndex = 7;
            // 
            // cbStatusTB
            // 
            cbStatusTB.FormattingEnabled = true;
            cbStatusTB.Location = new Point(227, 370);
            cbStatusTB.Name = "cbStatusTB";
            cbStatusTB.Size = new Size(358, 23);
            cbStatusTB.TabIndex = 8;
            // 
            // btnLuuTB
            // 
            btnLuuTB.BackColor = SystemColors.ActiveCaption;
            btnLuuTB.Location = new Point(379, 476);
            btnLuuTB.Name = "btnLuuTB";
            btnLuuTB.Size = new Size(109, 51);
            btnLuuTB.TabIndex = 9;
            btnLuuTB.Text = "LƯU";
            btnLuuTB.UseVisualStyleBackColor = false;
            btnLuuTB.Click += btnLuuTB_Click;
            // 
            // Form_SuaThietBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 606);
            Controls.Add(btnLuuTB);
            Controls.Add(cbStatusTB);
            Controls.Add(cbMQDTB);
            Controls.Add(txtDesTB);
            Controls.Add(txtNameTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_SuaThietBi";
            Text = "Form_SuaThietBi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNameTb;
        private TextBox txtDesTB;
        private ComboBox cbMQDTB;
        private ComboBox cbStatusTB;
        private Button btnLuuTB;
    }
}