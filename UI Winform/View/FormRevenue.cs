using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Winform.View
{
    public partial class FormRevenue : Form
    {
        private Form activeForm;
        public FormRevenue()
        {
            InitializeComponent();
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
            Lb_Title.ForeColor = ThemeColor.SecondaryColor;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ChildPanel.Controls.Add(childForm);
            this.ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Cbb_Choice.Text == "Khoảng thời gian")
            {
                OpenChildForm(new RevenueTimeForm(), sender);
            }
            else if (Cbb_Choice.Text == "Năm")
            {
                OpenChildForm(new RevenueYearForm(), sender);
            }
        }

        private void FormRevenue_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
