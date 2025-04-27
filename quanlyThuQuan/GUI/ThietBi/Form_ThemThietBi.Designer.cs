namespace quanlyThuQuan.GUI.ThietBi
{
    partial class Form_ThemThietBi
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
            txtNameTB = new TextBox();
            txtDescriptionTB = new TextBox();
            cbMQĐ = new ComboBox();
            btnAddTB = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 47);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 0;
            label1.Text = "THÊM THIẾT BỊ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 151);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "TÊN THIẾT BỊ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 213);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 2;
            label3.Text = "MÃ QUI ĐỊNH THIẾT BỊ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 276);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "MÔ TẢ THIẾT BỊ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 341);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // txtNameTB
            // 
            txtNameTB.Location = new Point(256, 148);
            txtNameTB.Name = "txtNameTB";
            txtNameTB.Size = new Size(371, 23);
            txtNameTB.TabIndex = 5;
            // 
            // txtDescriptionTB
            // 
            txtDescriptionTB.Location = new Point(256, 273);
            txtDescriptionTB.Name = "txtDescriptionTB";
            txtDescriptionTB.Size = new Size(371, 23);
            txtDescriptionTB.TabIndex = 6;
            // 
            // cbMQĐ
            // 
            cbMQĐ.FormattingEnabled = true;
            cbMQĐ.Location = new Point(256, 210);
            cbMQĐ.Name = "cbMQĐ";
            cbMQĐ.Size = new Size(371, 23);
            cbMQĐ.TabIndex = 7;
            // 
            // btnAddTB
            // 
            btnAddTB.BackColor = Color.PaleGreen;
            btnAddTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTB.Location = new Point(376, 419);
            btnAddTB.Name = "btnAddTB";
            btnAddTB.Size = new Size(97, 45);
            btnAddTB.TabIndex = 8;
            btnAddTB.Text = "THÊM";
            btnAddTB.UseVisualStyleBackColor = false;
            btnAddTB.Click += btnAddTB_Click;
            // 
            // Form_ThemThietBi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 568);
            Controls.Add(btnAddTB);
            Controls.Add(cbMQĐ);
            Controls.Add(txtDescriptionTB);
            Controls.Add(txtNameTB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_ThemThietBi";
            Text = "Form_ThemThietBi";
            Load += Form_ThemThietBi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNameTB;
        private TextBox txtDescriptionTB;
        private ComboBox cbMQĐ;
        private Button btnAddTB;
    }
}