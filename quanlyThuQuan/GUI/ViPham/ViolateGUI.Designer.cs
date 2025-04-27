namespace quanlyThuQuan.GUI.ViPham
{
    partial class ViolateGUI
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
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            amount = new TextBox();
            add_button = new Button();
            close = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 65);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Thêm Vi Phạm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 164);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Hình thức xử lý";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 224);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Số tiền";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(308, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(273, 28);
            comboBox1.TabIndex = 4;
            // 
            // amount
            // 
            amount.Location = new Point(305, 227);
            amount.Name = "amount";
            amount.Size = new Size(276, 27);
            amount.TabIndex = 5;
            // 
            // add_button
            // 
            add_button.Location = new Point(308, 292);
            add_button.Name = "add_button";
            add_button.Size = new Size(94, 29);
            add_button.TabIndex = 7;
            add_button.Text = "Thêm";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // close
            // 
            close.Location = new Point(587, 292);
            close.Name = "close";
            close.Size = new Size(94, 29);
            close.TabIndex = 8;
            close.Text = "Đóng";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // button1
            // 
            button1.Location = new Point(457, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Sửa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViolateGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(close);
            Controls.Add(add_button);
            Controls.Add(amount);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ViolateGUI";
            Text = "ViolateGUI";
            Load += ViolateGUI_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox amount;
        private Button add_button;
        private Button close;
        private Button button1;
    }
}