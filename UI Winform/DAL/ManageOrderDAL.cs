using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageOrderDAL
    {
        public Order getOrderByID(string ID_Order)
        {
            DBPM db = new DBPM();
            var s = db.Orders.Where(p => p.OrderID == ID_Order).SingleOrDefault();
            return s;
        }
        public List<Order> getAllOrder()
        {
            DBPM db = new DBPM();
            var s = db.Orders.Select(p => p).ToList();
            return s;
        }
        public List<Order> getAllOrder(DateTime startDate, DateTime endDate)
        {
            DBPM db = new DBPM();
            var s = db.Orders.Where(p => startDate <= p.OrderDate && p.OrderDate <= endDate).Select(p => p).ToList();
            return s;
        }

        public List<Order> getAllOrder(int Year)
        {
            DBPM db = new DBPM();
            var s = db.Orders.Where(p => p.OrderDate.Year == Year).Select(p => p).ToList();
            return s;
        }
        public dynamic getAllOrderOfStaff(DateTime startDate, DateTime endDate, string ID_Staff)
        {
            DBPM db = new DBPM();
            var orders = db.Orders.Where(p => startDate < p.OrderDate && p.OrderDate < endDate && p.ID_Staff == ID_Staff).Select(p => p).ToList();
            List<OrderDGV> list = new List<OrderDGV>();
            orders.ForEach(order => {
                decimal? total = 0;
                order.OrderDetails.Select(p => new { p.AmountPrice }).ToList().ForEach(c =>
                {
                    total += c.AmountPrice;
                });

                OrderDGV orderDGV = new OrderDGV
                {
                    ID_Order = order.OrderID,
                    NameStaff = order.Staff.Name,
                    NameCustomer = order.Customer.Name,
                    PhoneCustomer = order.Customer.Phone,
                    OrderDate = order.OrderDate,
                    Total = total,
                };

                list.Add(orderDGV);
            });
            return list;
        }

        public dynamic getAllOrderOfStaff(string ID_Staff)
        {
            DBPM db = new DBPM();
            var orders = db.Orders.Where(p => p.ID_Staff == ID_Staff).Select(p => p).ToList();
            List<OrderDGV> list = new List<OrderDGV>();
            orders.ForEach(order => {
                decimal? total = 0;
                order.OrderDetails.Select(p => new { p.AmountPrice }).ToList().ForEach(c =>
                {
                    total += c.AmountPrice;
                });

                OrderDGV orderDGV = new OrderDGV
                {
                    ID_Order = order.OrderID,
                    NameStaff = order.Staff.Name,
                    NameCustomer = order.Customer.Name,
                    PhoneCustomer = order.Customer.Phone,
                    OrderDate = order.OrderDate,
                    Total = total,
                };

                list.Add(orderDGV);
            });
            return list;
        }

        public void AddOrder(Order temp)
        {

            using (DBPM db = new DBPM())
            {
                db.Orders.Add(temp);
                db.SaveChanges();
            }
        }
    }
}
