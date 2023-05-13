using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.BLL;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.View
{
    public partial class FormOrder : Form
    {
        private string ID_User;
        decimal? total = 0;
        private List<ViewOrderDetail> li = new List<ViewOrderDetail>();

        public FormOrder(string iD_User)
        {
            ID_User = iD_User;
            InitializeComponent();
            LoadCBBBrand();
            LoadCBBCategory();

            SetTxbIdOrder();
            ManageStaffBLL msb = new ManageStaffBLL();
            Lb_Name.Text = "Tên nhân viên: " + msb.GetStaffByID(ID_User).Name;

            LoadTheme();
        }

        
        public void SetTxbIdOrder()
        {
            ManageOrderBLL mob = new ManageOrderBLL();
            txb_IDOrder.Text = mob.SetIDOrder();
        }
        public void LoadCBBBrand()
        {
            ManageBrandBLL mbb = new ManageBrandBLL();
            cbb_Brand.Items.AddRange(mbb.getCBBBrand().ToArray());
        }

        public void LoadCBBCategory()
        {
            ManageCategoryBLL mcb = new ManageCategoryBLL();
            cbb_Category.Items.AddRange(mcb.getCBBCategory().ToArray());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lb_Time.Text = "Thời gian: " + DateTime.Now.ToLongTimeString();
            Lb_Date.Text = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Order_Load(object sender, EventArgs e)
        {
            ManageItemBLL mib = new ManageItemBLL();
            dgv_item.DataSource = mib.getAllItemDGV();
            
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatStyle = FlatStyle.Flat;
                }
            }
        }

        public void SetHeaderText()
        {
            dgv_order.Columns[0].HeaderText = "Mã sản phẩm";
            dgv_order.Columns[1].HeaderText = "Tên sản phẩm";
            dgv_order.Columns[2].HeaderText = "Số lượng";
            dgv_order.Columns[3].HeaderText = "Đơn giá";
            dgv_order.Columns[4].HeaderText = "Thành tiền";
        }
        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageItemBLL mib = new ManageItemBLL();
            txb_Price.Text = "";
            txb_Quantity.Text = "";
            txb_Discount.Text = "";
            txb_Amount.Text = "";

            dgv_item.DataSource = mib.getItemsBySearch(txb_NameItem.Text, cbb_Brand.Text, cbb_Category.Text);

        }

        private void dgv_item_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbb_Brand.TextChanged -= cbb_Category_TextChanged;
            cbb_Category.TextChanged -= cbb_Category_TextChanged;
            txb_NameItem.TextChanged -= cbb_Category_TextChanged;

            DataGridViewRow i = dgv_item.SelectedRows[0];
            txb_NameItem.Text = i.Cells["Tên sản phẩm"].Value.ToString();
            txb_Discount.Text = i.Cells["Khuyến mãi"].Value.ToString();
            cbb_Category.Text = i.Cells["Loại sản phẩm"].Value.ToString();
            cbb_Brand.Text = i.Cells["Hãng"].Value.ToString();
            txb_Price.Text = i.Cells["Giá bán"].Value.ToString();
            txb_Amount.Text = "";
            txb_Quantity.Text = "";

            cbb_Brand.TextChanged += cbb_Category_TextChanged;
            cbb_Category.TextChanged += cbb_Category_TextChanged;
            txb_NameItem.TextChanged += cbb_Category_TextChanged;

        }

        private void txb_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txb_Amount.Text = Convert.ToString(
                    Convert.ToDouble(txb_Price.Text)
                    * Convert.ToInt32(txb_Quantity.Text));
                lb_Note.Text = "*Note: Thõa mãn yêu cầu";
            }
            catch (System.FormatException)
            {
                txb_Amount.Text = "";
                lb_Note.Text = "*Note: Vui lòng nhập đúng định dạng của mục số lượng";
            }

        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            if (CheckEmptyInfor())
            {
                ViewOrderDetail temp = new ViewOrderDetail();
                if (dgv_item.SelectedRows.Count == 1)
                {

                    DataGridViewRow i = dgv_item.SelectedRows[0];
                    if (CheckQuantityItem(Convert.ToInt32(i.Cells["Số lượng"].Value.ToString())))
                    {
                        temp.ID_Item = i.Cells["Mã sản phẩm"].Value.ToString();
                        temp.Quantity = Convert.ToInt32(txb_Quantity.Text);
                        temp.NameItem = txb_NameItem.Text;
                        temp.UnitPrice = Convert.ToDecimal(i.Cells["Giá bán"].Value.ToString());
                        temp.AmountPrice = Convert.ToDecimal(txb_Amount.Text);

                        total += Convert.ToDecimal(temp.AmountPrice);
                        li.Add(temp);
                    }
                    else
                    {
                        MessageBox.Show("Số lượng máy không đủ để đáp ứng");
                    }

                }

                dgv_order.DataSource = null;
                dgv_order.DataSource = li;
                SetHeaderText();
                txb_Total.Text = Convert.ToString(total);
            }
        }
        public bool CheckQuantityItem(int quantity)
        {
            if (Convert.ToInt32(txb_Quantity.Text) > quantity)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckEmptyInfor()
        {
            if (txb_IDOrder.Text == ""
                || txb_NameCus.Text == ""
                || txb_Address.Text == ""
                || txb_Phone.Text == ""
                || txb_Quantity.Text == ""
                )
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddColumnOrderDetail()
        {
            dgv_order.Columns.Add("Mã sản phẩm", "Mã sản phẩm");
            dgv_order.Columns.Add("Tên sản phẩm", "Tên sản phẩm");
            dgv_order.Columns.Add("Số lượng", "Số lượng");
            dgv_order.Columns.Add("Đơn giá", "Đơn giá");
            dgv_order.Columns.Add("Thành Tiền", "Thành Tiền");
            dgv_order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cbb_Category_TextChanged(object sender, EventArgs e)
        {
            ManageItemBLL mib = new ManageItemBLL();
            txb_Price.Text = "";
            txb_Quantity.Text = "";
            txb_Discount.Text = "";
            txb_Amount.Text = "";

            dgv_item.DataSource = mib.getItemsBySearch(txb_NameItem.Text, cbb_Brand.Text, cbb_Category.Text);
        }

        public bool CheckSameOrder()
        {
            ManageOrderBLL mob = new ManageOrderBLL();
            return mob.CheckSameOrder(txb_IDOrder.Text);
        }

        private void btn_SaveOrder_Click(object sender, EventArgs e)
        {
            if (dgv_order.Rows.Count > 0)
            {

                if (CheckSameOrder() == false)
                {
                    //Lưu thông tin khách hàng
                    ManageCustomerBLL mcb = new ManageCustomerBLL();
                    if (mcb.CheckOldCustomerBLL(txb_IDCustomer.Text))
                    {

                    }
                    else
                    {
                        Customer temp = new Customer();
                        temp.Name = txb_NameCus.Text;
                        temp.Address = txb_Address.Text;
                        temp.Phone = txb_Phone.Text;
                        temp.DateOfBirth = Convert.ToDateTime(dtp_Birth.Text);
                        mcb.AddCustomerBLL(temp);
                    }


                    //Tạo hóa đơn
                    ManageOrderBLL mob = new ManageOrderBLL();

                    Customer temp2 = new Customer();
                    temp2 = mcb.GetCustomerByPhoneBLL(txb_Phone.Text);

                    Order or = new Order();
                    or.OrderID = txb_IDOrder.Text;
                    or.ID_Staff = ID_User;
                    or.ID_Customer = temp2.ID_Customer;
                    or.OrderDate = DateTime.Now;
                    mob.AddOrder(or);

                    //Tạo chi tiết hóa đơn và cập nhật lại số lượng máy trong item
                    ManageOrderDetailBLL modb = new ManageOrderDetailBLL();
                    ManageItemBLL mib = new ManageItemBLL();
                    foreach (DataGridViewRow i in dgv_order.Rows)
                    {
                        OrderDetail detail = new OrderDetail();
                        detail.ID_Order = txb_IDOrder.Text;
                        detail.ID_Item = i.Cells[0].Value.ToString();
                        detail.Quantity = Convert.ToInt32(i.Cells[2].Value.ToString());

                        //cập nhật lại số lượng máy trong csdl
                        mib.UpdateQuantityItem(i.Cells[0].Value.ToString(), -Convert.ToInt32(i.Cells[2].Value.ToString()));

                        detail.UnitPrice = Convert.ToDecimal(i.Cells[3].Value.ToString());
                        modb.AddOrderDetailBLL(detail);
                    }
                    MessageBox.Show("Lưu thành công");
                    LoadDGVItem();
                    dgv_order.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Lưu không thành công");
                }
            }
        }

        public void LoadDGVItem()
        {
            ManageItemBLL mib = new ManageItemBLL();

            dgv_item.DataSource = mib.getAllItemDGV();
        }
        private void txb_NameCus_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_order_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_order.SelectedRows.Count == 1)
            {
                DataGridViewRow i = dgv_order.SelectedRows[0];
                ViewOrderDetail temp = li.Find(p => p.ID_Item == i.Cells["ID_Item"].Value.ToString());
                total -= temp.AmountPrice;
                txb_Total.Text = Convert.ToString(total);
                li.Remove(temp);
                dgv_order.DataSource = null;
                dgv_order.DataSource = li;
            }
        }

        public void ResetAll()
        {
            SetTxbIdOrder();
            li.Clear();
            dgv_order.DataSource = null;
            txb_IDCustomer.Text = "";
            txb_NameCus.Text = "";
            txb_Phone.Text = "";
            txb_Address.Text = "";
            txb_Total.Text = "";
            txb_Quantity.Text = "";
            total = 0;
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        public void ResetTextBox(List<TextBox> li)
        {
            foreach (TextBox t in li)
            {
                t.Text = "";
            }
        }

        public void ResetCombobox(List<ComboBox> li)
        {
            foreach (ComboBox i in li)
            {
                i.Text = "";
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            ManageStaffBLL msb = new ManageStaffBLL();
            Staff s = msb.GetStaffByID(ID_User);
            FormReport fr = new FormReport(li, txb_Total.Text, txb_NameCus.Text, txb_Phone.Text, txb_Address.Text, s.Name, DateTime.Now, txb_IDOrder.Text);
            fr.Show();
        }

        private void txb_Phone_TextChanged(object sender, EventArgs e)
        {
            Customer temp = new Customer();
            ManageCustomerBLL mcb = new ManageCustomerBLL();
            temp = mcb.GetCustomerByPhoneBLL(txb_Phone.Text);
            if (temp != null)
            {
                txb_NameCus.Text = temp.Name;
                txb_IDCustomer.Text = Convert.ToString(temp.ID_Customer);
                txb_Address.Text = temp.Address;
                dtp_Birth.Text = Convert.ToString(temp.DateOfBirth);
            }
            else
            {

            }
        }

        private void cbb_Brand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
