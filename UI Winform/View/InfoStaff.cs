using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.BLL;
using UI_Winform.DTO;

namespace UI_Winform
{
    public partial class InfoStaff : Form
    {
        string id;

        public delegate void MyDel();
        public MyDel InfoStaffDel;

        private List<CheckBoxShift> li;
        public InfoStaff()
        {
            InitializeComponent();
            ManageShiftBLL msb = new ManageShiftBLL();
            li = msb.SetCheckBoxShiftBLL();
            SetGroupBoxShift();
            SetCbbTypeAccount();
            SetTextBoxIDStaffAndUserName();
        }

        public InfoStaff(string id)
        {
            this.id = id;
            ManageShiftBLL msb = new ManageShiftBLL();
            li = msb.SetCheckBoxShiftBLL();
            InitializeComponent();
            SetCbbTypeAccount();
            LoadInfor();
            SetGroupBoxShift();
            btn_Reset.Visible = false;

            if (FormStaff.check == 2)
            {
                ViewStaff();
                btn_Ok.Visible = false;
                btn_AddImage.Visible = false;
            }
        }
        public void SetTextBoxIDStaffAndUserName()
        {
            ManageStaffBLL msb = new ManageStaffBLL();
            txb_Account.Text = txb_IDStaff.Text = msb.setIDStaff();
        }

        public void SetCbbTypeAccount()
        {
            ManageRoleBLL mrb = new ManageRoleBLL();
            cbb_TypeAccount.Items.AddRange(mrb.GetCbbTypeAccounts().ToArray());
        }
        public void ViewStaff()
        {

            txb_IDStaff.Enabled = false;
            txb_Name.Enabled = false;
            txb_Address.Enabled = false;
            txb_Email.Enabled = false;
            txb_Salary.Enabled = false;
            dtp_DateOfBirth.Enabled = false;
            txb_PhoneNumber.Enabled = false;

            txb_Account.Enabled = false;

            foreach (CheckBox i in grb_Shift.Controls)
            {
                i.Enabled = false;
            }

            Lb_Title.Visible = false;
            cbb_TypeAccount.Enabled = false;
        }
        private void InfoStaff_Load(object sender, EventArgs e)
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

        public void LoadInfor()
        {
            ManageStaffBLL msb = new ManageStaffBLL();
            ManageAccountBLL mab = new ManageAccountBLL();
            ManageStaff_ShiftBLL mssb = new ManageStaff_ShiftBLL();

            //Lấy dữ liệu tử bảng Staff
            var s = msb.GetStaffByID(id);

            txb_Account.Enabled = false;
            //Lấy dữ liệu tử bảng Account
            Account a = mab.GetAccountByID(id);

            //Lấy dữ liệu từ bảng trung gian giữa Staff và Shift và trả về kiểu datatable
            DataTable dt = new DataTable();
            dt = mssb.ListToDatatable(id);

            //Load Thông tin vào trong form
            txb_IDStaff.Text = s.ID_Staff;
            txb_IDStaff.Enabled = false;
            txb_Name.Text = Convert.ToString(s.Name);
            txb_Address.Text = Convert.ToString(s.Address);
            txb_Email.Text = Convert.ToString(s.Email);
            txb_Salary.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", s.Salary);
            dtp_DateOfBirth.Text = Convert.ToString(s.DateOfBirth);
            txb_PhoneNumber.Text = Convert.ToString(s.PhoneNumber);

            //Load anh
            if (s.Picture != null)
            {
                MemoryStream memory = new MemoryStream(s.Picture);
                pt_Staff.Image = Image.FromStream(memory);
            }


            //Tick vào ca làm trong check box
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

            //Load thong tin vao trong muc account

            txb_Account.Text = a.UserName;

            ManageRoleBLL mrb = new ManageRoleBLL();
            cbb_TypeAccount.Text = mrb.getNameRoleByIDRole(a.ID_Role);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txb_Name.Text = "";
            txb_Address.Text = "";
            txb_Email.Text = "";
            txb_Salary.Text = "";
            dtp_DateOfBirth.Text = "";
            txb_PhoneNumber.Text = "";
            pt_Staff.Image = null;

            txb_Account.Text = "";
            cbb_TypeAccount.Text = "";
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {

            ManageStaffBLL msb = new ManageStaffBLL();
            ManageAccountBLL mab = new ManageAccountBLL();
            ManageStaff_ShiftBLL mssb = new ManageStaff_ShiftBLL();
            if (msb.CheckValidInfo(txb_IDStaff.Text, txb_Name.Text, txb_PhoneNumber.Text, txb_Address.Text, txb_Salary.Text, txb_Email.Text, cbb_TypeAccount.Text))
            {
                if (FormStaff.check == 1)
                {
                 msb.UpdateStaffBLL(this.id, txb_Name.Text, txb_PhoneNumber.Text, Convert.ToDateTime(dtp_DateOfBirth.Text),
                 txb_Address.Text, Convert.ToDecimal(txb_Salary.Text.Replace(".", "")), txb_Email.Text, pt_Staff.Image);

                        //Update Staff_Shift

                 mssb.DeleteByID_StaffBLL(id, li);

                 GetCheckBoxShiftFromUI(); //Cập nhật lại li

                 mssb.AddStaffByID_StaffBLL(id, li);

                 mab.UpdateAccountBLL(this.id, txb_Account.Text, ((CbbTypeAccount)(cbb_TypeAccount.SelectedItem)).value);
                    this.InfoStaffDel();  
                }
                else if (FormStaff.check == 0)
                {
                 msb.AddStaffBLL(txb_IDStaff.Text, txb_Name.Text, txb_PhoneNumber.Text, Convert.ToDateTime(dtp_DateOfBirth.Text),
                 txb_Address.Text, Convert.ToDecimal(txb_Salary.Text.Replace(".", "")), txb_Email.Text, pt_Staff.Image);

                 GetCheckBoxShiftFromUI();

                 mssb.AddStaffByID_StaffBLL(txb_IDStaff.Text, li);

                 mab.AddAccountBLL(txb_IDStaff.Text, txb_Name.Text, txb_Account.Text, "123", ((CbbTypeAccount)(cbb_TypeAccount.SelectedItem)).value);
                    this.InfoStaffDel();
                }
                this.Close();
            }
                
        }
        public void SetGroupBoxShift()
        {
            int x = 12, y = 38;

            foreach (CheckBoxShift i in li)
            {
                CheckBox temp = new CheckBox();
                i.ID_Staff = id;
                temp.Checked = i.check;
                temp.Text = i.text;
                temp.Name = "cb_Shift" + i.value.ToString();
                temp.Location = new System.Drawing.Point(x, y * i.value);
                temp.AutoSize = true;
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

        private void btn_AddImage_Click(object sender, EventArgs e)
        {
            try
            {
                ofd_OpenFile.Filter = "JPEG files (*.jpeg)|*.jpeg|All files (*.*)|*.*";
                ofd_OpenFile.ShowDialog();
                string file = ofd_OpenFile.FileName; //lấy đường dẫn đến file mà mình đã chọn
                Image image = Image.FromFile(file); //Tạo ra một đối tượng image thông qua đường dẫn
                pt_Staff.Image = image;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
