namespace quanlyThuQuan.GUI.ViPham
{
    partial class UC_ViPham
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
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(357, 45);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THIẾT BỊ";
            // 
            // dgvThietBi
            // 
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Location = new Point(0, 388);
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.Size = new Size(954, 265);
            dgvThietBi.TabIndex = 1;
            // 
            // UC_ViPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvThietBi);
            Controls.Add(label1);
            Name = "UC_ViPham";
            Size = new Size(954, 654);
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvThietBi;
    }
}
