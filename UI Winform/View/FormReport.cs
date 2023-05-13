using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.DTO;

namespace UI_Winform.View
{
    public partial class FormReport : Form
    {
        private List<ViewOrderDetail> li = new List<ViewOrderDetail>();
        string ID_Order;
        string Total;
        string NameCustomer;
        string PhoneNumber;
        string Address;
        string NameStaff;
        DateTime Date;
        public FormReport(List<ViewOrderDetail> li, string total, string NameCustomer, string PhoneNumber, string Address, string nameStaff, DateTime date, string ID_Order)
        {
            InitializeComponent();

            this.li = li;
            this.Total = total;
            this.NameCustomer = NameCustomer;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.NameStaff = nameStaff;
            Date = date;
            this.ID_Order = ID_Order;

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "UI_Winform.Report.ReportOrder.rdlc";

            var source = new ReportDataSource("tbReport", li);
            Microsoft.Reporting.WinForms.ReportParameter para1 = new Microsoft.Reporting.WinForms.ReportParameter("pTotal", Total);
            Microsoft.Reporting.WinForms.ReportParameter para2 = new Microsoft.Reporting.WinForms.ReportParameter("pDate", Date.ToString("dd/MM/yyyy HH:mm"));
            Microsoft.Reporting.WinForms.ReportParameter para3 = new Microsoft.Reporting.WinForms.ReportParameter("pNameCustomer", NameCustomer);
            Microsoft.Reporting.WinForms.ReportParameter para4 = new Microsoft.Reporting.WinForms.ReportParameter("pPhoneNumber", PhoneNumber);
            Microsoft.Reporting.WinForms.ReportParameter para5 = new Microsoft.Reporting.WinForms.ReportParameter("pAddress", Address);
            Microsoft.Reporting.WinForms.ReportParameter para6 = new Microsoft.Reporting.WinForms.ReportParameter("pNameStaff", NameStaff);
            Microsoft.Reporting.WinForms.ReportParameter para7 = new Microsoft.Reporting.WinForms.ReportParameter("pID_Order", ID_Order);

            reportViewer1.LocalReport.SetParameters(para1);
            reportViewer1.LocalReport.SetParameters(para2);
            reportViewer1.LocalReport.SetParameters(para3);
            reportViewer1.LocalReport.SetParameters(para4);
            reportViewer1.LocalReport.SetParameters(para5);
            reportViewer1.LocalReport.SetParameters(para6);
            reportViewer1.LocalReport.SetParameters(para7);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();
        }
    }
}
