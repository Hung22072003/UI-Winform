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

namespace UI_Winform.View
{
    public partial class RevenueYearForm : Form
    {
        public RevenueYearForm()
        {
            InitializeComponent();
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

                if (Dgv_Statistic.Rows.Count > 1)
                {
                    PanelChart.Controls.Clear();
                    Chart chartRevenue = new Chart();
                    chartRevenue.ChartAreas.Add(new ChartArea("Doanh thu trong năm " + CbbYear.Text));
                    chartRevenue.ChartAreas["Doanh thu trong năm " + CbbYear.Text].AxisX.IntervalType = DateTimeIntervalType.Number;
                    chartRevenue.ChartAreas["Doanh thu trong năm " + CbbYear.Text].AxisX.Minimum = 1;
                    chartRevenue.ChartAreas["Doanh thu trong năm " + CbbYear.Text].AxisX.Maximum = 12;
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
                    chartRevenue.Size = new System.Drawing.Size(400, 300);
                    PanelChart.Controls.Add(chartRevenue);
                }
            }
           
        }

        private void CbbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
