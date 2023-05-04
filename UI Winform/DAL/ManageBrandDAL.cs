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
    }
}
