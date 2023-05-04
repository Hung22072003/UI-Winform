using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageExpenditureBLL
    {
        public DataTable getItemsToDGV(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Mã hàng", DataType = typeof(string)},
                new DataColumn {ColumnName = "Mã sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tên sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Ngày nhập", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Số lượng", DataType = typeof(int)},
                new DataColumn {ColumnName = "Giá nhập", DataType = typeof(decimal)},
                new DataColumn {ColumnName = "Tổng tiền", DataType = typeof(decimal)},
            });

            ManageExpenditureDAL med = new ManageExpenditureDAL();
            foreach(Storage s in med.getItems(startDate, endDate))
            {
                dt.Rows.Add(s.ID_Storage, s.ID_Item, s.Item.ItemName, s.ImportDate, s.Quantity, s.UnitPrice, s.TotalPrice);
            }

            return dt;
        }

        public void AddSpendingBill(string ID_Item, DateTime importDate, int quantity, decimal unitPrice, decimal totalPrice) {
            Storage s = new Storage
            {
                ID_Item = ID_Item,
                ImportDate = importDate,
                Quantity = quantity,
                UnitPrice = unitPrice,
                TotalPrice = totalPrice
            };
            ManageExpenditureDAL med = new ManageExpenditureDAL();
            med.AddSpendingBill(s);
        }
    }
}
