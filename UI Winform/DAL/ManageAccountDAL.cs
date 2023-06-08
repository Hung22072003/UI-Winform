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

        public int? getIDRoleByUserName(string userName)
        {
            DBPM db = new DBPM();
            Account s = db.Accounts.Where(p => p.UserName == userName).FirstOrDefault();
            return s.ID_Role;
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
                a.ID_Role = temp.ID_Role;
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

        public void UpdatePassword(string hashPassword, string Username) {
            using (DBPM db = new DBPM())
            {
                var a = db.Accounts.Find(Username);
                a.PassWord = hashPassword;
                db.SaveChanges();
            }
        }
    }
}
