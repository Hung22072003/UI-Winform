using Guna.UI2.WinForms;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;
using System.Diagnostics;

namespace UI_Winform.BLL
{
    internal class ManageRevenueBLL
    {
        public DataTable getRevenueOfCategory(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Tên sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tổng tiền", DataType = typeof(decimal)},
            });

            ManageOrderDAL mod = new ManageOrderDAL();
            List<Order> orders = mod.getAllOrder(startDate, endDate);
            orders.ForEach(p =>
            {
                var RevenueCategorys = p.OrderDetails.Select(q => new { q.Item.Category.NameCategory, q.AmountPrice }).ToList();
                RevenueCategorys.ForEach(RevenueCategory =>
                {
                    int result = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Tên sản phẩm"].ToString() == RevenueCategory.NameCategory)
                        {
                            decimal? total = Convert.ToDecimal(dr["Tổng tiền"].ToString()) + RevenueCategory.AmountPrice;
                            dr["Tổng tiền"] = total ;
                            result = 1;
                        }
                    }

                    if (result == 0)
                    {
                        dt.Rows.Add(RevenueCategory.NameCategory, RevenueCategory.AmountPrice);
                    }
                });
            });
            return dt;
        }

        public DataTable getRevenueOfYear(int year)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Tháng", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tổng tiền", DataType = typeof(string)},
            });
            for(int i = 1; i <=12; i++)
            {
                dt.Rows.Add(i.ToString(), 0);
            }

            ManageOrderDAL mod = new ManageOrderDAL();
            List<Order> orders = mod.getAllOrder(year);
            orders.ForEach(order =>
            {
                decimal? total = order.FinalTotal;
                dt.Rows[order.OrderDate.Month - 1]["Tổng tiền"] = Convert.ToDecimal(dt.Rows[order.OrderDate.Month - 1]["Tổng tiền"].ToString()) + total ;
            });

            return dt;
        }
    }
}
