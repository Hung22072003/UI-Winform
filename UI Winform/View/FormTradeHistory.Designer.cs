namespace UI_Winform.View
{
    partial class FormTradeHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Txb_Search = new System.Windows.Forms.TextBox();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_View
            // 
            this.Btn_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_View.Location = new System.Drawing.Point(960, 337);
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.Size = new System.Drawing.Size(138, 34);
            this.Btn_View.TabIndex = 53;
            this.Btn_View.Text = "Xem chi tiết";
            this.Btn_View.UseVisualStyleBackColor = true;
            this.Btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // Txb_TotalRevenue
            // 
            this.Txb_TotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_TotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_TotalRevenue.Location = new System.Drawing.Point(532, 347);
            this.Txb_TotalRevenue.Name = "Txb_TotalRevenue";
            this.Txb_TotalRevenue.ReadOnly = true;
            this.Txb_TotalRevenue.Size = new System.Drawing.Size(177, 20);
            this.Txb_TotalRevenue.TabIndex = 52;
            // 
            // Lb_TotalRevenue
            // 
            this.Lb_TotalRevenue.AutoSize = true;
            this.Lb_TotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TotalRevenue.Location = new System.Drawing.Point(382, 347);
            this.Lb_TotalRevenue.Name = "Lb_TotalRevenue";
            this.Lb_TotalRevenue.Size = new System.Drawing.Size(129, 20);
            this.Lb_TotalRevenue.TabIndex = 51;
            this.Lb_TotalRevenue.Text = "Tổng doanh thu:";
            this.Lb_TotalRevenue.Visible = false;
            // 
            // Txb_TotalOrders
            // 
            this.Txb_TotalOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_TotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_TotalOrders.Location = new System.Drawing.Point(149, 350);
            this.Txb_TotalOrders.Name = "Txb_TotalOrders";
            this.Txb_TotalOrders.ReadOnly = true;
            this.Txb_TotalOrders.Size = new System.Drawing.Size(100, 20);
            this.Txb_TotalOrders.TabIndex = 50;
            // 
            // Lb_TotalOrders
            // 
            this.Lb_TotalOrders.AutoSize = true;
            this.Lb_TotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TotalOrders.Location = new System.Drawing.Point(13, 350);
            this.Lb_TotalOrders.Name = "Lb_TotalOrders";
            this.Lb_TotalOrders.Size = new System.Drawing.Size(115, 20);
            this.Lb_TotalOrders.TabIndex = 49;
            this.Lb_TotalOrders.Text = "Tổng hóa đơn:";
            this.Lb_TotalOrders.Visible = false;
            // 
            // Btn_Statistic
            // 
            this.Btn_Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Statistic.Location = new System.Drawing.Point(522, 7);
            this.Btn_Statistic.Name = "Btn_Statistic";
            this.Btn_Statistic.Size = new System.Drawing.Size(106, 34);
            this.Btn_Statistic.TabIndex = 48;
            this.Btn_Statistic.Text = "Thống kê";
            this.Btn_Statistic.UseVisualStyleBackColor = true;
            this.Btn_Statistic.Click += new System.EventHandler(this.Btn_Statistic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "đến";
            // 
            // DtpDateEnd
            // 
            this.DtpDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateEnd.Location = new System.Drawing.Point(347, 9);
            this.DtpDateEnd.Name = "DtpDateEnd";
            this.DtpDateEnd.Size = new System.Drawing.Size(142, 27);
            this.DtpDateEnd.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Thống kê từ:";
            // 
            // DtpDateStart
            // 
            this.DtpDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateStart.Location = new System.Drawing.Point(131, 9);
            this.DtpDateStart.Name = "DtpDateStart";
            this.DtpDateStart.Size = new System.Drawing.Size(142, 27);
            this.DtpDateStart.TabIndex = 44;
            // 
            // Dgv_Statistic
            // 
            this.Dgv_Statistic.AllowUserToAddRows = false;
            this.Dgv_Statistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Statistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Statistic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Statistic.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Statistic.Location = new System.Drawing.Point(12, 61);
            this.Dgv_Statistic.Name = "Dgv_Statistic";
            this.Dgv_Statistic.ReadOnly = true;
            this.Dgv_Statistic.RowHeadersWidth = 51;
            this.Dgv_Statistic.RowTemplate.Height = 30;
            this.Dgv_Statistic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Statistic.Size = new System.Drawing.Size(1086, 270);
            this.Dgv_Statistic.TabIndex = 43;
            // 
            // Txb_Search
            // 
            this.Txb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Search.Location = new System.Drawing.Point(900, 12);
            this.Txb_Search.Name = "Txb_Search";
            this.Txb_Search.Size = new System.Drawing.Size(198, 27);
            this.Txb_Search.TabIndex = 54;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(776, 7);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(106, 34);
            this.Btn_Search.TabIndex = 55;
            this.Btn_Search.Text = "Tìm";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Txb_Search);
            this.MainPanel.Controls.Add(this.Btn_Search);
            this.MainPanel.Controls.Add(this.DtpDateStart);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.DtpDateEnd);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.Btn_Statistic);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1110, 55);
            this.MainPanel.TabIndex = 56;
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.Location = new System.Drawing.Point(798, 337);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(106, 34);
            this.Btn_Close.TabIndex = 56;
            this.Btn_Close.Text = "Đóng";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // FormTradeHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1110, 675);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Btn_View);
            this.Controls.Add(this.Txb_TotalRevenue);
            this.Controls.Add(this.Lb_TotalRevenue);
            this.Controls.Add(this.Txb_TotalOrders);
            this.Controls.Add(this.Lb_TotalOrders);
            this.Controls.Add(this.Dgv_Statistic);
            this.MinimumSize = new System.Drawing.Size(1128, 722);
            this.Name = "FormTradeHistory";
            this.Text = "Lịch sử giao dịch";
            this.Load += new System.EventHandler(this.FormTradeHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_View;
        private System.Windows.Forms.TextBox Txb_TotalRevenue;
        private System.Windows.Forms.Label Lb_TotalRevenue;
        private System.Windows.Forms.TextBox Txb_TotalOrders;
        private System.Windows.Forms.Label Lb_TotalOrders;
        private System.Windows.Forms.Button Btn_Statistic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpDateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpDateStart;
        private System.Windows.Forms.DataGridView Dgv_Statistic;
        private System.Windows.Forms.TextBox Txb_Search;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Btn_Close;
    }
}