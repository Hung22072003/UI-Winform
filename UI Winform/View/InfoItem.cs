using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.DAL;
using UI_Winform.DTO;
namespace UI_Winform
{
    public partial class InfoItem : Form
    {
        public delegate void MyDel(string s1, string s2);
        public MyDel d { get; set; }
        public InfoItem()
        {
            InitializeComponent();
            SetCbbBrand();
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
            Cbb_Brand.Items.Clear();
            using(DBPM db = new DBPM())
            {
                var s = db.Brands.Select(p => new {p.BrandName});
                s.ToList().ForEach(p =>
                {
                    Cbb_Brand.Items.Add(p.BrandName);
                });
            };
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            using(DBPM db = new DBPM())
            {
                /*Item i = new Item();
                i.IDItem = Txb_ID.Text;
                i.ItemName = Txb_Name.Text;
                i.SellPrice = Convert.ToDecimal(Txb_SellPrice.Text);
                i.InitialPrice = Convert.ToDecimal(Txb_InitialPrice.Text);
                i.Discount = Math.Round(Convert.ToDouble((i.SellPrice - i.InitialPrice) / i.InitialPrice), 2);
                var s = db.Brands.Where(p => p.BrandName == Cbb_Brand.Text).Select(p => new {p.BrandID}).FirstOrDefault();
                if (s != null)
                {
                    i.ID_Brand = s.BrandID;
                }
                i.Warranty = Convert.ToInt32(Txb_Waranty.Text);
                i.Status = Cbb_Status.Text;
                i.ItemDetail = Txb_Detail.Text;
                

                db.Items.Add(i);
                db.SaveChanges();
               
                d("", "All");*/
            };

            this.Close();
        }

        public void Reset()
        {
            Txb_ID.Text = Txb_Detail.Text = Txb_InitialPrice.Text = Txb_Name.Text = Txb_SellPrice.Text = Txb_Waranty.Text = Cbb_Brand.Text = Cbb_Status.Text = "";
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
