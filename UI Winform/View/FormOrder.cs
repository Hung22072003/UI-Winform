using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            txb_TotalDiscount.Text = "0";

            SetTxbIdOrder();
            ManageStaffBLL msb = new ManageStaffBLL();
            Lb_Name.Text = "Tên nhân viên: " + msb.GetStaffByID(ID_User).Name;
            
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
            LoadTheme();
            ManageItemBLL mib = new ManageItemBLL();
            dgv_item.DataSource = mib.getAllItemDGV();
        }

        private void LoadTheme()
        {
            foreach(Control btns in this.Controls)
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
                txb_Amount.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", (
                    Convert.ToDouble(txb_Price.Text.Replace(".", ""))
                    * Convert.ToInt32(txb_Quantity.Text)));
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
            ManageOrderBLL mob = new ManageOrderBLL();
            if (mob.CheckEmptyInfor(txb_IDOrder.Text, txb_NameCus.Text, txb_Address.Text, txb_Phone.Text, txb_Quantity.Text))
            {
                ViewOrderDetail temp = new ViewOrderDetail();
                if (dgv_item.SelectedRows.Count == 1)
                {

                    DataGridViewRow i = dgv_item.SelectedRows[0];
                    if (mob.CheckQuantityItem(Convert.ToInt32(i.Cells["Số lượng"].Value.ToString()),txb_Quantity.Text))
                    {
                        temp.ID_Item = i.Cells["Mã sản phẩm"].Value.ToString();
                        temp.Quantity = Convert.ToInt32(txb_Quantity.Text);
                        temp.NameItem = txb_NameItem.Text;
                        temp.UnitPrice = txb_Price.Text;
                        temp.AmountPrice = txb_Amount.Text;

                        total += Convert.ToDecimal(temp.AmountPrice.Replace(".",""));
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
                txb_Total.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", total);
                txb_FinalTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", total);
            }
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
                    ManageVoucherBLL mvb = new ManageVoucherBLL();
                    if (mcb.CheckOldCustomerBLL(txb_IDCustomer.Text))
                    {
                        //cap nhat lai diem tich luy trong khach hang
                        mcb.UpdateBonusPointCustomerBLL(txb_Total.Text, Convert.ToInt32(txb_IDCustomer.Text));
                        mcb.UpdateBonusPointCustomerBLL(mvb.CheckBonusPointBLL(txb_BonusPoint.Text), Convert.ToInt32(txb_IDCustomer.Text));
                    }
                    else
                    {
                        Customer temp = new Customer();
                        temp.Name = txb_NameCus.Text;
                        temp.Address = txb_Address.Text;
                        temp.Phone = txb_Phone.Text;
                        temp.BonusPoint = 0;

                        mcb.AddCustomerBLL(temp);
                        mcb.UpdateBonusPointCustomerBLL(txb_Total.Text, mcb.GetCustomerByPhoneBLL(txb_Phone.Text).ID_Customer);

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
                    or.BonusPoint = mob.CheckBonusPointBLL(txb_BonusPoint.Text);
                    or.ID_Voucher = mob.CheckIDVoucher(txb_IdVoucher.Text);
                    mvb.SetVoucherBeingUsedBLL(txb_IdVoucher.Text);
                    or.TotalDiscount = mob.CheckTotalDiscountBLL(txb_TotalDiscount.Text);
                    or.TotalPrice = Convert.ToDecimal(txb_Total.Text.Replace(".", ""));
                    or.FinalTotal = Convert.ToDecimal(txb_FinalTotal.Text.Replace(".", ""));
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

                        detail.UnitPrice = Convert.ToDecimal(i.Cells[3].Value.ToString().Replace(".", ""));
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
                total -= Convert.ToDecimal(temp.AmountPrice.Replace(".", ""));
                txb_Total.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", total);
                txb_FinalTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", total);
                txb_IdVoucher.Text = "";
                txb_BonusPoint.Text = "";
                txb_TotalDiscount.Text = "";
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
            txb_Discount.Text = "";
            txb_IdVoucher.Text = "";
            txb_BonusPoint.Text = "";
            txb_FinalTotal.Text = "";
            txb_TotalDiscount.Text = "";
            txb_Point.Text = "";
            total = 0;
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            ManageOrderBLL mob = new ManageOrderBLL();
            if (mob.CheckEmptyInfor(txb_IDOrder.Text, txb_NameCus.Text, txb_Address.Text, txb_Phone.Text, txb_Quantity.Text))
            {
                ManageStaffBLL msb = new ManageStaffBLL();
                Staff s = msb.GetStaffByID(ID_User);
                FormReport fr = new FormReport(li, txb_Total.Text, txb_NameCus.Text, txb_Phone.Text, txb_Address.Text, s.Name, txb_TotalDiscount.Text, txb_FinalTotal.Text, DateTime.Now, txb_IDOrder.Text);
                fr.Show();
            }
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
                txb_Point.Text = temp.BonusPoint.ToString();
            }
            if(txb_Phone.Text == "")
            {
                txb_IDCustomer.Text = "";
                txb_Point.Text = "";
                txb_NameCus.Text = "";
                txb_Address.Text = "";
            }
        }

        private void btn_ApplyDiscount_Click(object sender, EventArgs e)
        {
            ManageCustomerBLL mcb = new ManageCustomerBLL();
            ManageVoucherBLL mvb = new ManageVoucherBLL();
            ManageOrderBLL mob = new ManageOrderBLL();
            if (mob.CheckEmptyInfor(txb_IDOrder.Text, txb_NameCus.Text, txb_Address.Text, txb_Phone.Text, txb_Quantity.Text))
            {

                if (mcb.CheckOldCustomerBLL(txb_IDCustomer.Text))
                {
                    Customer cus = mcb.GetCustomerByID(Convert.ToInt32(txb_IDCustomer.Text));

                    if (txb_BonusPoint.Text != "")
                    {
                        if (cus.BonusPoint < Convert.ToInt32(txb_BonusPoint.Text))
                        {
                            MessageBox.Show("Điểm của khách hàng không đủ");
                            txb_BonusPoint.Text = "0";
                        }
                        if (Convert.ToInt32(txb_BonusPoint.Text) > mob.CheckLimitBonusPoint(Convert.ToDecimal(txb_Total.Text.Replace(".", ""))))
                        {
                            MessageBox.Show("Chỉ được áp dụng tối đa " + mob.CheckLimitBonusPoint(Convert.ToDecimal(txb_Total.Text.Replace(".", ""))).ToString() + " điểm đối với hóa đơn hiện tại");
                            txb_BonusPoint.Text = "0";
                        };
                    }
                }
                else
                {
                    txb_BonusPoint.Text = "";
                    txb_BonusPoint.Enabled = false;
                }


                if (txb_IdVoucher.Text != "")
                {
                    Voucher vc = mvb.GetVoucherByID(txb_IdVoucher.Text, Convert.ToDecimal(txb_Total.Text.Replace(".", "")));
                    if (vc == null)
                    {
                        txb_TotalDiscount.Text = mob.CheckDiscount_Voucher(0, txb_BonusPoint.Text, txb_IdVoucher.Text);
                        txb_IdVoucher.Text = "";
                    }
                    else
                    {
                        if (mvb.CheckStatusVoucherBLL(vc.ID_Voucher))
                        {
                            double total = Convert.ToDouble(txb_Total.Text.Replace(".", ""));
                            if (mvb.CheckMaxDiscount((double)(total * vc.Discount), vc.ID_Voucher) == false)
                            {
                                txb_TotalDiscount.Text = mob.CheckDiscount_Voucher(Convert.ToDouble(vc.Discount), txb_BonusPoint.Text, txb_IdVoucher.Text);
                                txb_FinalTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", (Convert.ToDouble(txb_Total.Text.Replace(".", "")) * (1 - Convert.ToDouble(txb_TotalDiscount.Text))));
                            }
                            else
                            {
                                txb_TotalDiscount.Text = mob.CheckDiscount_Voucher(Convert.ToDouble(vc.Discount), txb_BonusPoint.Text, txb_IdVoucher.Text);

                                txb_FinalTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", (Convert.ToDouble(txb_Total.Text.Replace(".", "")) * (1 + Convert.ToDouble(mvb.CheckBonusPointBLL(txb_BonusPoint.Text)) / 1000000000) - vc.MaxDiscount));
                                MessageBox.Show("Voucher được giảm tối đa " + vc.MaxDiscount.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }


                        }
                        else
                        {
                            MessageBox.Show("Voucher đã có người sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txb_IdVoucher.Text = "";
                        }

                    }
                }
                else
                {
                    txb_TotalDiscount.Text = mob.CheckDiscount_Voucher(0, txb_BonusPoint.Text, txb_IdVoucher.Text);
                    txb_FinalTotal.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", (Convert.ToDouble(txb_Total.Text.Replace(".", "")) * (1 + Convert.ToDouble(mvb.CheckBonusPointBLL(txb_BonusPoint.Text)) / 1000000000)));
                }
            }
        }


        private void txb_BonusPoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') // Kiểm tra nếu kí tự không phải là số
            {
                e.Handled = true; // Hủy bỏ kí tự đó
            }
        }

        private void btn_ShowAllItem_Click(object sender, EventArgs e)
        {
            LoadDGVItem();
        }
    }
}
