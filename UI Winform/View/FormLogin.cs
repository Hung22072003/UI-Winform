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

namespace UI_Winform
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            ManageAccountBLL mab = new ManageAccountBLL();
            if (mab.CheckValidInfo(Txb_UserName.Text, Txb_PassWord.Text))
            {
                if (mab.CheckPassword(Txb_UserName.Text, Txb_PassWord.Text))
                {
                    string result = mab.getTypeAccount(Txb_UserName.Text);
                    if (result == "Quản lý")
                    {
                        AdminForm af = new AdminForm(mab.getIDUserByAccount(Txb_UserName.Text, Txb_PassWord.Text), result);
                        this.Hide();
                        af.ShowDialog();
                        this.Show();
                    }
                    else if (result == "Nhân viên")
                    {
                        UserForm uf = new UserForm(mab.getIDUserByAccount(Txb_UserName.Text, Txb_PassWord.Text), result);
                        this.Hide();
                        uf.ShowDialog();
                        this.Show();
                    }
                }else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                }
            }
        }

        private void Panel_Lock_MouseDown(object sender, MouseEventArgs e)
        {
            Txb_PassWord.UseSystemPasswordChar = false;
            Panel_Lock.BackgroundImage = global::UI_Winform.Properties.Resources.lock_open_solid;
        }

        private void Panel_Lock_MouseUp(object sender, MouseEventArgs e)
        {
            Txb_PassWord.UseSystemPasswordChar = true;
            Panel_Lock.BackgroundImage = global::UI_Winform.Properties.Resources.lock_solid;
        }
    }
}
