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

        public bool CheckIDCategory(string id)
        {
            ManageCategoryDAL mcd = new ManageCategoryDAL();
            if (mcd.getAllIDCategories().Contains(id))
            {
                MessageBox.Show("Vui lòng nhập lại mã");
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddCategory(string id, string name)
        {
            if (CheckIDCategory(id))
            {
                ManageCategoryDAL mcd = new ManageCategoryDAL();
                Category c = new Category
                {
                    ID_Category = id,
                    NameCategory = name
                };
                mcd.AddCategory(c);
                MessageBox.Show("Thêm thành công");
            }
        }
    }
}
