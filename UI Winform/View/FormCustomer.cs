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

namespace UI_Winform.View
{
    public partial class FormCustomer : Form
    {
        private Form activeForm;
        public FormCustomer()
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
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadDGV();
        }

        public void LoadDGV()
        {
            ManageCustomerBLL mcb = new ManageCustomerBLL();
            dataGridView1.DataSource = mcb.GetAllCustomerBLL();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ManageCustomerBLL mcb = new ManageCustomerBLL();
            dataGridView1.DataSource = mcb.GetCustomersBySearch(Txb_Search.Text);
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                InfoCustomer f = new InfoCustomer(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                OpenChildForm(f, sender);
                f.d += new InfoCustomer.Mydel(LoadDGV);
            }
        }

        private void Btn_HistoryTrade_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                OpenChildForm(new FormTradeHistory(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())), sender);
            }
        }
    }
}
