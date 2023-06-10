namespace UI_Winform
{
    partial class FormStorage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Btn_AddCate = new System.Windows.Forms.Button();
            this.Cbb_Type = new System.Windows.Forms.ComboBox();
            this.Cbb_Category = new System.Windows.Forms.ComboBox();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.Btn_View = new System.Windows.Forms.Button();
            this.Cbb_Sort = new System.Windows.Forms.ComboBox();
            this.Btn_Import = new System.Windows.Forms.Button();
            this.Cbb_Brand = new System.Windows.Forms.ComboBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Txb_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Btn_AddCate);
            this.MainPanel.Controls.Add(this.Cbb_Type);
            this.MainPanel.Controls.Add(this.Cbb_Category);
            this.MainPanel.Controls.Add(this.Btn_Sort);
            this.MainPanel.Controls.Add(this.Btn_View);
            this.MainPanel.Controls.Add(this.Cbb_Sort);
            this.MainPanel.Controls.Add(this.Btn_Import);
            this.MainPanel.Controls.Add(this.Cbb_Brand);
            this.MainPanel.Controls.Add(this.Btn_Delete);
            this.MainPanel.Controls.Add(this.Btn_Update);
            this.MainPanel.Controls.Add(this.Btn_Add);
            this.MainPanel.Controls.Add(this.Lb_Title);
            this.MainPanel.Controls.Add(this.Txb_Search);
            this.MainPanel.Controls.Add(this.Btn_Search);
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1599, 380);
            this.MainPanel.TabIndex = 0;
            // 
            // Btn_AddCate
            // 
            this.Btn_AddCate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddCate.Location = new System.Drawing.Point(1206, 335);
            this.Btn_AddCate.Name = "Btn_AddCate";
            this.Btn_AddCate.Size = new System.Drawing.Size(284, 31);
            this.Btn_AddCate.TabIndex = 43;
            this.Btn_AddCate.Text = "Thêm loại sản phẩm/hãng";
            this.Btn_AddCate.UseVisualStyleBackColor = true;
            this.Btn_AddCate.Click += new System.EventHandler(this.Btn_AddCate_Click);
            // 
            // Cbb_Type
            // 
            this.Cbb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Type.FormattingEnabled = true;
            this.Cbb_Type.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.Cbb_Type.Location = new System.Drawing.Point(903, 338);
            this.Cbb_Type.Name = "Cbb_Type";
            this.Cbb_Type.Size = new System.Drawing.Size(129, 28);
            this.Cbb_Type.TabIndex = 42;
            // 
            // Cbb_Category
            // 
            this.Cbb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Category.FormattingEnabled = true;
            this.Cbb_Category.Location = new System.Drawing.Point(247, 14);
            this.Cbb_Category.Name = "Cbb_Category";
            this.Cbb_Category.Size = new System.Drawing.Size(170, 33);
            this.Cbb_Category.TabIndex = 41;
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sort.Location = new System.Drawing.Point(613, 336);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(106, 31);
            this.Btn_Sort.TabIndex = 36;
            this.Btn_Sort.Text = "Sắp xếp";
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // Btn_View
            // 
            this.Btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_View.Location = new System.Drawing.Point(1061, 336);
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.Size = new System.Drawing.Size(106, 31);
            this.Btn_View.TabIndex = 40;
            this.Btn_View.Text = "Xem";
            this.Btn_View.UseVisualStyleBackColor = true;
            this.Btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // Cbb_Sort
            // 
            this.Cbb_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Sort.FormattingEnabled = true;
            this.Cbb_Sort.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Số lượng"});
            this.Cbb_Sort.Location = new System.Drawing.Point(755, 338);
            this.Cbb_Sort.Name = "Cbb_Sort";
            this.Cbb_Sort.Size = new System.Drawing.Size(121, 28);
            this.Cbb_Sort.TabIndex = 37;
            // 
            // Btn_Import
            // 
            this.Btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Import.Location = new System.Drawing.Point(461, 336);
            this.Btn_Import.Name = "Btn_Import";
            this.Btn_Import.Size = new System.Drawing.Size(106, 31);
            this.Btn_Import.TabIndex = 39;
            this.Btn_Import.Text = "Nhập hàng";
            this.Btn_Import.UseVisualStyleBackColor = true;
            this.Btn_Import.Click += new System.EventHandler(this.Btn_Import_Click);
            // 
            // Cbb_Brand
            // 
            this.Cbb_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Brand.FormattingEnabled = true;
            this.Cbb_Brand.Location = new System.Drawing.Point(446, 14);
            this.Cbb_Brand.Name = "Cbb_Brand";
            this.Cbb_Brand.Size = new System.Drawing.Size(121, 33);
            this.Cbb_Brand.TabIndex = 38;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(311, 336);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(106, 31);
            this.Btn_Delete.TabIndex = 35;
            this.Btn_Delete.Text = "Xóa";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Update.Location = new System.Drawing.Point(162, 336);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(106, 31);
            this.Btn_Update.TabIndex = 34;
            this.Btn_Update.Text = "Sửa";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Add
            // 
            this.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(17, 336);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(106, 31);
            this.Btn_Add.TabIndex = 33;
            this.Btn_Add.Text = "Thêm";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(12, 65);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(178, 20);
            this.Lb_Title.TabIndex = 32;
            this.Lb_Title.Text = "Danh sách sản phẩm: ";
            // 
            // Txb_Search
            // 
            this.Txb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Search.Location = new System.Drawing.Point(12, 15);
            this.Txb_Search.Name = "Txb_Search";
            this.Txb_Search.Size = new System.Drawing.Size(201, 30);
            this.Txb_Search.TabIndex = 31;
            // 
            // Btn_Search
            // 
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(629, 14);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(106, 33);
            this.Btn_Search.TabIndex = 30;
            this.Btn_Search.Text = "Tìm kiếm";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(16, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1571, 198);
            this.dataGridView1.TabIndex = 29;
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 380);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(1599, 253);
            this.ChildPanel.TabIndex = 1;
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1599, 633);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "FormStorage";
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.TextBox Txb_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.ComboBox Cbb_Brand;
        private System.Windows.Forms.Button Btn_Import;
        private System.Windows.Forms.Button Btn_View;
        private System.Windows.Forms.ComboBox Cbb_Category;
        private System.Windows.Forms.ComboBox Cbb_Sort;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.ComboBox Cbb_Type;
        private System.Windows.Forms.Button Btn_AddCate;
    }
}