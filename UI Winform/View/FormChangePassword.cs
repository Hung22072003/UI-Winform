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
    public partial class FormChangePassword : Form
    {
        private string UserName;
        public FormChangePassword(string userName)
        {
            InitializeComponent();
            UserName = userName;
            LoadInfo();
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

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            ManageAccountBLL mab = new ManageAccountBLL();
            if (!mab.CheckPassword(Txb_UserName.Text, Txb_CurPassword.Text))
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng");
            } else if (Lb_Note.Text == "Mật khẩu khớp") {
                mab.UpdatePassword(Txb_ConfPassword.Text, this.UserName);
                MessageBox.Show("Thay đổi mật khẩu thành công");
                this.Close();
            }
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        public void LoadInfo()
        {
            Txb_UserName.Text = this.UserName;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txb_ConfPassword_TextChanged(object sender, EventArgs e)
        {
            if (Txb_ConfPassword.Text == Txb_NewPassword.Text) Lb_Note.Text = "Mật khẩu khớp";
            else
            {
                Lb_Note.Text = "";
            }
        }
    }
}
