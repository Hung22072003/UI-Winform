﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Forms;
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
                new DataColumn {ColumnName = "Tổng tiền", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tổng tiền sau khi giảm", DataType = typeof(string)},
            });
        }

        public decimal? getTotalPriceOfOrders(List<string> list)
        {
            decimal? total = 0;
            ManageOrderDAL mod = new ManageOrderDAL();
            List<Order> orders = mod.getAllOrder();
            orders.ForEach(o =>
            {
                if (list.Contains(o.OrderID))
                {
                    total += o.FinalTotal;
                }
            });
            return total;
        }
        public DataTable getAllOrderByTime(DateTime startDate, DateTime endDate)
        {
            dt.Rows.Clear();
            ManageOrderDAL mod = new ManageOrderDAL();
            List<Order> orders = mod.getAllOrder(startDate, endDate);
            orders.ForEach(p =>
            {
                dt.Rows.Add(p.OrderID, p.Staff.Name, p.Customer.Name, p.Customer.Phone, p.OrderDate, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.TotalPrice), string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.FinalTotal));
            });
            return dt;
        }

        public DataTable getAllOrderBySearch(string search)
        {
            dt.Rows.Clear();
            ManageOrderDAL mod = new ManageOrderDAL();
            List<Order> orders = mod.getAllOrder();
            orders.ForEach(p =>
            {
                if (p.Staff.Name.Contains(search))
                {
                    dt.Rows.Add(p.OrderID, p.Staff.Name, p.Customer.Name, p.Customer.Phone, p.OrderDate, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.TotalPrice), string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.FinalTotal));
                }
            });
            return dt;
        }
        public DataTable getOrderstoDGV(DateTime startDate, DateTime endDate, string ID_Staff)
        {
            ManageOrderDAL mod = new ManageOrderDAL();
            dt.Clear();
            mod.getAllOrderOfStaff(startDate, endDate, ID_Staff).ForEach(p =>
            {
                dt.Rows.Add(p.OrderID, p.Staff.Name, p.Customer.Name, p.Customer.Phone, p.OrderDate, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.TotalPrice), string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.FinalTotal));
            });

            return dt;
        }

        public DataTable getOrdersBySearch(string search, string ID_Staff)
        {
            ManageOrderDAL mod = new ManageOrderDAL();
            dt.Clear();

            mod.getAllOrderOfStaff(ID_Staff).ForEach(p =>
            {
                if (p.Customer.Phone == search || p.Customer.Name.Contains(search))
                {
                    dt.Rows.Add(p.OrderID, p.Staff.Name, p.Customer.Name, p.Customer.Phone, p.OrderDate, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.TotalPrice), string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", p.FinalTotal));
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

        public List<int> getListYear()
        {
            ManageOrderDAL mod = new ManageOrderDAL();
            List<int> list = new List<int>();
            mod.getAllOrder().ForEach(p =>
            {
                list.Add(p.OrderDate.Year);
            });
            return list.Distinct().ToList();
        }

        public bool CheckSameOrder(string ID_Order)
        {
            ManageOrderDAL mod = new ManageOrderDAL();
            if (mod.getOrderByID(ID_Order) != null)
            {
                return true;
            }else return false;
        }

        public int CheckBonusPointBLL(String bonusPoint)
        {

            if (bonusPoint == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(bonusPoint);
            }

        }

        /*Them ham nay*/
        public String CheckIDVoucher(String ID_Voucher)
        {

            if (ID_Voucher == "")
            {
                return null;

            }
            else
            {
                return ID_Voucher;
            }

        }

        /*Them ham nay*/
        public double CheckTotalDiscountBLL(String TotalDiscount)
        {

            if (TotalDiscount == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(TotalDiscount);
            }

        }

        public bool CheckEmptyInfor(string ID_Order, string NameCus, string Address, string Phone, string Quantity)
        {
            if (ID_Order == ""
                || NameCus == ""
                || Address == ""
                || Phone == ""
                || Quantity == ""
                )
            {
                MessageBox.Show("Vui Lòng nhập đầy đủ thông tin");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
