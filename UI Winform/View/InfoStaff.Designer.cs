namespace UI_Winform
{
    partial class InfoStaff
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
            this.label8 = new System.Windows.Forms.Label();
            this.txb_IDStaff = new System.Windows.Forms.TextBox();
            this.grb_Shift = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_PassWord = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtn_Staff = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtn_Manager = new System.Windows.Forms.RadioButton();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.pt_Staff = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txb_Salary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Mã nhân viên:";
            // 
            // txb_IDStaff
            // 
            this.txb_IDStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_IDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IDStaff.Location = new System.Drawing.Point(559, 202);
            this.txb_IDStaff.Name = "txb_IDStaff";
            this.txb_IDStaff.Size = new System.Drawing.Size(215, 27);
            this.txb_IDStaff.TabIndex = 56;
            // 
            // grb_Shift
            // 
            this.grb_Shift.Location = new System.Drawing.Point(924, 269);
            this.grb_Shift.Name = "grb_Shift";
            this.grb_Shift.Size = new System.Drawing.Size(215, 234);
            this.grb_Shift.TabIndex = 55;
            this.grb_Shift.TabStop = false;
            this.grb_Shift.Text = "Ca làm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_PassWord);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txb_Account);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.rbtn_Staff);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbtn_Manager);
            this.groupBox1.Location = new System.Drawing.Point(28, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 112);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // txb_PassWord
            // 
            this.txb_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PassWord.Location = new System.Drawing.Point(531, 31);
            this.txb_PassWord.Name = "txb_PassWord";
            this.txb_PassWord.Size = new System.Drawing.Size(215, 27);
            this.txb_PassWord.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tên đăng nhập:";
            // 
            // txb_Account
            // 
            this.txb_Account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Account.Location = new System.Drawing.Point(149, 30);
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(215, 27);
            this.txb_Account.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(414, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mật khẩu:";
            // 
            // rbtn_Staff
            // 
            this.rbtn_Staff.AutoSize = true;
            this.rbtn_Staff.Location = new System.Drawing.Point(274, 71);
            this.rbtn_Staff.Name = "rbtn_Staff";
            this.rbtn_Staff.Size = new System.Drawing.Size(90, 20);
            this.rbtn_Staff.TabIndex = 26;
            this.rbtn_Staff.TabStop = true;
            this.rbtn_Staff.Text = "Nhân Viên";
            this.rbtn_Staff.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Loại tài khoản:";
            // 
            // rbtn_Manager
            // 
            this.rbtn_Manager.AutoSize = true;
            this.rbtn_Manager.Location = new System.Drawing.Point(169, 71);
            this.rbtn_Manager.Name = "rbtn_Manager";
            this.rbtn_Manager.Size = new System.Drawing.Size(77, 20);
            this.rbtn_Manager.TabIndex = 25;
            this.rbtn_Manager.TabStop = true;
            this.rbtn_Manager.Text = "Quản Lý";
            this.rbtn_Manager.UseVisualStyleBackColor = true;
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddImage.Location = new System.Drawing.Point(978, 216);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(106, 31);
            this.btn_AddImage.TabIndex = 53;
            this.btn_AddImage.Text = "Thêm ảnh";
            this.btn_AddImage.UseVisualStyleBackColor = true;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // pt_Staff
            // 
            this.pt_Staff.Location = new System.Drawing.Point(945, 62);
            this.pt_Staff.Name = "pt_Staff";
            this.pt_Staff.Size = new System.Drawing.Size(178, 137);
            this.pt_Staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_Staff.TabIndex = 52;
            this.pt_Staff.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Ảnh nhân viên:";
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(559, 67);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(215, 22);
            this.dtp_DateOfBirth.TabIndex = 50;
            // 
            // txb_Salary
            // 
            this.txb_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Salary.Location = new System.Drawing.Point(159, 269);
            this.txb_Salary.Name = "txb_Salary";
            this.txb_Salary.Size = new System.Drawing.Size(215, 27);
            this.txb_Salary.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 48;
            this.label12.Text = "Lương:";
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(559, 472);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(106, 31);
            this.btn_Reset.TabIndex = 47;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Location = new System.Drawing.Point(171, 472);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(106, 31);
            this.btn_Ok.TabIndex = 46;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(818, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ca làm:";
            // 
            // txb_Email
            // 
            this.txb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Email.Location = new System.Drawing.Point(159, 202);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(215, 27);
            this.txb_Email.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Email:";
            // 
            // txb_PhoneNumber
            // 
            this.txb_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PhoneNumber.Location = new System.Drawing.Point(559, 140);
            this.txb_PhoneNumber.Name = "txb_PhoneNumber";
            this.txb_PhoneNumber.Size = new System.Drawing.Size(215, 27);
            this.txb_PhoneNumber.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Số điện thoại:";
            // 
            // txb_Address
            // 
            this.txb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Address.Location = new System.Drawing.Point(159, 133);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(215, 27);
            this.txb_Address.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày sinh:";
            // 
            // txb_Name
            // 
            this.txb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name.Location = new System.Drawing.Point(159, 62);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(215, 27);
            this.txb_Name.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tên nhân viên:";
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(339, 9);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(141, 20);
            this.Lb_Title.TabIndex = 35;
            this.Lb_Title.Text = "Thêm nhân viên";
            // 
            // ofd_OpenFile
            // 
            this.ofd_OpenFile.FileName = "openFileDialog1";
            // 
            // InfoStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1161, 533);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_IDStaff);
            this.Controls.Add(this.grb_Shift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_AddImage);
            this.Controls.Add(this.pt_Staff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_DateOfBirth);
            this.Controls.Add(this.txb_Salary);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_PhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txb_Address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lb_Title);
            this.Name = "InfoStaff";
            this.Text = "InfoStaff";
            this.Load += new System.EventHandler(this.InfoStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_IDStaff;
        private System.Windows.Forms.GroupBox grb_Shift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_PassWord;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtn_Staff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtn_Manager;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.PictureBox pt_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.TextBox txb_Salary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_PhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
    }
}