using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageItemDAL
    {
        public List<Item> getAllItems()
        {
            DBPM db = new DBPM();
            var s = db.Items.Where(p => p.Deleted == false).Select(p => p).ToList();
            return s;
        }

        public List<string> getListIDItem()
        {
            List<string> list = new List<string>(); 
            DBPM db = new DBPM();
            db.Items.Select(p => new {p.IDItem}).ToList().ForEach(p =>
            {
                list.Add(p.IDItem);
            });
            return list;
        }
        public Item getItemByID(string ID_Item)
        {
            DBPM db = new DBPM();
            var s = db.Items.Where(p => p.IDItem == ID_Item && p.Deleted == false).SingleOrDefault();
            return s;
        }

        public bool checkIdItem(string Id_Item)
        {
            DBPM db = new DBPM();
            var s = db.Items.Where (p => p.IDItem ==  Id_Item).SingleOrDefault();
            if (s != null) return true;
            else return false;
        }

        public List<Item> getItemsBySearch(string search, string searchBrand, string searchCategory) {
            DBPM db = new DBPM();
            if (searchBrand == "" && searchCategory == "")
            {
                return db.Items.Where(p => (p.ItemName.Contains(search) || p.IDItem.Contains(search)) && p.Deleted == false).Select(p=>p).ToList();
            } else if (searchBrand == "")
            {
                return db.Items.Where(p => (p.ItemName.Contains(search) || p.IDItem.Contains(search)) && p.Category.NameCategory == searchCategory && p.Deleted == false).Select(p => p).ToList();
            }
            else if (searchCategory == "")
            {
                return db.Items.Where(p => (p.ItemName.Contains(search) || p.IDItem.Contains(search)) && p.Brand.BrandName == searchBrand && p.Deleted == false).Select(p => p).ToList();
            } else
            {
                return db.Items.Where(p => (p.ItemName.Contains(search) || p.IDItem.Contains(search)) && p.Brand.BrandName == searchBrand && p.Category.NameCategory == searchCategory && p.Deleted == false).Select(p => p).ToList();
            }
        }

        public void AddItem(Item item)
        {
            using(DBPM db = new DBPM())
            {
                int result = 0;
                db.Items.Select(p => p).ToList().ForEach(i =>
                {
                    if (i.IDItem == item.IDItem)
                    {
                        result = 1;
                    }
                });

                if (result == 0) {
                    db.Items.Add(item);
                    db.SaveChanges();
                }

            }
        }

        public void UpdateItem(Item item)
        {
            using (DBPM db = new DBPM())
            {
                Item i = db.Items.Find(item.IDItem);
                if (i != null)
                {
                    i.ItemName = item.ItemName;
                    i.SellPrice = item.SellPrice;
                    i.InitialPrice = item.InitialPrice;
                    i.Quantity = item.Quantity;
                    i.Picture = item.Picture;
                    i.Discount = item.Discount;
                    i.ItemDetail = item.ItemDetail;
                    i.ID_Brand = item.ID_Brand;
                    i.ID_Category = item.ID_Category;
                    i.Warranty = item.Warranty;
                    db.SaveChanges();
                };
            }
        }

        public void UpdateQuantityItem(string ID_Item, int quantity)
        {
            using (DBPM db = new DBPM())
            {
                Item i = db.Items.Find(ID_Item);
                if (i != null)
                {
                    i.Quantity = quantity;
                    db.SaveChanges();
                };
            }
        }

        public void RemoveItem(string ID_Item)
        {
            using (DBPM db = new DBPM())
            {
                Item i = db.Items.Find(ID_Item);
                i.Deleted = true;
                db.SaveChanges();
            }
        }
    }
}
