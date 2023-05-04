﻿namespace UI_Winform
{
    partial class RevenueTimeForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Btn_View = new System.Windows.Forms.Button();
            this.Txb_TotalRevenue = new System.Windows.Forms.TextBox();
            this.Lb_TotalRevenue = new System.Windows.Forms.Label();
            this.Txb_TotalOrders = new System.Windows.Forms.TextBox();
            this.Lb_TotalOrders = new System.Windows.Forms.Label();
            this.Btn_Statistic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.Dgv_Statistic = new System.Windows.Forms.DataGridView();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Btn_View);
            this.MainPanel.Controls.Add(this.Txb_TotalRevenue);
            this.MainPanel.Controls.Add(this.Lb_TotalRevenue);
            this.MainPanel.Controls.Add(this.Txb_TotalOrders);
            this.MainPanel.Controls.Add(this.Lb_TotalOrders);
            this.MainPanel.Controls.Add(this.Btn_Statistic);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.DtpDateEnd);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.DtpDateStart);
            this.MainPanel.Controls.Add(this.Dgv_Statistic);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1098, 392);
            this.MainPanel.TabIndex = 33;
            // 
            // Btn_View
            // 
            this.Btn_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_View.Location = new System.Drawing.Point(948, 343);
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.Size = new System.Drawing.Size(138, 34);
            this.Btn_View.TabIndex = 42;
            this.Btn_View.Text = "Xem chi tiết";
            this.Btn_View.UseVisualStyleBackColor = true;
            this.Btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // Txb_TotalRevenue
            // 
            this.Txb_TotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_TotalRevenue.Location = new System.Drawing.Point(532, 353);
            this.Txb_TotalRevenue.Name = "Txb_TotalRevenue";
            this.Txb_TotalRevenue.ReadOnly = true;
            this.Txb_TotalRevenue.Size = new System.Drawing.Size(177, 20);
            this.Txb_TotalRevenue.TabIndex = 41;
            // 
            // Lb_TotalRevenue
            // 
            this.Lb_TotalRevenue.AutoSize = true;
            this.Lb_TotalRevenue.Location = new System.Drawing.Point(382, 353);
            this.Lb_TotalRevenue.Name = "Lb_TotalRevenue";
            this.Lb_TotalRevenue.Size = new System.Drawing.Size(129, 20);
            this.Lb_TotalRevenue.TabIndex = 40;
            this.Lb_TotalRevenue.Text = "Tổng doanh thu:";
            this.Lb_TotalRevenue.Visible = false;
            // 
            // Txb_TotalOrders
            // 
            this.Txb_TotalOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_TotalOrders.Location = new System.Drawing.Point(149, 356);
            this.Txb_TotalOrders.Name = "Txb_TotalOrders";
            this.Txb_TotalOrders.ReadOnly = true;
            this.Txb_TotalOrders.Size = new System.Drawing.Size(100, 20);
            this.Txb_TotalOrders.TabIndex = 39;
            // 
            // Lb_TotalOrders
            // 
            this.Lb_TotalOrders.AutoSize = true;
            this.Lb_TotalOrders.Location = new System.Drawing.Point(13, 356);
            this.Lb_TotalOrders.Name = "Lb_TotalOrders";
            this.Lb_TotalOrders.Size = new System.Drawing.Size(115, 20);
            this.Lb_TotalOrders.TabIndex = 38;
            this.Lb_TotalOrders.Text = "Tổng hóa đơn:";
            this.Lb_TotalOrders.Visible = false;
            // 
            // Btn_Statistic
            // 
            this.Btn_Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Statistic.Location = new System.Drawing.Point(603, 16);
            this.Btn_Statistic.Name = "Btn_Statistic";
            this.Btn_Statistic.Size = new System.Drawing.Size(106, 34);
            this.Btn_Statistic.TabIndex = 37;
            this.Btn_Statistic.Text = "Thống kê";
            this.Btn_Statistic.UseVisualStyleBackColor = true;
            this.Btn_Statistic.Click += new System.EventHandler(this.Btn_Statistic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "đến";
            // 
            // DtpDateEnd
            // 
            this.DtpDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateEnd.Location = new System.Drawing.Point(386, 18);
            this.DtpDateEnd.Name = "DtpDateEnd";
            this.DtpDateEnd.Size = new System.Drawing.Size(142, 27);
            this.DtpDateEnd.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thống kê từ:";
            // 
            // DtpDateStart
            // 
            this.DtpDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateStart.Location = new System.Drawing.Point(131, 18);
            this.DtpDateStart.Name = "DtpDateStart";
            this.DtpDateStart.Size = new System.Drawing.Size(142, 27);
            this.DtpDateStart.TabIndex = 33;
            // 
            // Dgv_Statistic
            // 
            this.Dgv_Statistic.AllowUserToAddRows = false;
            this.Dgv_Statistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Statistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Statistic.Location = new System.Drawing.Point(12, 67);
            this.Dgv_Statistic.Name = "Dgv_Statistic";
            this.Dgv_Statistic.ReadOnly = true;
            this.Dgv_Statistic.RowHeadersWidth = 51;
            this.Dgv_Statistic.RowTemplate.Height = 24;
            this.Dgv_Statistic.Size = new System.Drawing.Size(1074, 270);
            this.Dgv_Statistic.TabIndex = 32;
            // 
            // PanelChart
            // 
            this.PanelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChart.Location = new System.Drawing.Point(0, 392);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1098, 370);
            this.PanelChart.TabIndex = 34;
            // 
            // RevenueTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1098, 762);
            this.Controls.Add(this.PanelChart);
            this.Controls.Add(this.MainPanel);
            this.Name = "RevenueTimeForm";
            this.Text = "RevenueTimeForm";
            this.Load += new System.EventHandler(this.RevenueTimeForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Btn_Statistic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpDateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpDateStart;
        private System.Windows.Forms.DataGridView Dgv_Statistic;
        private System.Windows.Forms.TextBox Txb_TotalRevenue;
        private System.Windows.Forms.Label Lb_TotalRevenue;
        private System.Windows.Forms.TextBox Txb_TotalOrders;
        private System.Windows.Forms.Label Lb_TotalOrders;
        private System.Windows.Forms.Panel PanelChart;
        private System.Windows.Forms.Button Btn_View;
    }
}