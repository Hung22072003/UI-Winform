using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageCategoryBLL
    {
        public List<CbbCategory> getCBBCategory()
        {
            List<CbbCategory> list = new List<CbbCategory>();

            ManageCategoryDAL mcd = new ManageCategoryDAL();
            mcd.getAllCategory().ForEach(p =>
            {
                list.Add(new CbbCategory
                {
                    Value = p.ID_Category,
                    Text = p.NameCategory
                });
            });
            return list;
        }
    }
}
