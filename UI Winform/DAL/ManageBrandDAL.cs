using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageBrandDAL
    {
        public List<Brand> getAllBrands()
        {
            DBPM db = new DBPM();
            var s = db.Brands.Select(p =>p).ToList();
            return s;
        }

        public List<string> getAllIDBrands()
        {
            DBPM db = new DBPM();
            return db.Brands.Select(p => p.BrandID).ToList();
        }

        public void AddBrand(Brand b)
        {
            DBPM db = new DBPM();
            db.Brands.Add(b);
            db.SaveChanges();
        }
    }
}
