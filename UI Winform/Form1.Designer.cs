﻿namespace UI_Winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Btn_Setting = new System.Windows.Forms.Button();
            this.Btn_TradeHistory = new System.Windows.Forms.Button();
            this.Btn_Storage = new System.Windows.Forms.Button();
            this.Btn_Staff = new System.Windows.Forms.Button();
            this.Btn_Revenue = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.panelMenu.Controls.Add(this.Btn_Setting);
            this.panelMenu.Controls.Add(this.Btn_TradeHistory);
            this.panelMenu.Controls.Add(this.Btn_Storage);
            this.panelMenu.Controls.Add(this.Btn_Staff);
            this.panelMenu.Controls.Add(this.Btn_Revenue);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 633);
            this.panelMenu.TabIndex = 0;
            // 
            // Btn_Setting
            // 
            this.Btn_Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Setting.FlatAppearance.BorderSize = 0;
            this.Btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Setting.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Setting.Image")));
            this.Btn_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Setting.Location = new System.Drawing.Point(0, 320);
            this.Btn_Setting.Name = "Btn_Setting";
            this.Btn_Setting.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.Btn_Setting.Size = new System.Drawing.Size(220, 60);
            this.Btn_Setting.TabIndex = 5;
            this.Btn_Setting.Text = " Cài đặt";
            this.Btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Setting.UseVisualStyleBackColor = true;
            this.Btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
            // 
            // Btn_TradeHistory
            // 
            this.Btn_TradeHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_TradeHistory.FlatAppearance.BorderSize = 0;
            this.Btn_TradeHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TradeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TradeHistory.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TradeHistory.Image")));
            this.Btn_TradeHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_TradeHistory.Location = new System.Drawing.Point(0, 260);
            this.Btn_TradeHistory.Name = "Btn_TradeHistory";
            this.Btn_TradeHistory.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Btn_TradeHistory.Size = new System.Drawing.Size(220, 60);
            this.Btn_TradeHistory.TabIndex = 4;
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
            this.Btn_Storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Storage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Storage.Image")));
            this.Btn_Storage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Storage.Location = new System.Drawing.Point(0, 200);
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
            this.Btn_Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Staff.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Staff.Image")));
            this.Btn_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Staff.Location = new System.Drawing.Point(0, 140);
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
            this.Btn_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Revenue.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Revenue.Image")));
            this.Btn_Revenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Revenue.Location = new System.Drawing.Point(0, 80);
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
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.panelTitle.Controls.Add(this.Lb_Title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(862, 80);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // Lb_Title
            // 
            this.Lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(195)))), ((int)(((byte)(178)))));
            this.Lb_Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(374, 30);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(63, 22);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "HOME";
            this.Lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(862, 553);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 633);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button Btn_Revenue;
        private System.Windows.Forms.Button Btn_Setting;
        private System.Windows.Forms.Button Btn_TradeHistory;
        private System.Windows.Forms.Button Btn_Storage;
        private System.Windows.Forms.Button Btn_Staff;
        private System.Windows.Forms.Label Lb_Title;
    }
}

