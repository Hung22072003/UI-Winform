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
using UI_Winform.View;
using UI_Winform.DTO;

namespace UI_Winform
{
    public partial class FormStaff : Form
    {
        private Form activeForm;
        public static int check;
        public FormStaff()
        {
            InitializeComponent();

            LoadInfor();

            cbb_Sort.Items.Add("Lương");
            cbb_Sort.Items.Add("Ngày Sinh");
            cbb_Sort.Items.Add("Tên");

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

        private void FormStaff_Load(object sender, EventArgs e)
        {
            LoadTheme();
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

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            check = 0;
            InfoStaff Inf = new InfoStaff();
            Inf.InfoStaffDel += LoadInfor;
            OpenChildForm(Inf, sender);
        }

        public void LoadInfor()
        {
            ManageStaffBLL mnb = new ManageStaffBLL();

            dataGridView1.DataSource = mnb.GetAllStaffBLL();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ManageStaffBLL mnb = new ManageStaffBLL();

            dataGridView1.DataSource = mnb.GetAllStafByNamefBLL(Txb_Search.Text);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ManageStaffBLL mnb = new ManageStaffBLL();
                ManageAccountBLL mab = new ManageAccountBLL();
                ManageStaff_ShiftBLL mssb = new ManageStaff_ShiftBLL();


                List<CheckBoxShift> li = new List<CheckBoxShift>();
                ManageShiftBLL msb = new ManageShiftBLL();
                li = msb.SetCheckBoxShiftBLL();

                foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    mssb.DeleteByID_StaffBLL(i.Cells[0].Value.ToString(), li);

                    mab.DeleteAccountById_StaffBLL(i.Cells[0].Value.ToString());
                    mnb.DeleteStaffByIDBLL(i.Cells[0].Value.ToString());
                }
                LoadInfor();
            }

        }

        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            ManageStaffBLL mnb = new ManageStaffBLL();
            if (cbb_Sort.Text != "" && cbb_AscDesc.Text != "" && cbb_Sort.Items.Contains(cbb_Sort.Text) && cbb_AscDesc.Items.Contains(cbb_AscDesc.Text))
            {
                dataGridView1.DataSource = mnb.SortStaffBLL(cbb_Sort.Text, cbb_AscDesc.Text);
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                check = 1;
                InfoStaff Inf = new InfoStaff(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                Inf.InfoStaffDel += LoadInfor;
                OpenChildForm(Inf, sender);
            }
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                check = 2;
                InfoStaff inf = new InfoStaff(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                inf.Show();
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                ManageAccountBLL mab = new ManageAccountBLL();
                mab.UpdatePassword("123", mab.GetAccountByID(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()).UserName);
                MessageBox.Show("Cập nhật thành công!");
            }
        }
    }
}
