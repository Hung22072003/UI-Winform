namespace UI_Winform
{
    partial class InfoItem
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
            this.Txb_SellPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Txb_InitialPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_Waranty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Cbb_Category = new System.Windows.Forms.ComboBox();
            this.Txb_Detail = new System.Windows.Forms.TextBox();
            this.Txb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_AddPicture = new System.Windows.Forms.Button();
            this.Cbb_Brand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txb_Quantity = new System.Windows.Forms.TextBox();
            this.Lb_Quantity = new System.Windows.Forms.Label();
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_SellPrice
            // 
            this.Txb_SellPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_SellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_SellPrice.Location = new System.Drawing.Point(563, 172);
            this.Txb_SellPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_SellPrice.Name = "Txb_SellPrice";
            this.Txb_SellPrice.Size = new System.Drawing.Size(215, 27);
            this.Txb_SellPrice.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(420, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Giá bán:";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(341, 476);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(107, 31);
            this.Btn_Reset.TabIndex = 45;
            this.Btn_Reset.Text = "Làm mới";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.Location = new System.Drawing.Point(147, 476);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(107, 31);
            this.Btn_OK.TabIndex = 44;
            this.Btn_OK.Text = "Xác nhận";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Thông số kỹ thuật:";
            // 
            // Txb_InitialPrice
            // 
            this.Txb_InitialPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_InitialPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_InitialPrice.Location = new System.Drawing.Point(167, 172);
            this.Txb_InitialPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_InitialPrice.Name = "Txb_InitialPrice";
            this.Txb_InitialPrice.Size = new System.Drawing.Size(215, 27);
            this.Txb_InitialPrice.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Giá gốc:";
            // 
            // Txb_Waranty
            // 
            this.Txb_Waranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Waranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Waranty.Location = new System.Drawing.Point(167, 233);
            this.Txb_Waranty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_Waranty.Name = "Txb_Waranty";
            this.Txb_Waranty.Size = new System.Drawing.Size(215, 27);
            this.Txb_Waranty.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Bảo hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // Txb_ID
            // 
            this.Txb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_ID.Location = new System.Drawing.Point(167, 62);
            this.Txb_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_ID.Name = "Txb_ID";
            this.Txb_ID.ReadOnly = true;
            this.Txb_ID.Size = new System.Drawing.Size(215, 27);
            this.Txb_ID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(336, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(142, 20);
            this.Lb_Title.TabIndex = 24;
            this.Lb_Title.Text = "Thêm sản phẩm";
            // 
            // Cbb_Category
            // 
            this.Cbb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Category.FormattingEnabled = true;
            this.Cbb_Category.Location = new System.Drawing.Point(167, 116);
            this.Cbb_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbb_Category.Name = "Cbb_Category";
            this.Cbb_Category.Size = new System.Drawing.Size(215, 28);
            this.Cbb_Category.TabIndex = 48;
            // 
            // Txb_Detail
            // 
            this.Txb_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Detail.Location = new System.Drawing.Point(36, 335);
            this.Txb_Detail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_Detail.Multiline = true;
            this.Txb_Detail.Name = "Txb_Detail";
            this.Txb_Detail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txb_Detail.Size = new System.Drawing.Size(723, 116);
            this.Txb_Detail.TabIndex = 49;
            // 
            // Txb_Name
            // 
            this.Txb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Name.Location = new System.Drawing.Point(563, 57);
            this.Txb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_Name.Name = "Txb_Name";
            this.Txb_Name.Size = new System.Drawing.Size(215, 27);
            this.Txb_Name.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(544, 476);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(107, 31);
            this.Btn_Close.TabIndex = 52;
            this.Btn_Close.Text = "Đóng";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(856, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ảnh:";
            // 
            // Btn_AddPicture
            // 
            this.Btn_AddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddPicture.Location = new System.Drawing.Point(914, 273);
            this.Btn_AddPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_AddPicture.Name = "Btn_AddPicture";
            this.Btn_AddPicture.Size = new System.Drawing.Size(107, 31);
            this.Btn_AddPicture.TabIndex = 55;
            this.Btn_AddPicture.Text = "Thêm ảnh";
            this.Btn_AddPicture.UseVisualStyleBackColor = true;
            this.Btn_AddPicture.Click += new System.EventHandler(this.Btn_AddPicture_Click);
            // 
            // Cbb_Brand
            // 
            this.Cbb_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Brand.FormattingEnabled = true;
            this.Cbb_Brand.Location = new System.Drawing.Point(563, 116);
            this.Cbb_Brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cbb_Brand.Name = "Cbb_Brand";
            this.Cbb_Brand.Size = new System.Drawing.Size(215, 28);
            this.Cbb_Brand.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Hãng:";
            // 
            // Txb_Quantity
            // 
            this.Txb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Quantity.Location = new System.Drawing.Point(563, 233);
            this.Txb_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txb_Quantity.Name = "Txb_Quantity";
            this.Txb_Quantity.ReadOnly = true;
            this.Txb_Quantity.Size = new System.Drawing.Size(215, 27);
            this.Txb_Quantity.TabIndex = 59;
            this.Txb_Quantity.Visible = false;
            // 
            // Lb_Quantity
            // 
            this.Lb_Quantity.AutoSize = true;
            this.Lb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Quantity.Location = new System.Drawing.Point(420, 235);
            this.Lb_Quantity.Name = "Lb_Quantity";
            this.Lb_Quantity.Size = new System.Drawing.Size(79, 20);
            this.Lb_Quantity.TabIndex = 58;
            this.Lb_Quantity.Text = "Số lượng:";
            this.Lb_Quantity.Visible = false;
            // 
            // ofd_OpenFile
            // 
            this.ofd_OpenFile.FileName = "openFileDialog1";
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(914, 64);
            this.Picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(178, 178);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 53;
            this.Picture.TabStop = false;
            // 
            // InfoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 541);
            this.Controls.Add(this.Txb_Quantity);
            this.Controls.Add(this.Lb_Quantity);
            this.Controls.Add(this.Cbb_Brand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_AddPicture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Txb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_Detail);
            this.Controls.Add(this.Cbb_Category);
            this.Controls.Add(this.Txb_SellPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txb_InitialPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txb_Waranty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InfoItem";
            this.Text = "Giá bán:";
            this.Load += new System.EventHandler(this.InfoItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_SellPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txb_InitialPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txb_Waranty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.ComboBox Cbb_Category;
        private System.Windows.Forms.TextBox Txb_Detail;
        private System.Windows.Forms.TextBox Txb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_AddPicture;
        private System.Windows.Forms.ComboBox Cbb_Brand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txb_Quantity;
        private System.Windows.Forms.Label Lb_Quantity;
        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
    }
}