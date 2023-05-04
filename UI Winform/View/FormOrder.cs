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
            LoadCBBIDCustomer();

            SetTxbIdOrder();
            ManageStaffBLL msb = new ManageStaffBLL();
            Lb_Name.Text = "Tên nhân viên: " + msb.GetStaffByID(ID_User).Name;

            rbtn_OldCustomer.Checked = true;
            
            //LoadNameItem();
            //LoadIDItem();
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

        public void LoadCBBIDCustomer()
        {
            ManageCustomerBLL mcb = new ManageCustomerBLL();
            foreach (Customer i in mcb.GetAllCustomerBLL())
            {
                cbb_IDCus.Items.Add(i.ID_Customer);
            }
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
            //AddColumnOrderDetail();
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
            cbb_Brand.SelectedIndexChanged -= cbb_Category_SelectedIndexChanged;
            cbb_Category.SelectedIndexChanged -= cbb_Category_SelectedIndexChanged;
            txb_NameItem.TextChanged -= cbb_Category_SelectedIndexChanged;

            DataGridViewRow i = dgv_item.SelectedRows[0];
            txb_NameItem.Text = i.Cells["Tên sản phẩm"].Value.ToString();
            txb_Discount.Text = i.Cells["Khuyến mãi"].Value.ToString();
            cbb_Category.Text = i.Cells["Loại sản phẩm"].Value.ToString();
            cbb_Brand.Text = i.Cells["Hãng"].Value.ToString();
            txb_Price.Text = i.Cells["Giá bán"].Value.ToString();
            txb_Amount.Text = "";
            txb_Quantity.Text = "";

            cbb_Brand.SelectedIndexChanged += cbb_Category_SelectedIndexChanged;
            cbb_Category.SelectedIndexChanged += cbb_Category_SelectedIndexChanged;
            txb_NameItem.TextChanged += cbb_Category_SelectedIndexChanged;
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
                    temp.ID_Item = i.Cells["Mã sản phẩm"].Value.ToString();
                    temp.Quantity = Convert.ToInt32(txb_Quantity.Text);
                    temp.NameItem = txb_NameItem.Text;
                    temp.UnitPrice = Convert.ToDecimal(i.Cells["Giá bán"].Value.ToString());
                    temp.AmountPrice = Convert.ToDecimal(txb_Amount.Text);

                    total += Convert.ToDecimal(temp.AmountPrice);
                }
                li.Add(temp);
                dgv_order.DataSource = null;
                dgv_order.DataSource = li;
                txb_Total.Text = Convert.ToString(total);
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
            dgv_order.Columns.Add("ID_Item", "Mã sản phẩm");
            dgv_order.Columns.Add("NameItem", "Tên sản phẩm");
            dgv_order.Columns.Add("Quantity", "Số lượng");
            dgv_order.Columns.Add("UnitPrice", "Đơn giá");
            dgv_order.Columns.Add("AmountPrice", "Thành Tiền");
            dgv_order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void cbb_IDCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageCustomerBLL mcb = new ManageCustomerBLL();

            Customer temp = mcb.GetCustomerByID(Convert.ToInt32(cbb_IDCus.Text));
            txb_NameCus.Text = temp.Name;
            txb_Address.Text = temp.Address;
            txb_Phone.Text = temp.Phone;
            dtp_Birth.Text = Convert.ToString(temp.DateOfBirth);

        }

        private void btn_SaveOrder_Click(object sender, EventArgs e)
        {
            if(dgv_order.Rows.Count > 0)
            {
                //Lưu thông tin khách hàng

                ManageCustomerBLL mcb = new ManageCustomerBLL();
                if (mcb.CheckOldCustomerBLL(cbb_IDCus.Text))
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

                //Tạo chi tiết hóa đơn
                ManageOrderDetailBLL modb = new ManageOrderDetailBLL();
                foreach (DataGridViewRow i in dgv_order.Rows)
                {

                    OrderDetail detail = new OrderDetail();
                    detail.ID_Order = txb_IDOrder.Text;
                    detail.ID_Item = i.Cells[0].Value.ToString();
                    detail.Quantity = Convert.ToInt32(i.Cells[2].Value.ToString());
                    detail.UnitPrice = Convert.ToDecimal(i.Cells[3].Value.ToString());
                    modb.AddOrderDetailBLL(detail);
                }
                MessageBox.Show("Lưu thành công");
            }
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

        private void rbtn_OldCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_NewCustomer.Checked == true)
            {
                cbb_IDCus.Enabled = false;
                rbtn_OldCustomer.Checked = false;
            }
            else
            {
                cbb_IDCus.Enabled = true;
                rbtn_OldCustomer.Checked = true;
            }
        }

        public void ResetAll()
        {
            SetTxbIdOrder();
            li.Clear();
            dgv_order.DataSource = null;
            cbb_IDCus.Text = "";
            txb_NameCus.Text = "";
            txb_Phone.Text = "";
            txb_Address.Text = "";
            txb_Total.Text = "";
            txb_Quantity.Text = "";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
            FormReport fr = new FormReport(li, txb_Total.Text, txb_NameCus.Text, txb_Phone.Text, txb_Address.Text, s.Name, DateTime.Now);
            fr.Show();
        }
    }
}
