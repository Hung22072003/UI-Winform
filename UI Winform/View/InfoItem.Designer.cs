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
            this.Cbb_Status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txb_InitialPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txb_Waranty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Cbb_Brand = new System.Windows.Forms.ComboBox();
            this.Txb_Detail = new System.Windows.Forms.TextBox();
            this.Txb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txb_SellPrice
            // 
            this.Txb_SellPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_SellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_SellPrice.Location = new System.Drawing.Point(422, 140);
            this.Txb_SellPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txb_SellPrice.Name = "Txb_SellPrice";
            this.Txb_SellPrice.Size = new System.Drawing.Size(162, 23);
            this.Txb_SellPrice.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(315, 141);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Giá bán:";
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reset.Location = new System.Drawing.Point(256, 371);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(80, 25);
            this.Btn_Reset.TabIndex = 45;
            this.Btn_Reset.Text = "Làm mới";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.Location = new System.Drawing.Point(110, 371);
            this.Btn_OK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(80, 25);
            this.Btn_OK.TabIndex = 44;
            this.Btn_OK.Text = "Xác nhận";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Thông số kỹ thuật:";
            // 
            // Cbb_Status
            // 
            this.Cbb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Status.FormattingEnabled = true;
            this.Cbb_Status.Items.AddRange(new object[] {
            "Có sẵn",
            "Sắp ra mắt"});
            this.Cbb_Status.Location = new System.Drawing.Point(125, 183);
            this.Cbb_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbb_Status.Name = "Cbb_Status";
            this.Cbb_Status.Size = new System.Drawing.Size(162, 25);
            this.Cbb_Status.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tình trạng:";
            // 
            // Txb_InitialPrice
            // 
            this.Txb_InitialPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_InitialPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_InitialPrice.Location = new System.Drawing.Point(125, 140);
            this.Txb_InitialPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txb_InitialPrice.Name = "Txb_InitialPrice";
            this.Txb_InitialPrice.Size = new System.Drawing.Size(162, 23);
            this.Txb_InitialPrice.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Giá gốc:";
            // 
            // Txb_Waranty
            // 
            this.Txb_Waranty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Waranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Waranty.Location = new System.Drawing.Point(422, 94);
            this.Txb_Waranty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txb_Waranty.Name = "Txb_Waranty";
            this.Txb_Waranty.Size = new System.Drawing.Size(162, 23);
            this.Txb_Waranty.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Bảo hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Hãng:";
            // 
            // Txb_ID
            // 
            this.Txb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_ID.Location = new System.Drawing.Point(125, 50);
            this.Txb_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txb_ID.Name = "Txb_ID";
            this.Txb_ID.Size = new System.Drawing.Size(162, 23);
            this.Txb_ID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(252, 7);
            this.Lb_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(123, 17);
            this.Lb_Title.TabIndex = 24;
            this.Lb_Title.Text = "Thêm sản phẩm";
            // 
            // Cbb_Brand
            // 
            this.Cbb_Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Brand.FormattingEnabled = true;
            this.Cbb_Brand.Location = new System.Drawing.Point(125, 94);
            this.Cbb_Brand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbb_Brand.Name = "Cbb_Brand";
            this.Cbb_Brand.Size = new System.Drawing.Size(162, 25);
            this.Cbb_Brand.TabIndex = 48;
            // 
            // Txb_Detail
            // 
            this.Txb_Detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Detail.Location = new System.Drawing.Point(27, 257);
            this.Txb_Detail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txb_Detail.Multiline = true;
            this.Txb_Detail.Name = "Txb_Detail";
            this.Txb_Detail.Size = new System.Drawing.Size(543, 95);
            this.Txb_Detail.TabIndex = 49;
            // 
            // Txb_Name
            // 
            this.Txb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Name.Location = new System.Drawing.Point(422, 50);
            this.Txb_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txb_Name.Name = "Txb_Name";
            this.Txb_Name.Size = new System.Drawing.Size(162, 23);
            this.Txb_Name.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(408, 371);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(80, 25);
            this.Btn_Close.TabIndex = 52;
            this.Btn_Close.Text = "Đóng";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(645, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 111);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ảnh:";
            // 
            // InfoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Txb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txb_Detail);
            this.Controls.Add(this.Cbb_Brand);
            this.Controls.Add(this.Txb_SellPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cbb_Status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txb_InitialPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txb_Waranty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InfoItem";
            this.Text = "Giá bán:";
            this.Load += new System.EventHandler(this.InfoItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_SellPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Cbb_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txb_InitialPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txb_Waranty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.ComboBox Cbb_Brand;
        private System.Windows.Forms.TextBox Txb_Detail;
        private System.Windows.Forms.TextBox Txb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}