using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Media.Media3D;
using UI_Winform.BLL;
using UI_Winform.DAL;
using UI_Winform.DTO;
using UI_Winform.View;

namespace UI_Winform
{
    public partial class FormStorage : Form
    {
        private string ID_User;
        private string typeAccount;
        private Form activeForm;
        private DataTable dt;
        public FormStorage(string iD_User, string typeAccount)
        {
            this.ID_User = iD_User;
            this.typeAccount = typeAccount;
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
            SetCbbCategory();
            SetGUI();
        }

        private void FormStorage_Load(object sender, EventArgs e)
        {
            LoadTheme();
            ManageItemBLL mib = new ManageItemBLL();
            dataGridView1.DataSource = mib.getAllItemDGV();
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

        public void ShowDRV(string searchName, string searchBrand, string searchCategory)
        {
            ManageItemBLL mib = new ManageItemBLL();
            dataGridView1.DataSource = mib.getItemsBySearch(searchName, searchBrand, searchCategory);
        }
        public void SetGUI()
        {
            if (typeAccount == "Nhân viên")
            {
                Btn_Add.Visible = false;
                Btn_Update.Visible = false;
                Btn_Delete.Visible = false;
                Btn_Import.Visible = false;
                Btn_View.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                Btn_Sort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                Cbb_Sort.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
                Cbb_Type.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            }
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
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            InfoItem f = new InfoItem("") ;
            OpenChildForm(f, sender);
            f.d += new InfoItem.MyDel(ShowDRV);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ShowDRV(Txb_Search.Text, Cbb_Brand.Text, Cbb_Category.Text);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                   ManageItemBLL mib = new ManageItemBLL();
                    mib.RemoveItem(i.Cells[0].Value.ToString());
                }
            }
            ShowDRV(Txb_Search.Text, Cbb_Brand.Text, Cbb_Category.Text);
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                InfoItem f = new InfoItem(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                OpenChildForm(f, sender);
                f.d += new InfoItem.MyDel(ShowDRV);
            }
        }

        private void Btn_Import_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                FormImport f = new FormImport(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                OpenChildForm(f, sender);
                f.d += new FormImport.MyDel(ShowDRV);
            }
        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            if (Cbb_Sort.Text != "" && Cbb_Type.Text != "" && Cbb_Sort.Items.Contains(Cbb_Sort.Text) && Cbb_Type.Items.Contains(Cbb_Type.Text))
            {
                List<string> li = new List<string>();

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells["Mã sản phẩm"].Value != null)
                    {
                        li.Add(dataGridView1.Rows[i].Cells["Mã sản phẩm"].Value.ToString());
                    }
                }

                ManageItemBLL mib = new ManageItemBLL();
                dataGridView1.DataSource = mib.SortBy(li, Cbb_Sort.Text, Cbb_Type.Text);
            }
            
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ViewInfoItem f = new ViewInfoItem(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                f.ShowDialog();
            }
        }

        private void Btn_AddCate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCateBrand(), sender);
        }
    }
}
