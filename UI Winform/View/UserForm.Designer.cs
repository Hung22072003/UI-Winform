namespace UI_Winform.View
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panelTitle = new System.Windows.Forms.Panel();
            this.Btn_Maximize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Btn_Setting = new System.Windows.Forms.Button();
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.Btn_TradeHistory = new System.Windows.Forms.Button();
            this.Btn_Storage = new System.Windows.Forms.Button();
            this.Btn_Order = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.panelTitle.Controls.Add(this.Btn_Maximize);
            this.panelTitle.Controls.Add(this.Lb_Title);
            this.panelTitle.Controls.Add(this.Btn_Close);
            this.panelTitle.Controls.Add(this.Btn_Minimize);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(862, 80);
            this.panelTitle.TabIndex = 4;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
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
            this.Btn_Maximize.Location = new System.Drawing.Point(803, 12);
            this.Btn_Maximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Maximize.Name = "Btn_Maximize";
            this.Btn_Maximize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Maximize.Size = new System.Drawing.Size(20, 20);
            this.Btn_Maximize.TabIndex = 2;
            this.Btn_Maximize.Text = "guna2CircleButton3";
            this.Btn_Maximize.Click += new System.EventHandler(this.Btn_Maximize_Click);
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.Lb_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(364, 30);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(92, 22);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "Trang chủ";
            this.Lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Btn_Close.Location = new System.Drawing.Point(830, 12);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Close.Size = new System.Drawing.Size(20, 20);
            this.Btn_Close.TabIndex = 1;
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
            this.Btn_Minimize.Location = new System.Drawing.Point(778, 12);
            this.Btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Minimize.Size = new System.Drawing.Size(20, 20);
            this.Btn_Minimize.TabIndex = 0;
            this.Btn_Minimize.Text = "guna2CircleButton1";
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.panelMenu.Controls.Add(this.Btn_Setting);
            this.panelMenu.Controls.Add(this.Btn_Customer);
            this.panelMenu.Controls.Add(this.Btn_TradeHistory);
            this.panelMenu.Controls.Add(this.Btn_Storage);
            this.panelMenu.Controls.Add(this.Btn_Order);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 633);
            this.panelMenu.TabIndex = 3;
            // 
            // Btn_Setting
            // 
            this.Btn_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Setting.FlatAppearance.BorderSize = 0;
            this.Btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Setting.Image")));
            this.Btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Setting.Location = new System.Drawing.Point(0, 320);
            this.Btn_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Setting.Name = "Btn_Setting";
            this.Btn_Setting.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_Setting.Size = new System.Drawing.Size(220, 60);
            this.Btn_Setting.TabIndex = 9;
            this.Btn_Setting.Text = " Cài đặt";
            this.Btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Setting.UseVisualStyleBackColor = true;
            this.Btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Customer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Customer.Image")));
            this.Btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customer.Location = new System.Drawing.Point(0, 260);
            this.Btn_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Btn_Customer.Size = new System.Drawing.Size(220, 60);
            this.Btn_Customer.TabIndex = 7;
            this.Btn_Customer.Text = " Khách hàng";
            this.Btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Customer.UseVisualStyleBackColor = true;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // Btn_TradeHistory
            // 
            this.Btn_TradeHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_TradeHistory.FlatAppearance.BorderSize = 0;
            this.Btn_TradeHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TradeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TradeHistory.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TradeHistory.Image")));
            this.Btn_TradeHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TradeHistory.Location = new System.Drawing.Point(0, 200);
            this.Btn_TradeHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_TradeHistory.Name = "Btn_TradeHistory";
            this.Btn_TradeHistory.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_TradeHistory.Size = new System.Drawing.Size(220, 60);
            this.Btn_TradeHistory.TabIndex = 3;
            this.Btn_TradeHistory.Text = " Xem lịch sử giao dịch";
            this.Btn_TradeHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TradeHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_TradeHistory.UseVisualStyleBackColor = true;
            this.Btn_TradeHistory.Click += new System.EventHandler(this.Btn_TradeHistory_Click);
            // 
            // Btn_Storage
            // 
            this.Btn_Storage.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Storage.FlatAppearance.BorderSize = 0;
            this.Btn_Storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Storage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Storage.Image")));
            this.Btn_Storage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Storage.Location = new System.Drawing.Point(0, 140);
            this.Btn_Storage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Storage.Name = "Btn_Storage";
            this.Btn_Storage.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_Storage.Size = new System.Drawing.Size(220, 60);
            this.Btn_Storage.TabIndex = 2;
            this.Btn_Storage.Text = " Kho hàng";
            this.Btn_Storage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Storage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Storage.UseVisualStyleBackColor = true;
            this.Btn_Storage.Click += new System.EventHandler(this.Btn_Storage_Click);
            // 
            // Btn_Order
            // 
            this.Btn_Order.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Order.FlatAppearance.BorderSize = 0;
            this.Btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Order.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Order.Image")));
            this.Btn_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Order.Location = new System.Drawing.Point(0, 80);
            this.Btn_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Order.Name = "Btn_Order";
            this.Btn_Order.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_Order.Size = new System.Drawing.Size(220, 60);
            this.Btn_Order.TabIndex = 0;
            this.Btn_Order.Text = " Tạo hóa đơn";
            this.Btn_Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Order.UseVisualStyleBackColor = true;
            this.Btn_Order.Click += new System.EventHandler(this.Btn_Order_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(862, 553);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 633);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Maximize;
        private System.Windows.Forms.Label Lb_Title;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Close;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Minimize;
        private System.Windows.Forms.Button Btn_Storage;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button Btn_TradeHistory;
        private System.Windows.Forms.Button Btn_Order;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button Btn_Customer;
        private System.Windows.Forms.Button Btn_Setting;
    }
}