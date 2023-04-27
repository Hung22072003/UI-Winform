using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;
namespace UI_Winform.DAL
{
    internal class ManageRevenueDAL
    {
        public List<Order> getAllOrder(DateTime startDate, DateTime endDate)
        {
            DBPM db = new DBPM();
            var s = db.Orders.Where(p => startDate < p.OrderDate && p.OrderDate < endDate).Select(p => p).ToList();
            return s;
        }

        public List<Order> getAllOrder(int Year)
        {
            DBPM db = new DBPM();
            var s = db.Orders.Where(p => p.OrderDate.Year == Year).Select(p => p).ToList();
            return s;
        }
    }
}
