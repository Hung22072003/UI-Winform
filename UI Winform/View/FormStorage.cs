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
    public partial class FormStorage : Form
    {
        private Form activeForm;
        private DataTable dt;
        public FormStorage()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Mã sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tên sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Hãng", DataType = typeof(string)},
                new DataColumn {ColumnName = "Số lượng", DataType = typeof(int)},
                new DataColumn {ColumnName = "Giá bán", DataType = typeof(long)},
                new DataColumn {ColumnName = "Giá gốc", DataType = typeof(long)},
                new DataColumn {ColumnName = "Khuyến mãi", DataType = typeof(float)},
                new DataColumn {ColumnName = "Bảo hành", DataType = typeof(int)},
                new DataColumn {ColumnName = "Tình trạng", DataType = typeof(string)},
                new DataColumn {ColumnName = "Thông số kỹ thuật", DataType = typeof(string)}
            });
            SetCbbBrand();
        }

        private void FormStorage_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

        public void ShowDRV(string searchName, string searchBrand)
        {
            dt.Rows.Clear();
            using (DBPM db = new DBPM())
            {
                if (searchBrand == "All")
                {
                    var s = db.Items.Where(p => p.ItemName.Contains(searchName)).Select(p => new { p.IDItem, p.ItemName, p.Category.NameCategory, p.Quantity, p.SellPrice, p.InitialPrice, p.Discount, p.Warranty, p.Status, p.ItemDetail });
                    s.ToList().ForEach(p => {
                        dt.Rows.Add(p.IDItem, p.ItemName, p.NameCategory, p.Quantity, p.SellPrice, p.InitialPrice, p.Discount, p.Warranty, p.Status, p.ItemDetail);
                    });
                } else
                {
                    var s = db.Items.Where(p => p.ItemName.Contains(searchName) && p.Category.NameCategory == searchBrand).Select(p => new { p.IDItem, p.ItemName, p.Category.NameCategory, p.Quantity, p.SellPrice, p.InitialPrice, p.Discount, p.Warranty, p.Status, p.ItemDetail });
                    s.ToList().ForEach(p => {
                        dt.Rows.Add(p.IDItem, p.ItemName, p.NameCategory, p.Quantity, p.SellPrice, p.InitialPrice, p.Discount, p.Warranty, p.Status, p.ItemDetail);
                    });
                }
                dataGridView1.DataSource = dt;
            }
        }

        public void SetCbbBrand()
        {
            Cbb_Brand.Items.Clear();
            Cbb_Brand.Items.Add("All");
            using (DBPM db = new DBPM())
            {
                var s = db.Brands.Select(p => new { p.BrandName });
                s.ToList().ForEach(p =>
                {
                    Cbb_Brand.Items.Add(p.BrandName);
                });
            };
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            InfoItem f = new InfoItem();
            OpenChildForm(f, sender);
            f.d += new InfoItem.MyDel(ShowDRV);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ShowDRV(Txb_Search.Text, Cbb_Brand.Text);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string Id = i.Cells[0].Value.ToString();
                    using (DBPM db = new DBPM()) {
                        var s = db.Items.Where(p => p.IDItem == Id).Select(p => p).FirstOrDefault();
                        db.Items.Remove(s);
                        db.SaveChanges();
                    }
                }
            }
            ShowDRV(Txb_Search.Text, Cbb_Brand.Text);
        }
    }
}
