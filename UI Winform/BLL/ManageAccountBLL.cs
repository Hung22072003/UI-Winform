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
        public int getTypeAccount(string UserName, string PassWord)
        {
            ManageAccountDAL mad = new ManageAccountDAL();
            foreach (Account i in mad.getAllAccounts())
            {
                if (i.UserName == UserName && i.PassWord == PassWord)
                {
                    return i.TypeAccount;
                }
            }
            return -1;
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

        public void UpdateAccountBLL(string ID_Staff, string UserName, string Password, bool TypeAccount)
        {
            Account temp = new Account();

            temp.ID_Staff = ID_Staff;
            temp.UserName = UserName;
            temp.PassWord = Password;
            temp.TypeAccount = Convert.ToInt32(TypeAccount);

            ManageAccountDAL mad = new ManageAccountDAL();
            mad.UpdateAccountDAL(temp);
        }

        public void AddAccountBLL(string ID_Staff, string DisplayName, string UserName, string Password, bool TypeAccount)
        {
            Account temp = new Account();

            temp.ID_Staff = ID_Staff;
            temp.UserName = UserName;
            temp.PassWord = Password;
            temp.DisplayName = DisplayName;
            temp.TypeAccount = Convert.ToInt32(TypeAccount);

            ManageAccountDAL mad = new ManageAccountDAL();
            mad.AddAccountDAL(temp);
        }
    }
}
