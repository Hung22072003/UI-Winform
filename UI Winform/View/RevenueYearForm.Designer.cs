namespace UI_Winform.View
{
    partial class RevenueYearForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Dgv_Statistic = new System.Windows.Forms.DataGridView();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Txb_Search = new System.Windows.Forms.TextBox();
            this.Btn_View = new System.Windows.Forms.Button();
            this.Txb_TotalRevenue = new System.Windows.Forms.TextBox();
            this.Lb_TotalRevenue = new System.Windows.Forms.Label();
            this.Txb_TotalOrders = new System.Windows.Forms.TextBox();
            this.Lb_TotalOrders = new System.Windows.Forms.Label();
            this.Btn_Statistic = new System.Windows.Forms.Button();
            this.CbbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Dgv_Statistic);
            this.MainPanel.Controls.Add(this.Btn_Search);
            this.MainPanel.Controls.Add(this.Txb_Search);
            this.MainPanel.Controls.Add(this.Btn_View);
            this.MainPanel.Controls.Add(this.Txb_TotalRevenue);
            this.MainPanel.Controls.Add(this.Lb_TotalRevenue);
            this.MainPanel.Controls.Add(this.Txb_TotalOrders);
            this.MainPanel.Controls.Add(this.Lb_TotalOrders);
            this.MainPanel.Controls.Add(this.Btn_Statistic);
            this.MainPanel.Controls.Add(this.CbbYear);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1108, 410);
            this.MainPanel.TabIndex = 0;
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
            this.Dgv_Statistic.Location = new System.Drawing.Point(16, 70);
            this.Dgv_Statistic.Name = "Dgv_Statistic";
            this.Dgv_Statistic.ReadOnly = true;
            this.Dgv_Statistic.RowHeadersWidth = 51;
            this.Dgv_Statistic.RowTemplate.Height = 30;
            this.Dgv_Statistic.Size = new System.Drawing.Size(1080, 270);
            this.Dgv_Statistic.TabIndex = 60;
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Search.Location = new System.Drawing.Point(771, 14);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(106, 34);
            this.Btn_Search.TabIndex = 59;
            this.Btn_Search.Text = "Tìm";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txb_Search
            // 
            this.Txb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_Search.Location = new System.Drawing.Point(895, 16);
            this.Txb_Search.Name = "Txb_Search";
            this.Txb_Search.Size = new System.Drawing.Size(198, 27);
            this.Txb_Search.TabIndex = 58;
            // 
            // Btn_View
            // 
            this.Btn_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_View.Location = new System.Drawing.Point(955, 361);
            this.Btn_View.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.Size = new System.Drawing.Size(138, 34);
            this.Btn_View.TabIndex = 47;
            this.Btn_View.Text = "Xem chi tiết";
            this.Btn_View.UseVisualStyleBackColor = true;
            this.Btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // Txb_TotalRevenue
            // 
            this.Txb_TotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_TotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_TotalRevenue.Location = new System.Drawing.Point(533, 368);
            this.Txb_TotalRevenue.Name = "Txb_TotalRevenue";
            this.Txb_TotalRevenue.ReadOnly = true;
            this.Txb_TotalRevenue.Size = new System.Drawing.Size(177, 20);
            this.Txb_TotalRevenue.TabIndex = 46;
            // 
            // Lb_TotalRevenue
            // 
            this.Lb_TotalRevenue.AutoSize = true;
            this.Lb_TotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TotalRevenue.Location = new System.Drawing.Point(383, 368);
            this.Lb_TotalRevenue.Name = "Lb_TotalRevenue";
            this.Lb_TotalRevenue.Size = new System.Drawing.Size(129, 20);
            this.Lb_TotalRevenue.TabIndex = 45;
            this.Lb_TotalRevenue.Text = "Tổng doanh thu:";
            this.Lb_TotalRevenue.Visible = false;
            // 
            // Txb_TotalOrders
            // 
            this.Txb_TotalOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txb_TotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txb_TotalOrders.Location = new System.Drawing.Point(150, 371);
            this.Txb_TotalOrders.Name = "Txb_TotalOrders";
            this.Txb_TotalOrders.ReadOnly = true;
            this.Txb_TotalOrders.Size = new System.Drawing.Size(100, 20);
            this.Txb_TotalOrders.TabIndex = 44;
            // 
            // Lb_TotalOrders
            // 
            this.Lb_TotalOrders.AutoSize = true;
            this.Lb_TotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_TotalOrders.Location = new System.Drawing.Point(14, 371);
            this.Lb_TotalOrders.Name = "Lb_TotalOrders";
            this.Lb_TotalOrders.Size = new System.Drawing.Size(115, 20);
            this.Lb_TotalOrders.TabIndex = 43;
            this.Lb_TotalOrders.Text = "Tổng hóa đơn:";
            this.Lb_TotalOrders.Visible = false;
            // 
            // Btn_Statistic
            // 
            this.Btn_Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Statistic.Location = new System.Drawing.Point(246, 16);
            this.Btn_Statistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Statistic.Name = "Btn_Statistic";
            this.Btn_Statistic.Size = new System.Drawing.Size(107, 34);
            this.Btn_Statistic.TabIndex = 41;
            this.Btn_Statistic.Text = "Thống kê";
            this.Btn_Statistic.UseVisualStyleBackColor = true;
            this.Btn_Statistic.Click += new System.EventHandler(this.Btn_Statistic_Click);
            // 
            // CbbYear
            // 
            this.CbbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbYear.FormattingEnabled = true;
            this.CbbYear.Location = new System.Drawing.Point(81, 21);
            this.CbbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbbYear.Name = "CbbYear";
            this.CbbYear.Size = new System.Drawing.Size(121, 26);
            this.CbbYear.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Năm:";
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 410);
            this.ChildPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(1108, 391);
            this.ChildPanel.TabIndex = 1;
            // 
            // RevenueYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1108, 801);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RevenueYearForm";
            this.Text = "RevenueYearForm";
            this.Load += new System.EventHandler(this.RevenueYearForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Btn_Statistic;
        private System.Windows.Forms.ComboBox CbbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.TextBox Txb_TotalRevenue;
        private System.Windows.Forms.Label Lb_TotalRevenue;
        private System.Windows.Forms.TextBox Txb_TotalOrders;
        private System.Windows.Forms.Label Lb_TotalOrders;
        private System.Windows.Forms.Button Btn_View;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Txb_Search;
        private System.Windows.Forms.DataGridView Dgv_Statistic;
    }
}