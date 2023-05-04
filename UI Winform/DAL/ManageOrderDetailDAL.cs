using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageOrderDetailDAL
    {
        public void AddOrderDetailDAL(OrderDetail temp)
        {
            using (DBPM db = new DBPM())
            {
                db.OrderDetails.Add(temp);
                db.SaveChanges();
            }
        }

        public List<OrderDetail> getListOrderDetailByIdOrder(string ID_Order)
        {
            DBPM db = new DBPM();
            var s = db.OrderDetails.Where(p => p.ID_Order == ID_Order).Select(p=>p).ToList();
            return s;
        }
    }
}
