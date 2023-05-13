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
using UI_Winform.DTO;

namespace UI_Winform.View
{
    public partial class FormTradeHistory : Form
    {
        private string ID_User;
        public FormTradeHistory(string id_user)
        {
            InitializeComponent();
            ID_User = id_user;
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
        private void Btn_Statistic_Click(object sender, EventArgs e)
        {
            ManageOrderBLL mob = new ManageOrderBLL();

            DateTime startDate = new DateTime(DtpDateStart.Value.Year, DtpDateStart.Value.Month, DtpDateStart.Value.Day, 0, 0, 0);
            DateTime endDate = new DateTime(DtpDateEnd.Value.Year, DtpDateEnd.Value.Month, DtpDateEnd.Value.Day, 23, 59, 59);
            if (startDate > endDate)
            {
                MessageBox.Show("Vui lòng xem lại ngày");
            }
            else
            {
                Dgv_Statistic.DataSource = mob.getOrderstoDGV(startDate, endDate, ID_User);
                if (Dgv_Statistic.Rows.Count > 0 ) {
                    Lb_TotalOrders.Visible = true;
                    Txb_TotalOrders.Text = Dgv_Statistic.RowCount.ToString();
                    Lb_TotalRevenue.Visible = true;
                    decimal? total = 0;
                    foreach (DataGridViewRow i in Dgv_Statistic.Rows)
                    {
                        total += Convert.ToDecimal(i.Cells["Tổng tiền"].Value);
                    }
                    Txb_TotalRevenue.Text = total.ToString();
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ManageOrderBLL mob=  new ManageOrderBLL();
            Dgv_Statistic.DataSource = mob.getOrdersBySearch(Txb_Search.Text, ID_User);
            if (Dgv_Statistic.Rows.Count > 0)
            {
                Lb_TotalOrders.Visible = true;
                Txb_TotalOrders.Text = Dgv_Statistic.RowCount.ToString();
                Lb_TotalRevenue.Visible = true;
                decimal? total = 0;
                foreach (DataGridViewRow i in Dgv_Statistic.Rows)
                {
                    total += Convert.ToDecimal(i.Cells["Tổng tiền"].Value);
                }
                Txb_TotalRevenue.Text = total.ToString();
            }
        }

        private void FormTradeHistory_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            if (Dgv_Statistic.SelectedRows.Count == 1)
            {
                ManageOrderDetailBLL mobb = new ManageOrderDetailBLL();
                List<ViewOrderDetail> list = mobb.GetOrderDetailList(Dgv_Statistic.SelectedRows[0].Cells["Mã hóa đơn"].Value.ToString());
                decimal? total = 0;
                list.ForEach(p =>
                {
                    total += p.AmountPrice;
                });

                ManageOrderBLL mob = new ManageOrderBLL();
                Order o = mob.getOrderByID(Dgv_Statistic.SelectedRows[0].Cells["Mã hóa đơn"].Value.ToString());
                ManageCustomerBLL mcb = new ManageCustomerBLL();
                Customer customer = mcb.GetCustomerByID(o.ID_Customer);


                FormReport f = new FormReport(list, total.ToString(), customer.Name, customer.Phone, customer.Address, Dgv_Statistic.SelectedRows[0].Cells["Tên nhân viên"].Value.ToString(), o.OrderDate, o.OrderID);
                f.ShowDialog();
            }
        }
    }
}
