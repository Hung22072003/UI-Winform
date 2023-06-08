namespace UI_Winform.View
{
    partial class FormDiscount
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
            this.btn_ShowALL = new System.Windows.Forms.Button();
            this.txb_MaxDiscount = new System.Windows.Forms.TextBox();
            this.txb_Quantity = new System.Windows.Forms.TextBox();
            this.txb_MinTotal = new System.Windows.Forms.TextBox();
            this.Txb_Discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_FromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.dtp_DateSearch = new System.Windows.Forms.DateTimePicker();
            this.dgv_Voucher = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voucher)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ShowALL
            // 
            this.btn_ShowALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowALL.Location = new System.Drawing.Point(799, 22);
            this.btn_ShowALL.Name = "btn_ShowALL";
            this.btn_ShowALL.Size = new System.Drawing.Size(176, 31);
            this.btn_ShowALL.TabIndex = 45;
            this.btn_ShowALL.Text = "Hiển thị tất cả Voucher";
            this.btn_ShowALL.UseVisualStyleBackColor = true;
            this.btn_ShowALL.Click += new System.EventHandler(this.btn_ShowALL_Click);
            // 
            // txb_MaxDiscount
            // 
            this.txb_MaxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_MaxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MaxDiscount.Location = new System.Drawing.Point(558, 398);
            this.txb_MaxDiscount.Name = "txb_MaxDiscount";
            this.txb_MaxDiscount.Size = new System.Drawing.Size(201, 30);
            this.txb_MaxDiscount.TabIndex = 44;
            this.txb_MaxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_KeyPress);
            // 
            // txb_Quantity
            // 
            this.txb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Quantity.Location = new System.Drawing.Point(128, 336);
            this.txb_Quantity.Name = "txb_Quantity";
            this.txb_Quantity.Size = new System.Drawing.Size(201, 30);
            this.txb_Quantity.TabIndex = 43;
            this.txb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_KeyPress);
            // 
            // txb_MinTotal
            // 
            this.txb_MinTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_MinTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_MinTotal.Location = new System.Drawing.Point(558, 332);
            this.txb_MinTotal.Name = "txb_MinTotal";
            this.txb_MinTotal.Size = new System.Drawing.Size(201, 30);
            this.txb_MinTotal.TabIndex = 42;
            this.txb_MinTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_KeyPress);
            // 
            // Txb_Discount
            // 
            this.Txb_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Discount.Location = new System.Drawing.Point(128, 398);
            this.Txb_Discount.Name = "Txb_Discount";
            this.Txb_Discount.Size = new System.Drawing.Size(201, 30);
            this.Txb_Discount.TabIndex = 41;
            this.Txb_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Điều kiện tối đa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Điều kiện tối thiểu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Khuyến mãi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Số lượng:";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(498, 284);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(261, 22);
            this.dtp_EndDate.TabIndex = 36;
            // 
            // dtp_FromDate
            // 
            this.dtp_FromDate.Location = new System.Drawing.Point(128, 282);
            this.dtp_FromDate.Name = "dtp_FromDate";
            this.dtp_FromDate.Size = new System.Drawing.Size(261, 22);
            this.dtp_FromDate.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thời hạn: ";
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(12, 27);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(256, 20);
            this.Lb_Title.TabIndex = 33;
            this.Lb_Title.Text = "Ngày Voucher còn áp dụng được:";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(11, 462);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(106, 31);
            this.btn_Add.TabIndex = 32;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(639, 22);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(106, 31);
            this.Btn_Search.TabIndex = 31;
            this.Btn_Search.Text = "Tìm kiếm";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // dtp_DateSearch
            // 
            this.dtp_DateSearch.Location = new System.Drawing.Point(338, 27);
            this.dtp_DateSearch.Name = "dtp_DateSearch";
            this.dtp_DateSearch.Size = new System.Drawing.Size(261, 22);
            this.dtp_DateSearch.TabIndex = 30;
            // 
            // dgv_Voucher
            // 
            this.dgv_Voucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Voucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Voucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Voucher.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Voucher.Location = new System.Drawing.Point(12, 70);
            this.dgv_Voucher.Name = "dgv_Voucher";
            this.dgv_Voucher.ReadOnly = true;
            this.dgv_Voucher.RowHeadersWidth = 51;
            this.dgv_Voucher.RowTemplate.Height = 30;
            this.dgv_Voucher.Size = new System.Drawing.Size(1261, 189);
            this.dgv_Voucher.TabIndex = 29;
            // 
            // FormDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 585);
            this.Controls.Add(this.btn_ShowALL);
            this.Controls.Add(this.txb_MaxDiscount);
            this.Controls.Add(this.txb_Quantity);
            this.Controls.Add(this.txb_MinTotal);
            this.Controls.Add(this.Txb_Discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_FromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Title);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.Btn_Search);
            this.Controls.Add(this.dtp_DateSearch);
            this.Controls.Add(this.dgv_Voucher);
            this.Name = "FormDiscount";
            this.Text = "Khuyến mãi";
            this.Load += new System.EventHandler(this.FormDiscount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowALL;
        private System.Windows.Forms.TextBox txb_MaxDiscount;
        private System.Windows.Forms.TextBox txb_Quantity;
        private System.Windows.Forms.TextBox txb_MinTotal;
        private System.Windows.Forms.TextBox Txb_Discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_FromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_DateSearch;
        private System.Windows.Forms.DataGridView dgv_Voucher;
    }
}