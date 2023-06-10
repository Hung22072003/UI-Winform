using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.BLL;
using UI_Winform.DAL;
using UI_Winform.DTO;
namespace UI_Winform
{
    public partial class InfoItem : Form
    {
        private string ID_Item;
        public delegate void MyDel(string s1, string s2, string s3);
        public MyDel d { get; set; }
        public InfoItem(string iD_Item)
        {
            ID_Item = iD_Item;
            InitializeComponent();
            SetCbbBrand();
            SetCbbCategory();
            SetGUI();
        }

        private void InfoItem_Load(object sender, EventArgs e)
        {
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

        public void SetCbbBrand()
        {
            ManageBrandBLL mbb = new ManageBrandBLL();
            Cbb_Brand.Items.AddRange(mbb.getCBBBrand().ToArray());
        }

        public void SetCbbCategory()
        {
            ManageCategoryBLL mcb = new ManageCategoryBLL();
            Cbb_Category.Items.AddRange(mcb.getCBBCategory().ToArray());
        }

        public void SetTxbIDItem()
        {
            ManageItemBLL mib = new ManageItemBLL();
            Txb_ID.Text = mib.setNewIDItem();
        }
        public void SetGUI()
        {
            if (this.ID_Item != "")
            {
                Txb_ID.Enabled = false;
                Lb_Quantity.Visible = true;
                Txb_Quantity.Visible = true;
                ManageItemBLL mib = new ManageItemBLL();
                Item item = mib.getItemByID(ID_Item);
                if (item != null)
                {
                    Txb_ID.Text = item.IDItem;
                    Txb_Name.Text = item.ItemName;
                    Txb_Detail.Text = item.ItemDetail;
                    Txb_InitialPrice.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", item.InitialPrice);
                    Txb_SellPrice.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", item.SellPrice);
                    Txb_Waranty.Text = item.Warranty.ToString();
                    Cbb_Brand.Text = item.Brand.BrandName;
                    Cbb_Category.Text = item.Category.NameCategory;
                    Txb_Quantity.Text = item.Quantity.ToString();

                    if (item.Picture != null)
                    {
                        MemoryStream memory = new MemoryStream(item.Picture);
                        Picture.Image = Image.FromStream(memory);
                    }
                }
            }else
            {
                SetTxbIDItem();
                Txb_Quantity.Text = "0";
            }
            
        }
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            ManageItemBLL mib = new ManageItemBLL();
            if (mib.CheckValidInfo(Txb_ID.Text, Txb_Name.Text, Txb_Detail.Text, Txb_InitialPrice.Text.Replace(".", ""), Txb_Quantity.Text, Txb_SellPrice.Text.Replace(".", ""), Txb_Waranty.Text, Cbb_Brand.Text, Cbb_Category.Text))
            {
                decimal discount = Math.Round((1 - (Convert.ToDecimal(Txb_SellPrice.Text.Replace(".", "")) / Convert.ToDecimal(Txb_InitialPrice.Text.Replace(".", "")))), 2);
                mib.AddUpdateItem(Txb_ID.Text, Txb_Name.Text, Convert.ToDecimal(Txb_SellPrice.Text.Replace(".","")), Convert.ToDecimal(Txb_InitialPrice.Text.Replace(".", "")), float.Parse(discount.ToString()), Txb_Detail.Text, Picture.Image, Convert.ToInt32(Txb_Waranty.Text), ((CbbBrand)Cbb_Brand.SelectedItem).Value, ((CbbCategory)Cbb_Category.SelectedItem).Value, Convert.ToInt32(Txb_Quantity.Text));
                d("", "", "");
                this.Close();
            }
        }

        public void Reset()
        {
            Txb_ID.Text = Txb_Detail.Text = Txb_InitialPrice.Text = Txb_Name.Text = Txb_SellPrice.Text = Txb_Waranty.Text = Cbb_Category.Text = Cbb_Brand.Text = "";
            Picture.Image = null;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Btn_AddPicture_Click(object sender, EventArgs e)
        {
            try
            {
                ofd_OpenFile.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
                ofd_OpenFile.ShowDialog();
                string file = ofd_OpenFile.FileName; 
                Image image = Image.FromFile(file);
                Picture.Image = image;
            } catch (Exception ex)
            {

            }
        }
    }
}
