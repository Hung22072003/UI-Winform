using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public bool CheckIDBrand(string id)
        {
            ManageBrandDAL mbd = new ManageBrandDAL();
            if (mbd.getAllIDBrands().Contains(id))
            {
                MessageBox.Show("Vui lòng nhập lại mã");
                return false;
            }else
            {
                return true;
            }
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

        public void AddBrand(string id, string name)
        {
            if (CheckIDBrand(id))
            {
                ManageBrandDAL mbd = new ManageBrandDAL();
                Brand b = new Brand
                {
                    BrandID = id,
                    BrandName = name
                };
                mbd.AddBrand(b);
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
