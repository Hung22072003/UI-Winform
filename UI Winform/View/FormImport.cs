using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public delegate void MyDel(string s1, string s2, string s3);
        public MyDel d { get; set; }
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
        private void Txb_TextChanged(object sender, EventArgs e)
        {
            ManageExpenditureBLL meb = new ManageExpenditureBLL();
            if (meb.CheckValidInfo(Txb_Price.Text, Txb_Quantity.Text)) 
            {
                Txb_Total.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", (Convert.ToDecimal(Txb_Price.Text) * Convert.ToInt32(Txb_Quantity.Text)));
            }
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            ManageExpenditureBLL meb = new ManageExpenditureBLL();
            if (meb.CheckValidInfo(Txb_Price.Text, Txb_Quantity.Text))
            {
                ManageItemBLL mib = new ManageItemBLL();
                mib.UpdateQuantityItem(ID_Item, Convert.ToInt32(Txb_Quantity.Text));
                
                meb.AddSpendingBill(ID_Item, dtpImportDate.Value, Convert.ToInt32(Txb_Quantity.Text), Convert.ToDecimal(Txb_Price.Text), Convert.ToDecimal(Txb_Total.Text.Replace(".", "")));

                MessageBox.Show("Thêm thành công!");
                d("", "", "");
                this.Close();
            } else {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   
