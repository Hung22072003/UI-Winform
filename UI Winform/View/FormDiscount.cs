using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FormDiscount : Form
    {
        private Form activeForm;
        public FormDiscount()
        {
            InitializeComponent();
            LoadDGV();
        }

        private void FormDiscount_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatStyle = FlatStyle.Flat;
                }
            }
        }

        public void LoadDGV()
        {
            ManageVoucherBLL mvb = new ManageVoucherBLL();
            dgv_Voucher.DataSource = mvb.GetAllVoucherBLL();
        }

        private void btn_ShowALL_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        public void ResetTextBox()
        {
            txb_Quantity.Text = txb_MaxDiscount.Text = txb_MinTotal.Text = Txb_Discount.Text = "";
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ManageVoucherBLL mvb = new ManageVoucherBLL();
            dgv_Voucher.DataSource = mvb.GetAllVoucherBLL(Convert.ToDateTime(dtp_DateSearch.Text));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ManageVoucherBLL mvb = new ManageVoucherBLL();
            Voucher v = new Voucher();
            if (mvb.CheckEmptyInfor(txb_Quantity.Text, txb_MaxDiscount.Text, txb_MinTotal.Text, Txb_Discount.Text))
            {
                v.ID_Voucher = mvb.GenerateRandomString();
                v.Discount = Convert.ToDouble(Txb_Discount.Text);
                v.StartDate = Convert.ToDateTime(dtp_FromDate.Text);
                v.EndDate = Convert.ToDateTime(dtp_EndDate.Text);
                v.MinTotal = Convert.ToDecimal(txb_MinTotal.Text);
                v.Tick = true;
                v.MaxDiscount = Convert.ToDouble(txb_MaxDiscount.Text);

                mvb.AddVoucherBLL(v, Convert.ToInt32(txb_Quantity.Text));
                dgv_Voucher.DataSource = mvb.GetListNewVoucher();
                ResetTextBox();
            }
        }

        private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b') // Kiểm tra nếu kí tự không phải là số
            {
                e.Handled = true; // Hủy bỏ kí tự đó
            }
        }
    }
}
