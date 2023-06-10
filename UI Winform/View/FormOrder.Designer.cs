namespace UI_Winform.View
{
    partial class FormOrder
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_Point = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_IDCustomer = new System.Windows.Forms.TextBox();
            this.PanelTime = new System.Windows.Forms.Panel();
            this.Lb_Date = new System.Windows.Forms.Label();
            this.Lb_Time = new System.Windows.Forms.Label();
            this.Lb_Name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_NameCus = new System.Windows.Forms.TextBox();
            this.txb_IDOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ApplyDiscount = new System.Windows.Forms.Button();
            this.txb_FinalTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_TotalDiscount = new System.Windows.Forms.TextBox();
            this.txb_IdVoucher = new System.Windows.Forms.TextBox();
            this.txb_BonusPoint = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_CancelOrder = new System.Windows.Forms.Button();
            this.btn_SaveOrder = new System.Windows.Forms.Button();
            this.txb_Total = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgv_order = new System.Windows.Forms.DataGridView();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ShowAllItem = new System.Windows.Forms.Button();
            this.lb_Note = new System.Windows.Forms.Label();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_NameItem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_Amount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txb_Discount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_Quantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbb_Brand = new System.Windows.Forms.ComboBox();
            this.cbb_Category = new System.Windows.Forms.ComboBox();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.PanelTime.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_Point);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txb_IDCustomer);
            this.groupBox1.Controls.Add(this.PanelTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txb_Phone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb_Address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_NameCus);
            this.groupBox1.Controls.Add(this.txb_IDOrder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1327, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txb_Point
            // 
            this.txb_Point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Point.Location = new System.Drawing.Point(592, 133);
            this.txb_Point.Name = "txb_Point";
            this.txb_Point.ReadOnly = true;
            this.txb_Point.Size = new System.Drawing.Size(215, 27);
            this.txb_Point.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 99;
            this.label8.Text = "Điểm tích lũy:";
            // 
            // txb_IDCustomer
            // 
            this.txb_IDCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_IDCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IDCustomer.Location = new System.Drawing.Point(592, 33);
            this.txb_IDCustomer.Name = "txb_IDCustomer";
            this.txb_IDCustomer.ReadOnly = true;
            this.txb_IDCustomer.Size = new System.Drawing.Size(215, 27);
            this.txb_IDCustomer.TabIndex = 98;
            // 
            // PanelTime
            // 
            this.PanelTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelTime.Controls.Add(this.Lb_Date);
            this.PanelTime.Controls.Add(this.Lb_Time);
            this.PanelTime.Controls.Add(this.Lb_Name);
            this.PanelTime.Location = new System.Drawing.Point(1029, 12);
            this.PanelTime.Name = "PanelTime";
            this.PanelTime.Size = new System.Drawing.Size(292, 135);
            this.PanelTime.TabIndex = 97;
            // 
            // Lb_Date
            // 
            this.Lb_Date.AutoSize = true;
            this.Lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Date.Location = new System.Drawing.Point(14, 90);
            this.Lb_Date.Name = "Lb_Date";
            this.Lb_Date.Size = new System.Drawing.Size(52, 20);
            this.Lb_Date.TabIndex = 2;
            this.Lb_Date.Text = "Ngày:";
            // 
            // Lb_Time
            // 
            this.Lb_Time.AutoSize = true;
            this.Lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Time.Location = new System.Drawing.Point(14, 52);
            this.Lb_Time.Name = "Lb_Time";
            this.Lb_Time.Size = new System.Drawing.Size(40, 20);
            this.Lb_Time.TabIndex = 1;
            this.Lb_Time.Text = "Giờ:";
            // 
            // Lb_Name
            // 
            this.Lb_Name.AutoSize = true;
            this.Lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Name.Location = new System.Drawing.Point(14, 16);
            this.Lb_Name.Name = "Lb_Name";
            this.Lb_Name.Size = new System.Drawing.Size(123, 20);
            this.Lb_Name.TabIndex = 0;
            this.Lb_Name.Text = "Tên nhân viên: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Mã khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Số điện thoại:";
            // 
            // txb_Phone
            // 
            this.txb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.Location = new System.Drawing.Point(165, 136);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(215, 27);
            this.txb_Phone.TabIndex = 50;
            this.txb_Phone.TextChanged += new System.EventHandler(this.txb_Phone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Địa chỉ:";
            // 
            // txb_Address
            // 
            this.txb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Address.Location = new System.Drawing.Point(592, 84);
            this.txb_Address.Name = "txb_Address";
            this.txb_Address.Size = new System.Drawing.Size(215, 27);
            this.txb_Address.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tên khách hàng:";
            // 
            // txb_NameCus
            // 
            this.txb_NameCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_NameCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NameCus.Location = new System.Drawing.Point(165, 84);
            this.txb_NameCus.Name = "txb_NameCus";
            this.txb_NameCus.Size = new System.Drawing.Size(215, 27);
            this.txb_NameCus.TabIndex = 46;
            this.txb_NameCus.TextChanged += new System.EventHandler(this.txb_NameCus_TextChanged);
            // 
            // txb_IDOrder
            // 
            this.txb_IDOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_IDOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IDOrder.Location = new System.Drawing.Point(165, 36);
            this.txb_IDOrder.Name = "txb_IDOrder";
            this.txb_IDOrder.ReadOnly = true;
            this.txb_IDOrder.Size = new System.Drawing.Size(215, 27);
            this.txb_IDOrder.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ApplyDiscount);
            this.groupBox2.Controls.Add(this.txb_FinalTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txb_TotalDiscount);
            this.groupBox2.Controls.Add(this.txb_IdVoucher);
            this.groupBox2.Controls.Add(this.txb_BonusPoint);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.btn_Print);
            this.groupBox2.Controls.Add(this.btn_CancelOrder);
            this.groupBox2.Controls.Add(this.btn_SaveOrder);
            this.groupBox2.Controls.Add(this.txb_Total);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dgv_order);
            this.groupBox2.Location = new System.Drawing.Point(10, 580);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1330, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // btn_ApplyDiscount
            // 
            this.btn_ApplyDiscount.AutoSize = true;
            this.btn_ApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ApplyDiscount.Location = new System.Drawing.Point(567, 298);
            this.btn_ApplyDiscount.Name = "btn_ApplyDiscount";
            this.btn_ApplyDiscount.Size = new System.Drawing.Size(124, 31);
            this.btn_ApplyDiscount.TabIndex = 111;
            this.btn_ApplyDiscount.Text = "Áp dụng giảm giá";
            this.btn_ApplyDiscount.UseVisualStyleBackColor = true;
            this.btn_ApplyDiscount.Click += new System.EventHandler(this.btn_ApplyDiscount_Click);
            // 
            // txb_FinalTotal
            // 
            this.txb_FinalTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_FinalTotal.Enabled = false;
            this.txb_FinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FinalTotal.Location = new System.Drawing.Point(1095, 298);
            this.txb_FinalTotal.Name = "txb_FinalTotal";
            this.txb_FinalTotal.Size = new System.Drawing.Size(215, 27);
            this.txb_FinalTotal.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(895, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 109;
            this.label1.Text = "Tổng tiền sau khi giảm:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 20);
            this.label18.TabIndex = 108;
            this.label18.Text = "Điểm tích lũy:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(321, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 107;
            this.label11.Text = "Mã Voucher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Tổng giảm:";
            // 
            // txb_TotalDiscount
            // 
            this.txb_TotalDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_TotalDiscount.Enabled = false;
            this.txb_TotalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_TotalDiscount.Location = new System.Drawing.Point(749, 230);
            this.txb_TotalDiscount.Name = "txb_TotalDiscount";
            this.txb_TotalDiscount.Size = new System.Drawing.Size(148, 27);
            this.txb_TotalDiscount.TabIndex = 105;
            this.txb_TotalDiscount.Text = "0";
            // 
            // txb_IdVoucher
            // 
            this.txb_IdVoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_IdVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_IdVoucher.Location = new System.Drawing.Point(439, 230);
            this.txb_IdVoucher.Name = "txb_IdVoucher";
            this.txb_IdVoucher.Size = new System.Drawing.Size(148, 27);
            this.txb_IdVoucher.TabIndex = 104;
            // 
            // txb_BonusPoint
            // 
            this.txb_BonusPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_BonusPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_BonusPoint.Location = new System.Drawing.Point(139, 230);
            this.txb_BonusPoint.Name = "txb_BonusPoint";
            this.txb_BonusPoint.Size = new System.Drawing.Size(148, 27);
            this.txb_BonusPoint.TabIndex = 103;
            this.txb_BonusPoint.Text = "0";
            this.txb_BonusPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_BonusPoint_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(9, 183);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(410, 16);
            this.label19.TabIndex = 93;
            this.label19.Text = "*Note: Nhấn đúp chuột vào một hàng để xóa sản phẩm khỏi hóa đơn";
            // 
            // btn_Print
            // 
            this.btn_Print.AutoSize = true;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Print.Location = new System.Drawing.Point(378, 298);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(106, 31);
            this.btn_Print.TabIndex = 77;
            this.btn_Print.Text = "In hóa đơn";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_CancelOrder
            // 
            this.btn_CancelOrder.AutoSize = true;
            this.btn_CancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelOrder.Location = new System.Drawing.Point(192, 298);
            this.btn_CancelOrder.Name = "btn_CancelOrder";
            this.btn_CancelOrder.Size = new System.Drawing.Size(106, 31);
            this.btn_CancelOrder.TabIndex = 76;
            this.btn_CancelOrder.Text = "Hủy hóa đơn";
            this.btn_CancelOrder.UseVisualStyleBackColor = true;
            this.btn_CancelOrder.Click += new System.EventHandler(this.btn_CancelOrder_Click);
            // 
            // btn_SaveOrder
            // 
            this.btn_SaveOrder.AutoSize = true;
            this.btn_SaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveOrder.Location = new System.Drawing.Point(12, 298);
            this.btn_SaveOrder.Name = "btn_SaveOrder";
            this.btn_SaveOrder.Size = new System.Drawing.Size(106, 31);
            this.btn_SaveOrder.TabIndex = 75;
            this.btn_SaveOrder.Text = "Lưu hóa đơn";
            this.btn_SaveOrder.UseVisualStyleBackColor = true;
            this.btn_SaveOrder.Click += new System.EventHandler(this.btn_SaveOrder_Click);
            // 
            // txb_Total
            // 
            this.txb_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Total.Enabled = false;
            this.txb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Total.Location = new System.Drawing.Point(1095, 230);
            this.txb_Total.Name = "txb_Total";
            this.txb_Total.Size = new System.Drawing.Size(215, 27);
            this.txb_Total.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(979, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 20);
            this.label15.TabIndex = 72;
            this.label15.Text = "Tổng tiền:";
            // 
            // dgv_order
            // 
            this.dgv_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_order.Location = new System.Drawing.Point(12, 21);
            this.dgv_order.Name = "dgv_order";
            this.dgv_order.ReadOnly = true;
            this.dgv_order.RowHeadersWidth = 51;
            this.dgv_order.RowTemplate.Height = 24;
            this.dgv_order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_order.Size = new System.Drawing.Size(1298, 150);
            this.dgv_order.TabIndex = 71;
            this.dgv_order.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_order_CellDoubleClick);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.AutoSize = true;
            this.btn_AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddItem.Location = new System.Drawing.Point(96, 316);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(213, 31);
            this.btn_AddItem.TabIndex = 74;
            this.btn_AddItem.Text = "Thêm sản phẩm vào hóa đơn";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ShowAllItem);
            this.groupBox3.Controls.Add(this.lb_Note);
            this.groupBox3.Controls.Add(this.txb_Price);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txb_NameItem);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txb_Amount);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txb_Discount);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btn_AddItem);
            this.groupBox3.Controls.Add(this.txb_Quantity);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cbb_Brand);
            this.groupBox3.Controls.Add(this.cbb_Category);
            this.groupBox3.Controls.Add(this.dgv_item);
            this.groupBox3.Location = new System.Drawing.Point(11, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1329, 368);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm";
            // 
            // btn_ShowAllItem
            // 
            this.btn_ShowAllItem.AutoSize = true;
            this.btn_ShowAllItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAllItem.Location = new System.Drawing.Point(593, 316);
            this.btn_ShowAllItem.Name = "btn_ShowAllItem";
            this.btn_ShowAllItem.Size = new System.Drawing.Size(173, 31);
            this.btn_ShowAllItem.TabIndex = 93;
            this.btn_ShowAllItem.Text = "Hiển thị toàn bộ sản phẩm";
            this.btn_ShowAllItem.UseVisualStyleBackColor = true;
            this.btn_ShowAllItem.Click += new System.EventHandler(this.btn_ShowAllItem_Click);
            // 
            // lb_Note
            // 
            this.lb_Note.AutoSize = true;
            this.lb_Note.ForeColor = System.Drawing.Color.Red;
            this.lb_Note.Location = new System.Drawing.Point(401, 121);
            this.lb_Note.Name = "lb_Note";
            this.lb_Note.Size = new System.Drawing.Size(330, 16);
            this.lb_Note.TabIndex = 92;
            this.lb_Note.Text = "*Note: Vui lòng nhập đúng định dạng của mục số lượng";
            // 
            // txb_Price
            // 
            this.txb_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Price.Enabled = false;
            this.txb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Price.Location = new System.Drawing.Point(152, 116);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(215, 27);
            this.txb_Price.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 90;
            this.label10.Text = "Giá:";
            // 
            // txb_NameItem
            // 
            this.txb_NameItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_NameItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NameItem.Location = new System.Drawing.Point(152, 18);
            this.txb_NameItem.Name = "txb_NameItem";
            this.txb_NameItem.Size = new System.Drawing.Size(215, 27);
            this.txb_NameItem.TabIndex = 89;
            this.txb_NameItem.TextChanged += new System.EventHandler(this.cbb_Category_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 88;
            this.label9.Text = "Tên sản phẩm:";
            // 
            // txb_Amount
            // 
            this.txb_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Amount.Enabled = false;
            this.txb_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Amount.Location = new System.Drawing.Point(898, 61);
            this.txb_Amount.Name = "txb_Amount";
            this.txb_Amount.Size = new System.Drawing.Size(215, 27);
            this.txb_Amount.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(783, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 86;
            this.label14.Text = "Thành tiền: ";
            // 
            // txb_Discount
            // 
            this.txb_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Discount.Enabled = false;
            this.txb_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Discount.Location = new System.Drawing.Point(541, 66);
            this.txb_Discount.Name = "txb_Discount";
            this.txb_Discount.Size = new System.Drawing.Size(215, 27);
            this.txb_Discount.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(400, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 84;
            this.label13.Text = "Giảm giá:";
            // 
            // txb_Quantity
            // 
            this.txb_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Quantity.Location = new System.Drawing.Point(152, 71);
            this.txb_Quantity.Name = "txb_Quantity";
            this.txb_Quantity.Size = new System.Drawing.Size(215, 27);
            this.txb_Quantity.TabIndex = 83;
            this.txb_Quantity.TextChanged += new System.EventHandler(this.txb_Quantity_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 82;
            this.label12.Text = "Số lượng:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(783, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 20);
            this.label17.TabIndex = 81;
            this.label17.Text = "Hãng: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(400, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 20);
            this.label16.TabIndex = 79;
            this.label16.Text = "Loại sản phẩm:";
            // 
            // cbb_Brand
            // 
            this.cbb_Brand.FormattingEnabled = true;
            this.cbb_Brand.Location = new System.Drawing.Point(898, 21);
            this.cbb_Brand.Name = "cbb_Brand";
            this.cbb_Brand.Size = new System.Drawing.Size(215, 24);
            this.cbb_Brand.TabIndex = 80;
            this.cbb_Brand.TextChanged += new System.EventHandler(this.cbb_Category_TextChanged);
            // 
            // cbb_Category
            // 
            this.cbb_Category.FormattingEnabled = true;
            this.cbb_Category.Location = new System.Drawing.Point(541, 21);
            this.cbb_Category.Name = "cbb_Category";
            this.cbb_Category.Size = new System.Drawing.Size(215, 24);
            this.cbb_Category.TabIndex = 79;
            this.cbb_Category.TextChanged += new System.EventHandler(this.cbb_Category_TextChanged);
            // 
            // dgv_item
            // 
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(12, 149);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.ReadOnly = true;
            this.dgv_item.RowHeadersWidth = 51;
            this.dgv_item.RowTemplate.Height = 24;
            this.dgv_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_item.Size = new System.Drawing.Size(1297, 150);
            this.dgv_item.TabIndex = 79;
            this.dgv_item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellClick);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1393, 965);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrder";
            this.Text = "Tạo hóa đơn";
            this.Load += new System.EventHandler(this.Order_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelTime.ResumeLayout(false);
            this.PanelTime.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_order)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_IDOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_NameCus;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_order;
        private System.Windows.Forms.TextBox txb_Total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_CancelOrder;
        private System.Windows.Forms.Button btn_SaveOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbb_Brand;
        private System.Windows.Forms.ComboBox cbb_Category;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.TextBox txb_Amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txb_Discount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_Quantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_NameItem;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_Note;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel PanelTime;
        private System.Windows.Forms.Label Lb_Date;
        private System.Windows.Forms.Label Lb_Time;
        private System.Windows.Forms.Label Lb_Name;
        private System.Windows.Forms.TextBox txb_IDCustomer;
        private System.Windows.Forms.Button btn_ApplyDiscount;
        private System.Windows.Forms.TextBox txb_FinalTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_TotalDiscount;
        private System.Windows.Forms.TextBox txb_IdVoucher;
        private System.Windows.Forms.TextBox txb_BonusPoint;
        private System.Windows.Forms.TextBox txb_Point;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_ShowAllItem;
    }
}