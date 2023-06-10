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
    public partial class FormCateBrand : Form
    {

        public FormCateBrand()
        {
            InitializeComponent();
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
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Txb_ID.Text != "" && Txb_Name.Text != "" && Cbb_Category.Text != "")
            {
                if (Cbb_Category.Text == "Hãng")
                {
                    ManageBrandBLL mbb = new ManageBrandBLL();
                    mbb.AddBrand(Txb_ID.Text, Txb_Name.Text);
                }
                else if (Cbb_Category.Text == "Loại sản phẩm")
                {
                    ManageCategoryBLL mcb = new ManageCategoryBLL();
                    mcb.AddCategory(Txb_ID.Text, Txb_Name.Text);
                }
            }else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            } 
            
        }

        private void FormCateBrand_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
