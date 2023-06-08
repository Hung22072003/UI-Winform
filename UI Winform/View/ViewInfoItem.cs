using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.BLL;
using UI_Winform.DTO;
namespace UI_Winform.View
{
    public partial class ViewInfoItem : Form
    {
        private string ID_Item;
        public ViewInfoItem(string id_item)
        {
            ID_Item = id_item;
            InitializeComponent();
        }

        public void LoadInfoItem()
        {
            ManageItemBLL mib = new ManageItemBLL();
            Item i = mib.getItemByID(ID_Item);
            if (i != null)
            {
                Lb_IdItem.Text = Lb_IdItem.Text + i.IDItem;
                Lb_NameItem.Text = Lb_NameItem.Text + i.ItemName;
                Lb_Category.Text = Lb_Category.Text + i.Category.NameCategory;
                Lb_Brand.Text = Lb_Brand.Text + i.Brand.BrandName;
                Lb_InitialPrice.Text = Lb_InitialPrice.Text + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.InitialPrice);
                Lb_SellPrice.Text = Lb_SellPrice.Text + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.SellPrice);
                Lb_Warranty.Text = Lb_Warranty.Text + i.Warranty.ToString();
                Lb_Quantity.Text = Lb_Quantity.Text + i.Quantity.ToString();
                Lb_Detail.Text = Lb_Detail.Text + i.ItemDetail;

                if (i.Picture != null)
                {
                    MemoryStream memory = new MemoryStream(i.Picture);
                    Picture.Image = Image.FromStream(memory);
                }
            }
        }

        private void ViewInfoItem_Load(object sender, EventArgs e)
        {
            LoadInfoItem();
        }
    }
}
