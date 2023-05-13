namespace UI_Winform
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Maximize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Panel_Lock = new System.Windows.Forms.Panel();
            this.Txb_PassWord = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txb_UserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 453);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(61, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 47);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_Maximize);
            this.panel3.Controls.Add(this.Btn_Login);
            this.panel3.Controls.Add(this.Btn_Close);
            this.panel3.Controls.Add(this.Btn_Minimize);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(310, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 453);
            this.panel3.TabIndex = 1;
            // 
            // Btn_Maximize
            // 
            this.Btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Maximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Maximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Maximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Maximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Maximize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(5)))));
            this.Btn_Maximize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Maximize.ForeColor = System.Drawing.Color.White;
            this.Btn_Maximize.Location = new System.Drawing.Point(394, 12);
            this.Btn_Maximize.Name = "Btn_Maximize";
            this.Btn_Maximize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Maximize.Size = new System.Drawing.Size(20, 20);
            this.Btn_Maximize.TabIndex = 5;
            this.Btn_Maximize.Text = "guna2CircleButton3";
            this.Btn_Maximize.Click += new System.EventHandler(this.Btn_Maximize_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(6, 313);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(133, 32);
            this.Btn_Login.TabIndex = 5;
            this.Btn_Login.Text = "LOGIN";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(82)))));
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(420, 12);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Close.Size = new System.Drawing.Size(20, 20);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "guna2CircleButton2";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(204)))), ((int)(((byte)(55)))));
            this.Btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.Btn_Minimize.Location = new System.Drawing.Point(368, 12);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Minimize.Size = new System.Drawing.Size(20, 20);
            this.Btn_Minimize.TabIndex = 3;
            this.Btn_Minimize.Text = "guna2CircleButton1";
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.label6.Location = new System.Drawing.Point(6, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Panel_Lock);
            this.panel5.Controls.Add(this.Txb_PassWord);
            this.panel5.Location = new System.Drawing.Point(0, 240);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(450, 45);
            this.panel5.TabIndex = 2;
            // 
            // Panel_Lock
            // 
            this.Panel_Lock.BackColor = System.Drawing.Color.White;
            this.Panel_Lock.BackgroundImage = global::UI_Winform.Properties.Resources.lock_solid;
            this.Panel_Lock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_Lock.Location = new System.Drawing.Point(6, 10);
            this.Panel_Lock.Name = "Panel_Lock";
            this.Panel_Lock.Size = new System.Drawing.Size(25, 25);
            this.Panel_Lock.TabIndex = 2;
            this.Panel_Lock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Lock_MouseDown);
            this.Panel_Lock.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Lock_MouseUp);
            // 
            // Txb_PassWord
            // 
            this.Txb_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_PassWord.Location = new System.Drawing.Point(56, 12);
            this.Txb_PassWord.Name = "Txb_PassWord";
            this.Txb_PassWord.Size = new System.Drawing.Size(370, 20);
            this.Txb_PassWord.TabIndex = 1;
            this.Txb_PassWord.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.Txb_UserName);
            this.panel4.Location = new System.Drawing.Point(0, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 45);
            this.panel4.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(6, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(25, 25);
            this.panel6.TabIndex = 1;
            // 
            // Txb_UserName
            // 
            this.Txb_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_UserName.Location = new System.Drawing.Point(56, 12);
            this.Txb_UserName.Name = "Txb_UserName";
            this.Txb_UserName.Size = new System.Drawing.Size(370, 20);
            this.Txb_UserName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(67, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "LOGIN TO YOUR ACCOUNT";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 453);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Txb_UserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_PassWord;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel Panel_Lock;
        private System.Windows.Forms.Button Btn_Login;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Maximize;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Close;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Minimize;
    }
}