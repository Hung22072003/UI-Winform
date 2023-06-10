using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.BLL;

namespace UI_Winform
{
    public partial class Btn_Report : Form
    {
        public Btn_Report()
        {
            InitializeComponent();
        }

        private void FormExpenditure_Load(object sender, EventArgs e)
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
            DateTime startDate = new DateTime(DtpDateStart.Value.Year, DtpDateStart.Value.Month, DtpDateStart.Value.Day, 0,0,0);
            DateTime endDate = new DateTime(DtpDateEnd.Value.Year, DtpDateEnd.Value.Month, DtpDateEnd.Value.Day, 23, 59, 59);
            if (startDate > endDate)
            {
                MessageBox.Show("Vui lòng xem lại ngày");
            }
            else
            {
                ManageExpenditureBLL meb = new ManageExpenditureBLL();
                Dgv_Statistic.DataSource = meb.getItemsToDGV(startDate,endDate);
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ManageExpenditureBLL meb = new ManageExpenditureBLL();
            Dgv_Statistic.DataSource = meb.getItemsBySearch(Txb_Search.Text);
        }
    }
}
