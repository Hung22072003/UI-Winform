namespace UI_Winform
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Btn_Discount = new System.Windows.Forms.Button();
            this.Btn_TradeHistory = new System.Windows.Forms.Button();
            this.Btn_Storage = new System.Windows.Forms.Button();
            this.Btn_Staff = new System.Windows.Forms.Button();
            this.Btn_Revenue = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.Btn_Maximize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Btn_Minimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.Btn_Customer = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.panelMenu.Controls.Add(this.Btn_Customer);
            this.panelMenu.Controls.Add(this.Btn_Discount);
            this.panelMenu.Controls.Add(this.Btn_TradeHistory);
            this.panelMenu.Controls.Add(this.Btn_Storage);
            this.panelMenu.Controls.Add(this.Btn_Staff);
            this.panelMenu.Controls.Add(this.Btn_Revenue);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 680);
            this.panelMenu.TabIndex = 0;
            // 
            // Btn_Discount
            // 
            this.Btn_Discount.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Discount.FlatAppearance.BorderSize = 0;
            this.Btn_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Discount.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Discount.Image")));
            this.Btn_Discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Discount.Location = new System.Drawing.Point(0, 320);
            this.Btn_Discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Discount.Name = "Btn_Discount";
            this.Btn_Discount.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Btn_Discount.Size = new System.Drawing.Size(220, 60);
            this.Btn_Discount.TabIndex = 5;
            this.Btn_Discount.Text = "   Khuyến mãi";
            this.Btn_Discount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Discount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Discount.UseVisualStyleBackColor = true;
            this.Btn_Discount.Click += new System.EventHandler(this.Btn_Discount_Click);
            // 
            // Btn_TradeHistory
            // 
            this.Btn_TradeHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_TradeHistory.FlatAppearance.BorderSize = 0;
            this.Btn_TradeHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TradeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TradeHistory.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TradeHistory.Image")));
            this.Btn_TradeHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TradeHistory.Location = new System.Drawing.Point(0, 260);
            this.Btn_TradeHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_TradeHistory.Name = "Btn_TradeHistory";
            this.Btn_TradeHistory.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Btn_TradeHistory.Size = new System.Drawing.Size(220, 60);
            this.Btn_TradeHistory.TabIndex = 4;
            this.Btn_TradeHistory.Text = "   Quản lý chi tiêu";
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
            this.Btn_Storage.Location = new System.Drawing.Point(0, 200);
            this.Btn_Storage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Storage.Name = "Btn_Storage";
            this.Btn_Storage.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_Storage.Size = new System.Drawing.Size(220, 60);
            this.Btn_Storage.TabIndex = 3;
            this.Btn_Storage.Text = " Quản lý kho hàng";
            this.Btn_Storage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Storage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Storage.UseVisualStyleBackColor = true;
            this.Btn_Storage.Click += new System.EventHandler(this.Btn_Storage_Click);
            // 
            // Btn_Staff
            // 
            this.Btn_Staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Staff.FlatAppearance.BorderSize = 0;
            this.Btn_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Staff.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Staff.Image")));
            this.Btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Staff.Location = new System.Drawing.Point(0, 140);
            this.Btn_Staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Staff.Name = "Btn_Staff";
            this.Btn_Staff.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_Staff.Size = new System.Drawing.Size(220, 60);
            this.Btn_Staff.TabIndex = 2;
            this.Btn_Staff.Text = " Quản lý nhân viên";
            this.Btn_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Staff.UseVisualStyleBackColor = true;
            this.Btn_Staff.Click += new System.EventHandler(this.Btn_Staff_Click);
            // 
            // Btn_Revenue
            // 
            this.Btn_Revenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Revenue.FlatAppearance.BorderSize = 0;
            this.Btn_Revenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Revenue.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Revenue.Image")));
            this.Btn_Revenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Revenue.Location = new System.Drawing.Point(0, 80);
            this.Btn_Revenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Revenue.Name = "Btn_Revenue";
            this.Btn_Revenue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_Revenue.Size = new System.Drawing.Size(220, 60);
            this.Btn_Revenue.TabIndex = 0;
            this.Btn_Revenue.Text = " Quản lý doanh thu";
            this.Btn_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Revenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Revenue.UseVisualStyleBackColor = true;
            this.Btn_Revenue.Click += new System.EventHandler(this.Btn_Revenue_Click);
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
            this.panelTitle.Size = new System.Drawing.Size(880, 80);
            this.panelTitle.TabIndex = 1;
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
            this.Btn_Maximize.Location = new System.Drawing.Point(821, 12);
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
            this.Lb_Title.Location = new System.Drawing.Point(373, 30);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(63, 22);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "HOME";
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
            this.Btn_Close.Location = new System.Drawing.Point(848, 12);
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
            this.Btn_Minimize.Location = new System.Drawing.Point(796, 12);
            this.Btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Btn_Minimize.Size = new System.Drawing.Size(20, 20);
            this.Btn_Minimize.TabIndex = 0;
            this.Btn_Minimize.Text = "guna2CircleButton1";
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.AutoScroll = true;
            this.panelDesktopPane.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(880, 600);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Btn_Customer
            // 
            this.Btn_Customer.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Customer.FlatAppearance.BorderSize = 0;
            this.Btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Customer.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Customer.Image")));
            this.Btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customer.Location = new System.Drawing.Point(0, 380);
            this.Btn_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Customer.Name = "Btn_Customer";
            this.Btn_Customer.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.Btn_Customer.Size = new System.Drawing.Size(220, 60);
            this.Btn_Customer.TabIndex = 6;
            this.Btn_Customer.Text = " Khách hàng";
            this.Btn_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Customer.UseVisualStyleBackColor = true;
            this.Btn_Customer.Click += new System.EventHandler(this.Btn_Customer_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1100, 679);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button Btn_Revenue;
        private System.Windows.Forms.Button Btn_TradeHistory;
        private System.Windows.Forms.Button Btn_Storage;
        private System.Windows.Forms.Button Btn_Staff;
        private System.Windows.Forms.Label Lb_Title;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Maximize;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Close;
        private Guna.UI2.WinForms.Guna2CircleButton Btn_Minimize;
        private System.Windows.Forms.Button Btn_Discount;
        private System.Windows.Forms.Button Btn_Customer;
    }
}

