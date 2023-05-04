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
    public partial class FormImport : Form
    {
        private string ID_Item;
        public FormImport(string ID_Item)
        {
            this.ID_Item  = ID_Item;
            InitializeComponent();
            SetGUI();
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

        private void FormImport_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        public void SetGUI()
        {
            if (this.ID_Item != "")
            {
                ManageItemBLL mib = new ManageItemBLL();
                Item i = mib.getItemByID(this.ID_Item);
                Lb_IdItem.Text = "Mã sản phẩm: " + i.IDItem;
                Lb_NameItem.Text = "Tên sản phẩm: " + i.ItemName;
            }
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void Txb_TextChanged(object sender, EventArgs e)
        {
            if (Txb_Price.Text != "" && Txb_Quantity.Text != "" && IsNumber(Txb_Price.Text) && IsNumber(Txb_Quantity.Text))
            {
                Txb_Total.Text = (Convert.ToDecimal(Txb_Price.Text) * Convert.ToInt32(Txb_Quantity.Text)).ToString();
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Txb_Price.Text != "" && Txb_Quantity.Text != "" && IsNumber(Txb_Price.Text) && IsNumber(Txb_Quantity.Text))
            {
                ManageItemBLL mib = new ManageItemBLL();
                mib.UpdateQuantityItem(ID_Item, Convert.ToInt32(Txb_Quantity.Text));

                ManageExpenditureBLL meb = new ManageExpenditureBLL();
                meb.AddSpendingBill(ID_Item, dtpImportDate.Value, Convert.ToInt32(Txb_Quantity.Text), Convert.ToDecimal(Txb_Price.Text), Convert.ToDecimal(Txb_Total.Text));

                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   
