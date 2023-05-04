using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UI_Winform.BLL;
using UI_Winform.DAL;
using UI_Winform.DTO;
using UI_Winform.View;

namespace UI_Winform
{
    public partial class RevenueTimeForm : Form
    {
        public RevenueTimeForm()
        {
            InitializeComponent();
        }


        private void RevenueTimeForm_Load(object sender, EventArgs e)
        {
            LoadTheme();

        }
        private void LoadTheme()
        {
            foreach (Control btns in MainPanel.Controls)
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
        private void Btn_Statistic_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(DtpDateStart.Value.Year, DtpDateStart.Value.Month, DtpDateStart.Value.Day, 0, 0, 0);
            DateTime endDate = new DateTime(DtpDateEnd.Value.Year, DtpDateEnd.Value.Month, DtpDateEnd.Value.Day, 23, 59, 59);
            if (startDate > endDate)
            {
                MessageBox.Show("Vui lòng xem lại ngày");
            }
            else
            {
                ManageRevenueBLL mrb = new ManageRevenueBLL();
                Dgv_Statistic.DataSource = mrb.getOrderToDRV(startDate, endDate);
                if (Dgv_Statistic.Rows.Count > 1)
                {
                    PanelChart.Controls.Clear();
                    Chart chartRevenue = new Chart();
                    chartRevenue.ChartAreas.Add(new ChartArea("Doanh thu theo sản phẩm"));
                    Series seri = new Series();
                    seri.Name = "Sản phẩm";
                    seri.ChartType = SeriesChartType.Column;
                    seri.ChartArea = "Doanh thu theo sản phẩm";
                    seri.Palette = ChartColorPalette.BrightPastel;
                    chartRevenue.Series.Clear();
                    chartRevenue.Series.Add(seri);
                    chartRevenue.DataSource = mrb.getRevenueOfCategory(startDate, endDate);
                    chartRevenue.Series["Sản phẩm"].XValueMember = "Tên sản phẩm";
                    chartRevenue.Series["Sản phẩm"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chartRevenue.Series["Sản phẩm"].YValueMembers = "Tổng tiền";
                    chartRevenue.Series["Sản phẩm"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
                    chartRevenue.Titles.Add(new Title(Text = "Doanh thu theo sản phẩm"));
                    chartRevenue.Size = new System.Drawing.Size(400, 300);
                    chartRevenue.Location = new System.Drawing.Point(12, 0);
                    PanelChart.Controls.Add(chartRevenue);

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


                FormReport f = new FormReport(list, total.ToString(), customer.Name, customer.Phone, customer.Address, Dgv_Statistic.SelectedRows[0].Cells["Tên nhân viên"].Value.ToString(), o.OrderDate);
                f.ShowDialog();
            }
        }
    }
}
