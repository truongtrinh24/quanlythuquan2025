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
            viphamview = new DataGridView();
            update_button = new Button();
            delete_button = new Button();
            reset_button = new Button();
            txt_search = new TextBox();
            label2 = new Label();
            search_btn = new Button();
            label3 = new Label();
            label4 = new Label();
            dataViewBook = new DataGridView();
            btn_vipham = new Button();
            ((System.ComponentModel.ISupportInitialize)viphamview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataViewBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Moccasin;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 10);
            label1.Name = "label1";
            label1.Size = new Size(285, 41);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ VI PHẠM";
            label1.Click += label1_Click;
            // 
            // viphamview
            // 
            viphamview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viphamview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            viphamview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viphamview.Location = new Point(54, 570);
            viphamview.Name = "viphamview";
            viphamview.RowHeadersWidth = 51;
            viphamview.Size = new Size(1002, 211);
            viphamview.TabIndex = 1;
            viphamview.CellContentClick += dataGridView1_CellContentClick;
            // 
            // update_button
            // 
            update_button.Location = new Point(731, 843);
            update_button.Name = "update_button";
            update_button.Size = new Size(94, 29);
            update_button.TabIndex = 3;
            update_button.Text = "Sửa";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(831, 843);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(94, 29);
            delete_button.TabIndex = 4;
            delete_button.Text = "Xóa";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // reset_button
            // 
            reset_button.Location = new Point(949, 843);
            reset_button.Name = "reset_button";
            reset_button.Size = new Size(94, 29);
            reset_button.TabIndex = 5;
            reset_button.Text = "hoàn tác";
            reset_button.UseVisualStyleBackColor = true;
            reset_button.Click += reset_button_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(462, 525);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(294, 27);
            txt_search.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 528);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm theo Id:";
            // 
            // search_btn
            // 
            search_btn.Location = new Point(785, 525);
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(94, 29);
            search_btn.TabIndex = 8;
            search_btn.Text = "Tìm kiếm";
            search_btn.UseVisualStyleBackColor = true;
            search_btn.Click += search_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 528);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 9;
            label3.Text = "Danh sách phạt";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 61);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 10;
            label4.Text = "Danh sách đặt thiết bị";
            // 
            // dataViewBook
            // 
            dataViewBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewBook.Location = new Point(66, 116);
            dataViewBook.Name = "dataViewBook";
            dataViewBook.RowHeadersWidth = 51;
            dataViewBook.Size = new Size(990, 273);
            dataViewBook.TabIndex = 11;
            dataViewBook.CellClick += dataViewBook_CellClick;
            // 
            // btn_vipham
            // 
            btn_vipham.Location = new Point(875, 70);
            btn_vipham.Name = "btn_vipham";
            btn_vipham.Size = new Size(132, 29);
            btn_vipham.TabIndex = 12;
            btn_vipham.Text = "Thêm vi phạm";
            btn_vipham.UseVisualStyleBackColor = true;
            btn_vipham.Click += btn_vipham_Click;
            // 
            // UC_ViPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_vipham);
            Controls.Add(dataViewBook);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(search_btn);
            Controls.Add(label2);
            Controls.Add(txt_search);
            Controls.Add(reset_button);
            Controls.Add(delete_button);
            Controls.Add(update_button);
            Controls.Add(viphamview);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_ViPham";
            Size = new Size(1090, 872);
            ((System.ComponentModel.ISupportInitialize)viphamview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataViewBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView viphamview;
        private Button update_button;
        private Button delete_button;
        private Button reset_button;
        private TextBox txt_search;
        private Label label2;
        private Button search_btn;
        private Label label3;
        private Label label4;
        private DataGridView dataViewBook;
        private Button btn_vipham;
    }
}
