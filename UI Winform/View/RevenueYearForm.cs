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
using UI_Winform.DTO;

namespace UI_Winform.View
{
    public partial class RevenueYearForm : Form
    {
        public RevenueYearForm()
        {
            InitializeComponent();
        }
        private void RevenueYearForm_Load(object sender, EventArgs e)
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
            if (CbbYear.Text == "")
            {
                MessageBox.Show("Vui lòng lựa chọn năm!");
            } else
            {
                DateTime startDate = new DateTime(Convert.ToInt32(CbbYear.Text), 1, 1);
                DateTime endDate = new DateTime(Convert.ToInt32(CbbYear.Text), 12, 31);
                ManageRevenueBLL mrb = new ManageRevenueBLL();
                Dgv_Statistic.DataSource = mrb.getOrderToDRV(startDate, endDate);

                ChildPanel.Controls.Clear();
                if (Dgv_Statistic.Rows.Count > 1)
                {
                    Chart chartRevenue = new Chart();
                    chartRevenue.ChartAreas.Add(new ChartArea("Doanh thu trong năm " + CbbYear.Text));
                   
                    /*chartRevenue.ChartAreas["Doanh thu trong năm " + CbbYear.Text].AxisX.IntervalType = DateTimeIntervalType.Number;
                    chartRevenue.ChartAreas["Doanh thu trong năm " + CbbYear.Text].AxisX.Minimum = 1;
                    chartRevenue.ChartAreas["Doanh thu trong năm " + CbbYear.Text].AxisX.Maximum = 12;*/
                    Series seri = new Series();
                    seri.Name = "Năm";
                    seri.ChartType = SeriesChartType.Column;
                    seri.ChartArea = "Doanh thu trong năm " + CbbYear.Text;
                    seri.Palette = ChartColorPalette.BrightPastel;
                    chartRevenue.Series.Clear();
                    chartRevenue.Series.Add(seri);
                    chartRevenue.DataSource = mrb.getRevenueOfYear(Convert.ToInt32(CbbYear.Text));
                    chartRevenue.Series["Năm"].XValueMember = "Tháng";
                    chartRevenue.Series["Năm"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                    chartRevenue.Series["Năm"].YValueMembers = "Tổng tiền";
                    chartRevenue.Series["Năm"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

                    chartRevenue.Titles.Add(new Title(Text = "Doanh thu trong năm " + CbbYear.Text));
                    chartRevenue.Size = new System.Drawing.Size(600, 300);
                    chartRevenue.Location = new System.Drawing.Point(12, 0);
                    ChildPanel.Controls.Add(chartRevenue);

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
