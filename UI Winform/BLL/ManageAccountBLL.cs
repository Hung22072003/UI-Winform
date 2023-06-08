using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.DAL;
using UI_Winform.DTO;
namespace UI_Winform.BLL
{
    internal class ManageAccountBLL
    {
        public string getTypeAccount(string UserName)
        {
            ManageRoleBLL mrb = new ManageRoleBLL();
            ManageAccountDAL mad = new ManageAccountDAL();
            foreach (Account i in mad.getAllAccounts())
            {
                if (i.UserName == UserName) 
                    return mrb.getNameRoleByIDRole(i.ID_Role);
            }
            return null;
        }

        public bool CheckPassword(string UserName, string PassWord)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            foreach (Account i in mad.getAllAccounts())
            {
                if (i.UserName == UserName && BCrypt.Net.BCrypt.Verify(PassWord, i.PassWord)) return true;
            }
            return false;
        }
        public string getIDUserByAccount(string UserName, string PassWord)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            foreach (Account i in mad.getAllAccounts())
            {
                if (i.UserName == UserName && BCrypt.Net.BCrypt.Verify(PassWord, i.PassWord))
                {
                    return i.ID_Staff;
                }
            }
            return null;
        }

        public Account GetAccountByID(string id)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            return mad.GetAccountByIDDAL(id);
        }

        public void DeleteAccountById_StaffBLL(string id)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            mad.DeleteAccountById_StaffDAL(id);
        }

        public void UpdateAccountBLL(string ID_Staff, string UserName, int idrole)
        {
            Account temp = new Account();

            temp.ID_Staff = ID_Staff;
            temp.UserName = UserName;
            temp.ID_Role = idrole;

            ManageAccountDAL mad = new ManageAccountDAL();
            mad.UpdateAccountDAL(temp);
        }

        public void AddAccountBLL(string ID_Staff, string DisplayName, string UserName, string Password, int idrole)
        {
            Account temp = new Account();

            temp.ID_Staff = ID_Staff;
            temp.UserName = UserName;
            temp.PassWord = EncryptPassword(Password);
            temp.DisplayName = DisplayName;
            temp.ID_Role = idrole;

            ManageAccountDAL mad = new ManageAccountDAL();
            mad.AddAccountDAL(temp);
        }

        //Chuyển từ PassWord sang HashPassWord
        public string EncryptPassword(string Password)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            return BCrypt.Net.BCrypt.HashPassword(Password, salt);
        }

        public void UpdatePassword(string Password, string Username)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            mad.UpdatePassword(EncryptPassword(Password), Username);
        }

        public bool CheckValidInfo(string UserName, string PassWord)
        {
            if (UserName == "" && PassWord == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                return false;
            }
            else if (UserName == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return false;
            }
            else if (PassWord == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
