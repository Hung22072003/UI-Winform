using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageCustomerBLL
    {

        public Customer GetCustomerByID(int id)
        {

            ManageCustomerDAl mcd = new ManageCustomerDAl();
            return mcd.GetCustomerByID(id);

        }

        public Customer GetCustomerByPhoneBLL(string phone)
        {
            Customer temp = new Customer();

            ManageCustomerDAl mcd = new ManageCustomerDAl();
            temp = mcd.GetCustomerByPhoneDAL(phone);
            return temp;
        }

        public bool CheckOldCustomerBLL(string IdCustomer)
        {
            ManageCustomerDAl mcd = new ManageCustomerDAl();

            foreach (int i in mcd.GetAllIDCustomerDAL())
            {
                try
                {
                    if (i == Convert.ToInt32(IdCustomer))
                    {
                        return true;
                    }
                }
                catch (FormatException)
                {

                }

            }
            return false;
        }

        public List<Customer> GetAllCustomerBLL()
        {
            List<Customer> li = new List<Customer>();

            ManageCustomerDAl mcd = new ManageCustomerDAl();
            li = mcd.GetAllCustomerDAL();

            return li;
        }

        public void AddCustomerBLL(Customer temp)
        {
            ManageCustomerDAl mcd = new ManageCustomerDAl();

            mcd.AddCustomerDAL(temp);
        }

        public void UpdateBonusPointCustomerBLL(String Total, int id)
        {
            ManageCustomerDAl mcd = new ManageCustomerDAl();
            mcd.UpdateBonusPointCustomerDAL(Convert.ToInt32(Total.Replace(".", "")) / 100000, id);
        }
    }
}
