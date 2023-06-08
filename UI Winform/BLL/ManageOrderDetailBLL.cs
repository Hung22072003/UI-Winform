using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;
using UI_Winform.DAL;
using System.Globalization;

namespace UI_Winform.BLL
{
    public class ManageOrderDetailBLL
    {
        public void AddOrderDetailBLL(OrderDetail temp)
        {
            ManageOrderDetailDAL modd = new ManageOrderDetailDAL();
            modd.AddOrderDetailDAL(temp);
        }

        public List<ViewOrderDetail> GetOrderDetailList(string ID_Order) {
            List<ViewOrderDetail> list = new List<ViewOrderDetail>();
            ManageOrderDetailDAL modd = new ManageOrderDetailDAL();
            modd.getListOrderDetailByIdOrder(ID_Order).ForEach(p =>
            {
                ViewOrderDetail viewOrderDetail = new ViewOrderDetail
                {
                    ID_Item = p.ID_Item,
                    NameItem = p.Item.ItemName,
                    Quantity = p.Quantity,
                    UnitPrice = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.UnitPrice),
                    AmountPrice = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.AmountPrice),
                };
                list.Add(viewOrderDetail);
            });
            return list;
        }
    }
}
