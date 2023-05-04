using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using UI_Winform.BLL;
using UI_Winform.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_Winform.View
{
    public partial class FormSettingUser : Form
    {
        private string ID_User;
        private List<CheckBoxShift> li;
        public FormSettingUser(string iD_User)
        {
            InitializeComponent();
            ManageShiftBLL msb = new ManageShiftBLL();
            li = msb.SetCheckBoxShiftBLL();
            ID_User = iD_User;
            SetGUI();
            SetGroupBoxShift();
            
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(System.Windows.Forms.Button))
                {
                    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btn.FlatStyle = FlatStyle.Flat;
                }
            }
            Lb_Title.ForeColor = ThemeColor.SecondaryColor;
        }
        public void SetGroupBoxShift()
        {
            int x = 12, y = 38;

            foreach (CheckBoxShift i in li)
            {
                CheckBox temp = new CheckBox();
                i.ID_Staff = ID_User;
                temp.Checked = i.check;
                temp.Text = i.text;
                temp.Name = "cb_Shift" + i.value.ToString();
                temp.Location = new System.Drawing.Point(x, y * i.value);
                temp.AutoSize = true;
                temp.Enabled = false;
                grb_Shift.Controls.Add(temp);
            }
        }

        public void GetCheckBoxShiftFromUI()
        {
            foreach (CheckBox checkbox in grb_Shift.Controls)
            {
                foreach (CheckBoxShift i in li)
                {
                    if (i.text == checkbox.Text)
                    {
                        i.check = checkbox.Checked;
                    }
                }
            }
        }
        private void FormSettingUser_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void SetGUI()
        {
            ManageStaffBLL msb = new ManageStaffBLL();
            Staff s = msb.GetStaffByID(ID_User);
            ManageAccountBLL mab = new ManageAccountBLL();
            Account a = mab.GetAccountByID(ID_User);
            ManageStaff_ShiftBLL mssb = new ManageStaff_ShiftBLL();
            DataTable dt = new DataTable();
            dt = mssb.ListToDatatable(ID_User);
            if (s != null)
            {
                txb_IDStaff.Text = s.ID_Staff;
                txb_Name.Text = s.Name;
                txb_Address.Text = s.Address;
                txb_Email.Text = s.Email;
                txb_PhoneNumber.Text = s.PhoneNumber;
                txb_Salary.Text = s.Salary.ToString();
                txb_Account.Text = a.UserName;
                txb_PassWord.Text = a.PassWord;
                dtp_DateOfBirth.Text = Convert.ToString(s.DateOfBirth);
                if (a.TypeAccount == 1)
                {
                    rbtn_Staff.Checked= true;
                }else if (a.TypeAccount == 0)
                {
                    rbtn_Manager.Checked = true;
                }

                if (s.Picture != null)
                {
                    MemoryStream memory = new MemoryStream(s.Picture);
                    pt_Staff.Image = Image.FromStream(memory);
                }

                foreach (DataRow i in dt.Rows)
                {
                    foreach (CheckBoxShift j in li)
                    {
                        if (Convert.ToInt32(i[1]) == j.value)
                        {
                            j.check = true;
                        }
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ManageStaffBLL msb = new ManageStaffBLL();
            ManageAccountBLL mab = new ManageAccountBLL();
            ManageStaff_ShiftBLL mssb = new ManageStaff_ShiftBLL();
            msb.UpdateStaffBLL(this.ID_User, txb_Name.Text, txb_PhoneNumber.Text, Convert.ToDateTime(dtp_DateOfBirth.Text),
                   txb_Address.Text, Convert.ToDecimal(txb_Salary.Text), txb_Email.Text, pt_Staff.Image);

            //Update Staff_Shift

            mssb.DeleteByID_StaffBLL(ID_User, li);

            GetCheckBoxShiftFromUI(); //Cập nhật lại li


            mssb.AddStaffByID_StaffBLL(ID_User, li);

            mab.UpdateAccountBLL(this.ID_User, txb_Account.Text, txb_PassWord.Text, rbtn_Staff.Checked);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
        }

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            try
            {
                ofd_OpenFile.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";
                ofd_OpenFile.ShowDialog();
                string file = ofd_OpenFile.FileName; //lấy đường dẫn đến file mà mình đã chọn
                Image image = Image.FromFile(file); //Tạo ra một đối tượng image thông qua đường dẫn
                pt_Staff.Image = image;
            } catch(Exception ex)
            {

            }
            
        }
    }
}
