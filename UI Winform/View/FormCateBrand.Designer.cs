namespace UI_Winform.View
{
    partial class FormCateBrand
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_Name = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Txb_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbb_Category = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(12, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(211, 20);
            this.Lb_Title.TabIndex = 33;
            this.Lb_Title.Text = "Thêm hãng/loại sản phẩm: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên hãng/loại sản phẩm: ";
            // 
            // Txb_Name
            // 
            this.Txb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Name.Location = new System.Drawing.Point(249, 58);
            this.Txb_Name.Name = "Txb_Name";
            this.Txb_Name.Size = new System.Drawing.Size(201, 30);
            this.Txb_Name.TabIndex = 35;
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.Location = new System.Drawing.Point(16, 247);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(106, 31);
            this.Btn_OK.TabIndex = 36;
            this.Btn_OK.Text = "Xác nhận";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Txb_ID
            // 
            this.Txb_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_ID.Location = new System.Drawing.Point(249, 117);
            this.Txb_ID.Name = "Txb_ID";
            this.Txb_ID.Size = new System.Drawing.Size(201, 30);
            this.Txb_ID.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã hãng/loại sản phẩm: ";
            // 
            // Cbb_Category
            // 
            this.Cbb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Category.FormattingEnabled = true;
            this.Cbb_Category.Items.AddRange(new object[] {
            "Hãng",
            "Loại sản phẩm"});
            this.Cbb_Category.Location = new System.Drawing.Point(249, 175);
            this.Cbb_Category.Name = "Cbb_Category";
            this.Cbb_Category.Size = new System.Drawing.Size(201, 33);
            this.Cbb_Category.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Mã hãng/loại sản phẩm: ";
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(344, 247);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(106, 31);
            this.Btn_Close.TabIndex = 44;
            this.Btn_Close.Text = "Đóng";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // FormCateBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbb_Category);
            this.Controls.Add(this.Txb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Txb_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Title);
            this.Name = "FormCateBrand";
            this.Text = "FormCateBrand";
            this.Load += new System.EventHandler(this.FormCateBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_Name;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.TextBox Txb_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbb_Category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Close;
    }
}