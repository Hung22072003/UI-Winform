namespace UI_Winform.View
{
    partial class FormChangePassword
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
            this.Txb_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Txb_CurPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_NewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txb_ConfPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Lb_Note = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txb_UserName
            // 
            this.Txb_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_UserName.Location = new System.Drawing.Point(209, 64);
            this.Txb_UserName.Name = "Txb_UserName";
            this.Txb_UserName.ReadOnly = true;
            this.Txb_UserName.Size = new System.Drawing.Size(215, 27);
            this.Txb_UserName.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tên đăng nhâp:";
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(15, 25);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(168, 20);
            this.Lb_Title.TabIndex = 81;
            this.Lb_Title.Text = "Thay đổi mật khẩu:";
            // 
            // Txb_CurPassword
            // 
            this.Txb_CurPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_CurPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_CurPassword.Location = new System.Drawing.Point(209, 114);
            this.Txb_CurPassword.Name = "Txb_CurPassword";
            this.Txb_CurPassword.Size = new System.Drawing.Size(215, 27);
            this.Txb_CurPassword.TabIndex = 83;
            this.Txb_CurPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // Txb_NewPassword
            // 
            this.Txb_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_NewPassword.Location = new System.Drawing.Point(209, 165);
            this.Txb_NewPassword.Name = "Txb_NewPassword";
            this.Txb_NewPassword.Size = new System.Drawing.Size(215, 27);
            this.Txb_NewPassword.TabIndex = 85;
            this.Txb_NewPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // Txb_ConfPassword
            // 
            this.Txb_ConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_ConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_ConfPassword.Location = new System.Drawing.Point(209, 213);
            this.Txb_ConfPassword.Name = "Txb_ConfPassword";
            this.Txb_ConfPassword.Size = new System.Drawing.Size(215, 27);
            this.Txb_ConfPassword.TabIndex = 87;
            this.Txb_ConfPassword.UseSystemPasswordChar = true;
            this.Txb_ConfPassword.TextChanged += new System.EventHandler(this.Txb_ConfPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Confirm.Location = new System.Drawing.Point(19, 290);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(190, 39);
            this.Btn_Confirm.TabIndex = 88;
            this.Btn_Confirm.Text = "Xác nhận";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Lb_Note
            // 
            this.Lb_Note.AutoSize = true;
            this.Lb_Note.ForeColor = System.Drawing.Color.Red;
            this.Lb_Note.Location = new System.Drawing.Point(16, 254);
            this.Lb_Note.Name = "Lb_Note";
            this.Lb_Note.Size = new System.Drawing.Size(0, 16);
            this.Lb_Note.TabIndex = 93;
            // 
            // Btn_Close
            // 
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(273, 290);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(190, 39);
            this.Btn_Close.TabIndex = 94;
            this.Btn_Close.Text = "Đóng";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 356);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lb_Note);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Txb_ConfPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txb_NewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txb_CurPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb_Title);
            this.Controls.Add(this.Txb_UserName);
            this.Controls.Add(this.label2);
            this.Name = "FormChangePassword";
            this.Text = "FormChangePassword";
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.TextBox Txb_CurPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_NewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txb_ConfPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Label Lb_Note;
        private System.Windows.Forms.Button Btn_Close;
    }
}