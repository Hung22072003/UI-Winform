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
    }
}
