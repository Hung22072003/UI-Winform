using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageItemBLL
    {
        DataTable dt;
        public ManageItemBLL()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Mã sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tên sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Số lượng", DataType = typeof(int)},
                new DataColumn {ColumnName = "Giá bán", DataType = typeof(string)},
                new DataColumn {ColumnName = "Giá gốc", DataType = typeof(string)},
                new DataColumn {ColumnName = "Khuyến mãi", DataType = typeof(float)},
                new DataColumn {ColumnName = "Thời hạn bảo hành", DataType = typeof(int)},
                new DataColumn {ColumnName = "Loại sản phẩm", DataType = typeof(string)},
                new DataColumn {ColumnName = "Hãng", DataType = typeof(string)}
            });
        }

        public DataTable getAllItemDGV()
        {
            dt.Rows.Clear();
            ManageItemDAL mid = new ManageItemDAL();
            mid.getAllItems().ForEach(i =>
            {
                dt.Rows.Add(i.IDItem, i.ItemName, i.Quantity, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.SellPrice), string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.InitialPrice), i.Discount, i.Warranty, i.Category.NameCategory, i.Brand.BrandName);
            });
            return dt;
        }

        public string setNewIDItem()
        {
            ManageItemDAL mid = new ManageItemDAL();
            Random rand = new Random();
            int index;
            while (true)
            {
                index = rand.Next(100000, 1000000);
                if (!mid.getListIDItem().Contains(index.ToString())) break;
            }
            return index.ToString();
        }

        public Item getItemByID(string ID_Item) {
            ManageItemDAL mid = new ManageItemDAL();
            return mid.getItemByID(ID_Item);
        }
        public DataTable getItemsBySearch(string searchName, string searchBrand, string searchCategory)
        {
            dt.Rows.Clear();
            ManageItemDAL mid = new ManageItemDAL();
            mid.getItemsBySearch(searchName, searchBrand, searchCategory).ForEach(i =>
            {
                dt.Rows.Add(i.IDItem, i.ItemName, i.Quantity, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.SellPrice), string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.InitialPrice), i.Discount, i.Warranty, i.Category.NameCategory, i.Brand.BrandName);
            });
            return dt;
        }

        public void AddUpdateItem(string iditem, string itemName, decimal sellprice, decimal initialprice, float discount, string itemdetail, Image itemimage, int warranty, string idbrand, string idcategory, int quantity)
        {
            Item item = new Item
            {
                IDItem = iditem,
                ItemName = itemName,
                SellPrice = sellprice,
                InitialPrice = initialprice,
                Discount = discount,
                ItemDetail = itemdetail,
                Warranty = warranty,
                ID_Brand = idbrand,
                ID_Category = idcategory,
                Quantity = quantity
            };
            if (itemimage != null)
            {
                MemoryStream memory = new MemoryStream();
                itemimage.Save(memory, ImageFormat.Jpeg);
                item.Picture = memory.ToArray();
            }
            ManageItemDAL mid = new ManageItemDAL();
            if (mid.getItemByID(iditem) != null)
            {
                mid.UpdateItem(item);
            }
            else
            {
                item.Deleted = false;
                mid.AddItem(item);
            }   
        }

        public void UpdateQuantityItem(string id_item, int quantity)
        {
            ManageItemDAL mid = new ManageItemDAL();
            Item i = mid.getItemByID(id_item);
            if (i != null)
            {
                mid.UpdateQuantityItem(id_item, i.Quantity + quantity);
            }
        }

        public void RemoveItem(string iditem)
        {
            ManageItemDAL mid = new ManageItemDAL();
            mid.RemoveItem(iditem);
        }

        public List<Item> GetListItem(List<string> li)
        {
            ManageItemDAL mid = new ManageItemDAL();
            List<Item> data = new List<Item>();
            foreach (string i in li)
            {
                foreach (Item j in mid.getAllItems())
                {
                    if (i == j.IDItem)
                    {
                        data.Add(j);
                    }
                }

            }
            return data;
        }

        public delegate bool Compare(object o1, object o2);
        public static void SortAscending(ref List<Item> listItems, Compare cmp)
        {
            for (int i = 0; i < listItems.Count - 1; i++)
            {
                for (int j = i + 1; j < listItems.Count; j++)
                {
                    if (cmp(listItems[i], listItems[j]))
                    {
                        Item temp = listItems[i];
                        listItems[i] = listItems[j];    
                        listItems[j] = temp;
                    }
                }
            }
        }

        public static void SortDescending(ref List<Item> listItems, Compare cmp)
        {
            for (int i = 0; i < listItems.Count - 1; i++)
            {
                for (int j = i + 1; j < listItems.Count; j++)
                {
                    if (!cmp(listItems[i], listItems[j]))
                    {
                        Item temp = listItems[i];
                        listItems[i] = listItems[j];
                        listItems[j] = temp;
                    }
                }
            }
        }
        public DataTable SortBy(List<string> li, string s1, string s2)
        {
            dt.Rows.Clear();
            List<Item> data = GetListItem(li);
            if (s1 == "Số lượng" && s2 == "Tăng dần")
            {
                SortAscending(ref data, Item.CompareQuantity);
            }
            else if (s1 == "Số lượng" && s2 == "Giảm dần")
            {
                SortDescending(ref data, Item.CompareQuantity);
            }
            else if (s1 == "Mã sản phẩm" && s2 == "Tăng dần")
            {
                SortAscending(ref data, Item.CompareID);
            }
            else if (s1 == "Mã sản phẩm" && s2 == "Giảm dần")
            {
                SortDescending(ref data, Item.CompareID);
            }

            data.ForEach(i =>
            {
                dt.Rows.Add(i.IDItem, i.ItemName, i.Quantity, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.SellPrice), string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", i.InitialPrice), i.Discount, i.Warranty, i.Category.NameCategory, i.Brand.BrandName);
            });
            return dt;
        }

        public bool CheckCbbCategory(string text)
        {
            ManageCategoryBLL mcb = new ManageCategoryBLL();
            for (int i = 0; i < mcb.getCBBCategory().Count; i++)
            {
                if (mcb.getCBBCategory()[i].Text == text) return true;
            }
            return false;
        }

        public bool CheckCbbBrand(string text)
        {
            ManageBrandBLL mbb = new ManageBrandBLL();
            for (int i = 0; i < mbb.getCBBBrand().Count; i++)
            {
                if (mbb.getCBBBrand()[i].Text == text) return true;
            }
            return false;
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

        public bool CheckValidInfo(string ID_Item, string ItemName, string Detail, string IniPrice, string Quantity, string SellPrice, string Warranty, string Brand, string Category)
        {
            if (ID_Item != "" && ItemName != "" && Detail != "" && IniPrice != ""
                && Quantity != "" && SellPrice != "" && Warranty != "")
            {
                if (IsNumber(IniPrice) && IsNumber(SellPrice))
                {
                    if (CheckCbbBrand(Brand) && CheckCbbCategory(Category))
                    {
                        return true;
                    } else
                    {
                        MessageBox.Show("Vui lòng lựa chọn đúng hãng và loại sản phẩm!");
                        return false;
                    }
                }else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
        }
    }
}
