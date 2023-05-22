namespace UI_Winform.View
{
    partial class FormSettingUser
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
            this.ofd_OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Btn_ChangePassword = new System.Windows.Forms.Button();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_IDStaff = new System.Windows.Forms.TextBox();
            this.grb_Shift = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_TypeAccount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_AddImage = new System.Windows.Forms.Button();
            this.pt_Staff = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txb_Salary = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
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
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd_OpenFile
            // 
            this.ofd_OpenFile.FileName = "openFileDialog1";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Btn_ChangePassword);
            this.MainPanel.Controls.Add(this.Lb_Title);
            this.MainPanel.Controls.Add(this.label8);
            this.MainPanel.Controls.Add(this.txb_IDStaff);
            this.MainPanel.Controls.Add(this.grb_Shift);
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.btn_AddImage);
            this.MainPanel.Controls.Add(this.pt_Staff);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.dtp_DateOfBirth);
            this.MainPanel.Controls.Add(this.txb_Salary);
            this.MainPanel.Controls.Add(this.label12);
            this.MainPanel.Controls.Add(this.btn_Update);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.txb_Email);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.txb_PhoneNumber);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.txb_Address);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.txb_Name);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1169, 546);
            this.MainPanel.TabIndex = 0;
            // 
            // Btn_ChangePassword
            // 
            this.Btn_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChangePassword.Location = new System.Drawing.Point(303, 470);
            this.Btn_ChangePassword.Name = "Btn_ChangePassword";
            this.Btn_ChangePassword.Size = new System.Drawing.Size(190, 39);
            this.Btn_ChangePassword.TabIndex = 104;
            this.Btn_ChangePassword.Text = "Thay đổi mật khẩu";
            this.Btn_ChangePassword.UseVisualStyleBackColor = true;
            this.Btn_ChangePassword.Click += new System.EventHandler(this.Btn_ChangePassword_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(23, 21);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(165, 20);
            this.Lb_Title.TabIndex = 103;
            this.Lb_Title.Text = "Thông tin cá nhân:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(418, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 102;
            this.label8.Text = "Mã nhân viên:";
            // 
            // txb_IDStaff
            // 
            this.txb_IDStaff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_IDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IDStaff.Location = new System.Drawing.Point(558, 230);
            this.txb_IDStaff.Name = "txb_IDStaff";
            this.txb_IDStaff.ReadOnly = true;
            this.txb_IDStaff.Size = new System.Drawing.Size(215, 27);
            this.txb_IDStaff.TabIndex = 101;
            // 
            // grb_Shift
            // 
            this.grb_Shift.Location = new System.Drawing.Point(923, 297);
            this.grb_Shift.Name = "grb_Shift";
            this.grb_Shift.Size = new System.Drawing.Size(215, 234);
            this.grb_Shift.TabIndex = 100;
            this.grb_Shift.TabStop = false;
            this.grb_Shift.Text = "Ca làm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_TypeAccount);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txb_Account);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(27, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 78);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài Khoản";
            // 
            // txb_TypeAccount
            // 
            this.txb_TypeAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_TypeAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TypeAccount.Location = new System.Drawing.Point(532, 30);
            this.txb_TypeAccount.Name = "txb_TypeAccount";
            this.txb_TypeAccount.ReadOnly = true;
            this.txb_TypeAccount.Size = new System.Drawing.Size(215, 27);
            this.txb_TypeAccount.TabIndex = 19;
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
            this.txb_Account.ReadOnly = true;
            this.txb_Account.Size = new System.Drawing.Size(215, 27);
            this.txb_Account.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(389, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Loại tài khoản:";
            // 
            // btn_AddImage
            // 
            this.btn_AddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddImage.Location = new System.Drawing.Point(977, 244);
            this.btn_AddImage.Name = "btn_AddImage";
            this.btn_AddImage.Size = new System.Drawing.Size(106, 31);
            this.btn_AddImage.TabIndex = 98;
            this.btn_AddImage.Text = "Thêm ảnh";
            this.btn_AddImage.UseVisualStyleBackColor = true;
            this.btn_AddImage.Click += new System.EventHandler(this.btn_AddImage_Click);
            // 
            // pt_Staff
            // 
            this.pt_Staff.Location = new System.Drawing.Point(944, 90);
            this.pt_Staff.Name = "pt_Staff";
            this.pt_Staff.Size = new System.Drawing.Size(178, 137);
            this.pt_Staff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt_Staff.TabIndex = 97;
            this.pt_Staff.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Ảnh nhân viên:";
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(558, 95);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(215, 22);
            this.dtp_DateOfBirth.TabIndex = 95;
            // 
            // txb_Salary
            // 
            this.txb_Salary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Salary.Location = new System.Drawing.Point(158, 297);
            this.txb_Salary.Name = "txb_Salary";
            this.txb_Salary.ReadOnly = true;
            this.txb_Salary.Size = new System.Drawing.Size(215, 27);
            this.txb_Salary.TabIndex = 94;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 93;
            this.label12.Text = "Lương:";
            // 
            // btn_Update
            // 
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(27, 470);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(190, 39);
            this.btn_Update.TabIndex = 92;
            this.btn_Update.Text = "Cập nhật thông tin";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(817, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 91;
            this.label7.Text = "Ca làm:";
            // 
            // txb_Email
            // 
            this.txb_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Email.Location = new System.Drawing.Point(158, 230);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(215, 27);
            this.txb_Email.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Email:";
            // 
            // txb_PhoneNumber
            // 
            this.txb_PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PhoneNumber.Location = new System.Drawing.Point(558, 168);
            this.txb_PhoneNumber.Name = "txb_PhoneNumber";
            this.txb_PhoneNumber.Size = new System.Drawing.Size(215, 27);
            this.txb_PhoneNumber.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Số điện thoại:";
            // 
            // txb_Address
            // 
            this.txb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Address.Location = new System.Drawing.Point(158, 161);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(215, 27);
            this.txb_Address.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Ngày sinh:";
            // 
            // txb_Name
            // 
            this.txb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name.Location = new System.Drawing.Point(158, 90);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(215, 27);
            this.txb_Name.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên nhân viên:";
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 546);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(1169, 393);
            this.ChildPanel.TabIndex = 1;
            // 
            // FormSettingUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1169, 939);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "FormSettingUser";
            this.Text = "Cài đặt";
            this.Load += new System.EventHandler(this.FormSettingUser_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pt_Staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd_OpenFile;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Btn_ChangePassword;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_IDStaff;
        private System.Windows.Forms.GroupBox grb_Shift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_TypeAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_AddImage;
        private System.Windows.Forms.PictureBox pt_Staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.TextBox txb_Salary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Update;
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
        private System.Windows.Forms.Panel ChildPanel;
    }
}