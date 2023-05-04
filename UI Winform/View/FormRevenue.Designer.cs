namespace UI_Winform.View
{
    partial class FormRevenue
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
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Cbb_Choice = new System.Windows.Forms.ComboBox();
            this.Lb_Title = new System.Windows.Forms.Label();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Btn_OK);
            this.MainPanel.Controls.Add(this.Cbb_Choice);
            this.MainPanel.Controls.Add(this.Lb_Title);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1082, 85);
            this.MainPanel.TabIndex = 0;
            // 
            // Btn_OK
            // 
            this.Btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_OK.Location = new System.Drawing.Point(363, 21);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(106, 34);
            this.Btn_OK.TabIndex = 2;
            this.Btn_OK.Text = "Xác nhận";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Cbb_Choice
            // 
            this.Cbb_Choice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Choice.FormattingEnabled = true;
            this.Cbb_Choice.Items.AddRange(new object[] {
            "Khoảng thời gian",
            "Năm"});
            this.Cbb_Choice.Location = new System.Drawing.Point(155, 26);
            this.Cbb_Choice.Name = "Cbb_Choice";
            this.Cbb_Choice.Size = new System.Drawing.Size(166, 26);
            this.Cbb_Choice.TabIndex = 1;
            // 
            // Lb_Title
            // 
            this.Lb_Title.AutoSize = true;
            this.Lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Title.Location = new System.Drawing.Point(12, 28);
            this.Lb_Title.Name = "Lb_Title";
            this.Lb_Title.Size = new System.Drawing.Size(119, 20);
            this.Lb_Title.TabIndex = 0;
            this.Lb_Title.Text = "Thống kê theo:";
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 85);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(1082, 548);
            this.ChildPanel.TabIndex = 1;
            // 
            // FormRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 633);
            this.Controls.Add(this.ChildPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "FormRevenue";
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.FormRevenue_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.ComboBox Cbb_Choice;
        private System.Windows.Forms.Label Lb_Title;
        private System.Windows.Forms.Panel ChildPanel;
    }
}