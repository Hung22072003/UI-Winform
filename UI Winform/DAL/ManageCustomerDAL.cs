using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageCustomerDAl
    {
        public List<Customer> GetCustomersBySearch(string search)
        {
            using (DBPM db = new DBPM())
            {
                return db.Customers.Where(p => p.Name.Contains(search) || p.Phone.Contains(search)).Select(p => p).ToList();
            }
        }
        public Customer GetCustomerByID(int id)
        {
            Customer temp = new Customer();

            using (DBPM db = new DBPM())
            {
                temp = db.Customers.Where(p => p.ID_Customer == id).Select(p => p).FirstOrDefault();
            }

            return temp;
        }

        public Customer GetCustomerByPhoneDAL(string phone)
        {
            Customer temp = new Customer();
            using (DBPM db = new DBPM())
            {
                temp = db.Customers.Where(p => p.Phone == phone).Select(p => p).FirstOrDefault();
            }
            return temp;
        }

        public List<int> GetAllIDCustomerDAL()
        {
            using (DBPM db = new DBPM())
            {
                List<int> list = new List<int>();
                list = db.Customers.Select(P => P.ID_Customer).ToList();
                return list;

            }
        }

        public List<Customer> GetAllCustomerDAL()
        {

            List<Customer> temp = new List<Customer>();

            using (DBPM db = new DBPM())
            {
                temp = db.Customers.Select(p => p).ToList();
            }

            return temp;

        }

        public void AddCustomerDAL(Customer temp)
        {

            using (DBPM db = new DBPM())
            {
                db.Customers.Add(temp);
                db.SaveChanges();
            }

        }

        public void UpdateCustomerDAL(Customer temp)
        {
            using (DBPM db = new DBPM())
            {
                Customer c = db.Customers.Find(temp.ID_Customer);
                c.Name = temp.Name;
                c.Phone = temp.Phone;
                c.Address = temp.Address;
                c.BonusPoint = temp.BonusPoint;
                db.SaveChanges();
            }
        }

        public void UpdateBonusPointCustomerDAL(int BonusPoint, int id)
        {
            using (DBPM db = new DBPM())
            {
                Customer cus = db.Customers.Find(id);
                cus.BonusPoint += BonusPoint;
                db.SaveChanges();
            }
        }
    }
}
