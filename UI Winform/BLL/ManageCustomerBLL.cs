using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageCustomerBLL
    {
        public DataTable dt;

        public ManageCustomerBLL()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Mã khách hàng", DataType = typeof(int)},
                new DataColumn {ColumnName = "Tên khách hàng", DataType = typeof(string)},
                new DataColumn {ColumnName = "Số điện thoại", DataType = typeof(string)},
                new DataColumn {ColumnName = "Địa chỉ", DataType = typeof(string)},
                new DataColumn {ColumnName = "Điểm tích lũy", DataType = typeof(int)},
            });
        }

        public DataTable GetCustomersBySearch(string search)
        {
            dt.Rows.Clear();
            ManageCustomerDAl mcd = new ManageCustomerDAl();
            mcd.GetCustomersBySearch(search).ForEach(c =>
            {
                dt.Rows.Add(c.ID_Customer, c.Name, c.Phone, c.Address, c.BonusPoint);
            });
            return dt;
        }
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

        public DataTable GetAllCustomerBLL()
        {
            dt.Rows.Clear();

            ManageCustomerDAl mcd = new ManageCustomerDAl();
            mcd.GetAllCustomerDAL().ForEach(c =>
            {
                dt.Rows.Add(c.ID_Customer, c.Name, c.Phone, c.Address, c.BonusPoint);
            });

            return dt;
        }

        public void AddCustomerBLL(Customer temp)
        {
            ManageCustomerDAl mcd = new ManageCustomerDAl();

            mcd.AddCustomerDAL(temp);
        }

        public void UpdateCustomer(int ID_Cus, string Name, string Phone, string Address, int BonusPoint)
        {
            ManageCustomerDAl mcd = new ManageCustomerDAl();
            Customer customer = new Customer
            {
                ID_Customer = ID_Cus,
                Name = Name,
                Phone = Phone,
                Address = Address,
                BonusPoint = BonusPoint
            };

            if (mcd.GetCustomerByID(ID_Cus) != null)
            {
                mcd.UpdateCustomerDAL(customer);
            }
        }
        public void UpdateBonusPointCustomerBLL(String Total, int id)
        {
            ManageCustomerDAl mcd = new ManageCustomerDAl();
            mcd.UpdateBonusPointCustomerDAL(Convert.ToInt32(Total.Replace(".", "")) / 100000, id);
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public bool CheckValidInfo(string Name, string Phone, string Address, string BonusPoint)
        {
            if (Name != "" && Phone != "" && Address != "" && BonusPoint != "")
            {
                if (IsNumber(BonusPoint) && IsNumber(Phone))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng đinh dạng số!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin!");
                return false;
            }
        }
    }
}
