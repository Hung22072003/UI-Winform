using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;
namespace UI_Winform.BLL
{
    public class ManageOrderBLL
    {
        private DataTable dt;
        public ManageOrderBLL()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Mã hóa đơn", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tên nhân viên", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tên khách hàng", DataType = typeof(string)},
                new DataColumn {ColumnName = "SĐT", DataType = typeof(string)},
                new DataColumn {ColumnName = "Ngày tạo hóa đơn", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Tổng tiền", DataType = typeof(decimal)},
            });
        }
        public DataTable getOrderstoDGV(DateTime startDate, DateTime endDate, string ID_Staff)
        {
            ManageOrderDAL mod = new ManageOrderDAL();
            dt.Clear();
            List<OrderDGV> list = mod.getAllOrderOfStaff(startDate, endDate, ID_Staff);
            list.ForEach(p =>
            {
                dt.Rows.Add(p.ID_Order, p.NameStaff, p.NameCustomer, p.PhoneCustomer, p.OrderDate, p.Total);
            });

            return dt;
        }

        public DataTable getOrdersBySearch(string search, string ID_Staff)
        {
            ManageOrderDAL mod = new ManageOrderDAL();
            dt.Clear();
            List<OrderDGV> list = mod.getAllOrderOfStaff(ID_Staff);

            list.ForEach(p =>
            {
                if (p.ID_Order == search || p.PhoneCustomer == search || p.NameCustomer.Contains(search))
                {
                    dt.Rows.Add(p.ID_Order, p.NameStaff, p.NameCustomer, p.PhoneCustomer, p.OrderDate, p.Total);
                }
            });

            return dt;
        }

        public void AddOrder(Order temp)
        {

            ManageOrderDAL mod = new ManageOrderDAL();

            mod.AddOrder(temp);

        }

        public string SetIDOrder()
        {
            string id_order;
            ManageOrderDAL mod = new ManageOrderDAL();
            id_order = "HĐ" + (mod.getAllOrder().Count + 1).ToString();
            return id_order;
        }

        public Order getOrderByID(string ID_Order)
        {
            ManageOrderDAL mod = new ManageOrderDAL();
            return mod.getOrderByID(ID_Order);
        }
    }
}
