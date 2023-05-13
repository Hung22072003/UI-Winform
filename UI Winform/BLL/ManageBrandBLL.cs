using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageBrandBLL
    {
        public List<Brand> getAllBrands()
        {
            ManageBrandDAL mbd = new ManageBrandDAL();
            return mbd.getAllBrands();
        }

        public List<CbbBrand> getCBBBrand()
        {
            List<CbbBrand> list = new List<CbbBrand>();
            getAllBrands().ForEach(p =>
            {
                list.Add(new CbbBrand
                {
                    Value = p.BrandID,
                    Text = p.BrandName
                });
            });
            return list;    
        }
    }
}
