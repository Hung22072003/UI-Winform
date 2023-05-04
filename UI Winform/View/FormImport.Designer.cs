namespace UI_Winform.View
{
    partial class FormImport
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
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Lb_IdItem = new System.Windows.Forms.Label();
            this.Lb_NameItem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txb_Quantity = new System.Windows.Forms.TextBox();
            this.Txb_Price = new System.Windows.Forms.TextBox();
            this.Txb_Total = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpImportDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(12, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(104, 20);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "Nhập hàng:";
            // 
            // Lb_IdItem
            // 
            this.Lb_IdItem.AutoSize = true;
            this.Lb_IdItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_IdItem.Location = new System.Drawing.Point(12, 55);
            this.Lb_IdItem.Name = "Lb_IdItem";
            this.Lb_IdItem.Size = new System.Drawing.Size(115, 20);
            this.Lb_IdItem.TabIndex = 1;
            this.Lb_IdItem.Text = "Mã sản phẩm:";
            // 
            // Lb_NameItem
            // 
            this.Lb_NameItem.AutoSize = true;
            this.Lb_NameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NameItem.Location = new System.Drawing.Point(12, 104);
            this.Lb_NameItem.Name = "Lb_NameItem";
            this.Lb_NameItem.Size = new System.Drawing.Size(120, 20);
            this.Lb_NameItem.TabIndex = 2;
            this.Lb_NameItem.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng tiền:";
            // 
            // Txb_Quantity
            // 
            this.Txb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Quantity.Location = new System.Drawing.Point(136, 198);
            this.Txb_Quantity.Name = "Txb_Quantity";
            this.Txb_Quantity.Size = new System.Drawing.Size(85, 27);
            this.Txb_Quantity.TabIndex = 6;
            this.Txb_Quantity.TextChanged += new System.EventHandler(this.Txb_TextChanged);
            // 
            // Txb_Price
            // 
            this.Txb_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Price.Location = new System.Drawing.Point(136, 248);
            this.Txb_Price.Name = "Txb_Price";
            this.Txb_Price.Size = new System.Drawing.Size(157, 27);
            this.Txb_Price.TabIndex = 7;
            this.Txb_Price.TextChanged += new System.EventHandler(this.Txb_TextChanged);
            // 
            // Txb_Total
            // 
            this.Txb_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Total.Location = new System.Drawing.Point(136, 302);
            this.Txb_Total.Name = "Txb_Total";
            this.Txb_Total.ReadOnly = true;
            this.Txb_Total.Size = new System.Drawing.Size(157, 27);
            this.Txb_Total.TabIndex = 8;
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.Location = new System.Drawing.Point(20, 358);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(107, 31);
            this.Btn_OK.TabIndex = 45;
            this.Btn_OK.Text = "Xác nhận";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ngày nhập:";
            // 
            // dtpImportDate
            // 
            this.dtpImportDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpImportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImportDate.Location = new System.Drawing.Point(136, 149);
            this.dtpImportDate.Name = "dtpImportDate";
            this.dtpImportDate.Size = new System.Drawing.Size(285, 27);
            this.dtpImportDate.TabIndex = 47;
            this.dtpImportDate.Value = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(186, 358);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(107, 31);
            this.Btn_Close.TabIndex = 48;
            this.Btn_Close.Text = "Đóng";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.dtpImportDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Txb_Total);
            this.Controls.Add(this.Txb_Price);
            this.Controls.Add(this.Txb_Quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lb_NameItem);
            this.Controls.Add(this.Lb_IdItem);
            this.Controls.Add(this.Lb_Title);
            this.Name = "FormImport";
            this.Text = "FormImport";
            this.Load += new System.EventHandler(this.FormImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label Lb_IdItem;
        private System.Windows.Forms.Label Lb_NameItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txb_Quantity;
        private System.Windows.Forms.TextBox Txb_Price;
        private System.Windows.Forms.TextBox Txb_Total;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpImportDate;
        private System.Windows.Forms.Button Btn_Close;
    }
}