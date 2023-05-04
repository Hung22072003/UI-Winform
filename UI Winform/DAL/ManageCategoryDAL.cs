using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageCategoryDAL
    {
        public List<Category> getAllCategory()
        {
            DBPM db = new DBPM();
            var s = db.Categories.Select(p => p).ToList();
            return s;
        }
    }
}
