using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using UI_Winform.DTO;
namespace UI_Winform.DAL
{
    internal class ManageAccountDAL
    {
        public List<Account> getAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (DBPM db = new DBPM())
            {
                var s = db.Accounts.Select(p => p).ToList();
                accounts = s;
            }
            return accounts;
        }

        public int getTypeAccount(string UserName, string PassWord)
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Accounts.Where(p => p.UserName == UserName && p.PassWord == PassWord).Select(p => p).FirstOrDefault();
                if (s != null)
                {
                    return s.TypeAccount;
                } else
                {
                    return -1;
                }
            }
        }

    }
}
