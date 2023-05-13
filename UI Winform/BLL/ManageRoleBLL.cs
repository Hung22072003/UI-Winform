using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;
namespace UI_Winform.BLL
{
    public class ManageRoleBLL
    {
        public int getIDRoleByNameRole(string nameRole)
        {
            ManageRoleDAL mrd = new ManageRoleDAL();
            return mrd.getIDRoleByNameRole(nameRole);
        }

        public string getNameRoleByIDRole(int? id_role)
        {
            ManageRoleDAL mrd = new ManageRoleDAL();
            return mrd.getNameRoleByIDRole(id_role);
        }

        public List<Role> getAllRoles( )
        {
            ManageRoleDAL mrd = new ManageRoleDAL();
            return mrd.getAllRoles( );
        }

        public List<CbbTypeAccount> GetCbbTypeAccounts( ) { 
            List<CbbTypeAccount> list = new List<CbbTypeAccount> ();
            getAllRoles().ForEach(p =>
            {
                list.Add(new CbbTypeAccount
                {
                    value = p.ID_Role,
                    text = p.NameRole
                });
            });
            return list;
        }
    }
}
