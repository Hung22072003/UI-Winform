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

    }
}
