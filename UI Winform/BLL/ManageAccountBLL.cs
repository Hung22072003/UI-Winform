using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;
namespace UI_Winform.BLL
{
    internal class ManageAccountBLL
    {
        public string getTypeAccount(string UserName, string PassWord)
        {
            ManageRoleBLL mrb = new ManageRoleBLL();
            ManageAccountDAL mad = new ManageAccountDAL();
            foreach (Account i in mad.getAllAccounts())
            {
                if (i.UserName == UserName && i.PassWord == PassWord)
                {
                    return mrb.getNameRoleByIDRole(i.ID_Role);
                }
            }
            return null;
        }

        public string getIDUserByAccount(string UserName, string PassWord)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            foreach (Account i in mad.getAllAccounts())
            {
                if (i.UserName == UserName && i.PassWord == PassWord)
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

        public void UpdateAccountBLL(string ID_Staff, string UserName, string Password, int idrole)
        {
            Account temp = new Account();

            temp.ID_Staff = ID_Staff;
            temp.UserName = UserName;
            temp.PassWord = Password;
            temp.ID_Role = idrole;

            ManageAccountDAL mad = new ManageAccountDAL();
            mad.UpdateAccountDAL(temp);
        }

        public void AddAccountBLL(string ID_Staff, string DisplayName, string UserName, string Password, int idrole)
        {
            Account temp = new Account();

            temp.ID_Staff = ID_Staff;
            temp.UserName = UserName;
            temp.PassWord = Password;
            temp.DisplayName = DisplayName;
            temp.ID_Role = idrole;

            ManageAccountDAL mad = new ManageAccountDAL();
            mad.AddAccountDAL(temp);
        }
    }
}
