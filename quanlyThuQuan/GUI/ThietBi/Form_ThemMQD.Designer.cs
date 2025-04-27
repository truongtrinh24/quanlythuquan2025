namespace quanlyThuQuan.GUI.ThietBi
{
    partial class Form_ThemMQD
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
            txtInputMQD = new TextBox();
            txtInputTenMQD = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLuuMQD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 61);
            label1.Name = "label1";
            label1.Size = new Size(278, 32);
            label1.TabIndex = 0;
            label1.Text = "MÃ QUI ĐỊNH THIẾT BỊ";
            // 
            // txtInputMQD
            // 
            txtInputMQD.Location = new Point(262, 171);
            txtInputMQD.Name = "txtInputMQD";
            txtInputMQD.Size = new Size(341, 23);
            txtInputMQD.TabIndex = 1;
            // 
            // txtInputTenMQD
            // 
            txtInputTenMQD.Location = new Point(262, 281);
            txtInputTenMQD.Name = "txtInputTenMQD";
            txtInputTenMQD.Size = new Size(341, 23);
            txtInputTenMQD.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(157, 174);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "MÃ QUI ĐỊNH:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(154, 284);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 4;
            label3.Text = "TÊN QUI ĐỊNH:";
            // 
            // btnLuuMQD
            // 
            btnLuuMQD.BackColor = SystemColors.ActiveCaption;
            btnLuuMQD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuuMQD.Location = new Point(374, 417);
            btnLuuMQD.Name = "btnLuuMQD";
            btnLuuMQD.Size = new Size(103, 41);
            btnLuuMQD.TabIndex = 5;
            btnLuuMQD.Text = "THÊM MQĐ";
            btnLuuMQD.UseVisualStyleBackColor = false;
            btnLuuMQD.Click += btnLuuMQD_Click;
            // 
            // Form_ThemMQD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 599);
            Controls.Add(btnLuuMQD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtInputTenMQD);
            Controls.Add(txtInputMQD);
            Controls.Add(label1);
            Name = "Form_ThemMQD";
            Text = "Form_ThemMQD";
            Load += Form_ThemMQD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInputMQD;
        private TextBox txtInputTenMQD;
        private Label label2;
        private Label label3;
        private Button btnLuuMQD;
    }
}