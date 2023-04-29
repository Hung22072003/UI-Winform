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

        public Account GetAccountByIDDAL(string id)
        {

            using (DBPM db = new DBPM())
            {
                Account s = db.Accounts.Where(p => p.ID_Staff == id).FirstOrDefault();
                return s;
            }

        }

        public void DeleteAccountById_StaffDAL(String id)
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Accounts.Where(p => p.ID_Staff == id).FirstOrDefault();
                db.Accounts.Remove(s);
                db.SaveChanges();
            }

        }

        public void UpdateAccountDAL(Account temp)
        {
            using (DBPM db = new DBPM())
            {
                var a = db.Accounts.Find(temp.UserName);

                a.UserName = temp.UserName;


                a.PassWord = temp.PassWord;
                a.TypeAccount = temp.TypeAccount;

                db.SaveChanges();
            }
        }

        public void AddAccountDAL(Account temp)
        {

            using (DBPM db = new DBPM())
            {
                db.Accounts.Add(temp);
                db.SaveChanges();

            }

        }

    }
}
