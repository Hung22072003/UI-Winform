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
            this.Btn_Statistic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Statistic = new System.Windows.Forms.DataGridView();
            this.CbbYear = new System.Windows.Forms.ComboBox();
            this.PanelChart = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Statistic
            // 
            this.Btn_Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Statistic.Location = new System.Drawing.Point(272, 12);
            this.Btn_Statistic.Name = "Btn_Statistic";
            this.Btn_Statistic.Size = new System.Drawing.Size(106, 34);
            this.Btn_Statistic.TabIndex = 37;
            this.Btn_Statistic.Text = "Thống kê";
            this.Btn_Statistic.UseVisualStyleBackColor = true;
            this.Btn_Statistic.Click += new System.EventHandler(this.Btn_Statistic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Năm:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dgv_Statistic
            // 
            this.Dgv_Statistic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Statistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Statistic.Location = new System.Drawing.Point(12, 71);
            this.Dgv_Statistic.Name = "Dgv_Statistic";
            this.Dgv_Statistic.ReadOnly = true;
            this.Dgv_Statistic.RowHeadersWidth = 51;
            this.Dgv_Statistic.RowTemplate.Height = 24;
            this.Dgv_Statistic.Size = new System.Drawing.Size(1074, 277);
            this.Dgv_Statistic.TabIndex = 32;
            // 
            // CbbYear
            // 
            this.CbbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbYear.FormattingEnabled = true;
            this.CbbYear.Location = new System.Drawing.Point(97, 17);
            this.CbbYear.Name = "CbbYear";
            this.CbbYear.Size = new System.Drawing.Size(121, 26);
            this.CbbYear.TabIndex = 38;
            this.CbbYear.SelectedIndexChanged += new System.EventHandler(this.CbbYear_SelectedIndexChanged);
            // 
            // PanelChart
            // 
            this.PanelChart.Location = new System.Drawing.Point(12, 354);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1074, 350);
            this.PanelChart.TabIndex = 39;
            // 
            // RevenueYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 711);
            this.Controls.Add(this.Btn_Statistic);
            this.Controls.Add(this.CbbYear);
            this.Controls.Add(this.PanelChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Statistic);
            this.Name = "RevenueYearForm";
            this.Text = "RevenueYearForm";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Statistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Statistic;
        private System.Windows.Forms.ComboBox CbbYear;
        private System.Windows.Forms.Panel PanelChart;
    }
}