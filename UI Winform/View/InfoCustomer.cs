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
    public partial class InfoCustomer : Form
    {
        private int ID_Customer;
        public delegate void Mydel();
        public Mydel d { get; set; }

        public InfoCustomer(int ID_Customer)
        {
            this.ID_Customer = ID_Customer;
            InitializeComponent();
        }

        private void InfoCustomer_Load(object sender, EventArgs e)
        {
            SetGUI();
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
            Lb_Title.ForeColor = ThemeColor.SecondaryColor;
        }
        public void SetGUI()
        {
            if (ID_Customer != null)
            {
                ManageCustomerBLL mcb = new ManageCustomerBLL();
                Customer c = mcb.GetCustomerByID(ID_Customer);
                if (c != null)
                {
                    txb_ID.Text = c.ID_Customer.ToString();
                    txb_Address.Text = c.Address;
                    txb_Name.Text = c.Name;
                    txb_PhoneNumber.Text = c.Phone;
                    txb_BonusPoint.Text = c.BonusPoint.ToString();
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ManageCustomerBLL mcb = new ManageCustomerBLL();
            if (mcb.CheckValidInfo(txb_Name.Text, txb_PhoneNumber.Text, txb_Address.Text, txb_BonusPoint.Text))
            {
                mcb.UpdateCustomer(Convert.ToInt32(txb_ID.Text), txb_Name.Text, txb_PhoneNumber.Text, txb_Address.Text, Convert.ToInt32(txb_BonusPoint.Text));
                d();
                this.Close();
            }
        }
    }
}
