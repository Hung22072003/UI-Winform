﻿namespace UI_Winform
{
    partial class Btn_Report
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
            this.Btn_Statistic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.Dgv_Statistic = new System.Windows.Forms.DataGridView();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Btn_Statistic);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.DtpDateEnd);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.DtpDateStart);
            this.MainPanel.Controls.Add(this.Dgv_Statistic);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1082, 337);
            this.MainPanel.TabIndex = 0;
            // 
            // Btn_Statistic
            // 
            this.Btn_Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Statistic.Location = new System.Drawing.Point(601, 12);
            this.Btn_Statistic.Name = "Btn_Statistic";
            this.Btn_Statistic.Size = new System.Drawing.Size(106, 34);
            this.Btn_Statistic.TabIndex = 43;
            this.Btn_Statistic.Text = "Thống kê";
            this.Btn_Statistic.UseVisualStyleBackColor = true;
            this.Btn_Statistic.Click += new System.EventHandler(this.Btn_Statistic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "đến";
            // 
            // DtpDateEnd
            // 
            this.DtpDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateEnd.Location = new System.Drawing.Point(384, 14);
            this.DtpDateEnd.Name = "DtpDateEnd";
            this.DtpDateEnd.Size = new System.Drawing.Size(142, 27);
            this.DtpDateEnd.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thống kê từ:";
            // 
            // DtpDateStart
            // 
            this.DtpDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDateStart.Location = new System.Drawing.Point(129, 14);
            this.DtpDateStart.Name = "DtpDateStart";
            this.DtpDateStart.Size = new System.Drawing.Size(142, 27);
            this.DtpDateStart.TabIndex = 39;
            // 
            // Dgv_Statistic
            // 
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
            this.Dgv_Statistic.Location = new System.Drawing.Point(15, 64);
            this.Dgv_Statistic.Name = "Dgv_Statistic";
            this.Dgv_Statistic.ReadOnly = true;
            this.Dgv_Statistic.RowHeadersWidth = 51;
            this.Dgv_Statistic.RowTemplate.Height = 30;
            this.Dgv_Statistic.Size = new System.Drawing.Size(1055, 270);
            this.Dgv_Statistic.TabIndex = 38;
            // 
            // Btn_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 633);
            this.Controls.Add(this.MainPanel);
            this.Name = "Btn_Report";
            this.Text = "Quản lý chi tiêu";
            this.Load += new System.EventHandler(this.FormExpenditure_Load);
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
    }
}