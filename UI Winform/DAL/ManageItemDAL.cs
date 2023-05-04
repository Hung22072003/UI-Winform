using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageItemDAL
    {
        public List<Item> getAllItems() {
            DBPM db = new DBPM();
            var s = db.Items.Select(p => p).ToList();
            return s;
        }

        public Item getItemByID(string ID_Item)
        {
            DBPM db = new DBPM();
            var s = db.Items.Where(p => p.IDItem == ID_Item).SingleOrDefault();
            return s;
        }

        public bool chechIdItem(string Id_Item)
        {
            DBPM db = new DBPM();
            var s = db.Items.Where (p => p.IDItem ==  Id_Item).SingleOrDefault();
            if (s != null) return true;
            else return false;
        }

        public List<Item> getItemsBySearch(string searchName, string searchBrand, string searchCategory) {
            DBPM db = new DBPM();
            if (searchBrand == "" && searchCategory == "")
            {
                return db.Items.Where(p => p.ItemName.Contains(searchName)).Select(p=>p).ToList();
            } else if (searchBrand == "")
            {
                return db.Items.Where(p => p.ItemName.Contains(searchName) && p.Category.NameCategory == searchCategory).Select(p => p).ToList();
            }
            else if (searchCategory == "")
            {
                return db.Items.Where(p => p.ItemName.Contains(searchName) && p.Brand.BrandName == searchBrand).Select(p => p).ToList();
            } else
            {
                return db.Items.Where(p => p.ItemName.Contains(searchName) && p.Brand.BrandName == searchBrand && p.Category.NameCategory == searchCategory).Select(p => p).ToList();
            }
        }

        public void AddItem(Item item)
        {
            using(DBPM db = new DBPM())
            {
                db.Items.Add(item);
                db.SaveChanges();
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
                db.Items.Remove(db.Items.Find(ID_Item));
                db.SaveChanges();
            }
        }
    }
}
