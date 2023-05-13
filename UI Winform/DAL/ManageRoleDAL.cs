using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageRoleDAL
    {
        public int getIDRoleByNameRole(string nameRole)
        {
            using(DBPM db = new DBPM())
            {
                Role r = db.Roles.Where(p =>  p.NameRole == nameRole).FirstOrDefault();
                return r.ID_Role;
            }
        }

        public List<Role> getAllRoles()
        {
            using( DBPM db = new DBPM())
            {
                var s = db.Roles.Select(p =>p).ToList();
                return s;
            }
        }

        public string getNameRoleByIDRole(int? id_role)
        {
            using (DBPM db = new DBPM())
            {
                Role r = db.Roles.Where(p => p.ID_Role == id_role).FirstOrDefault();
                return r.NameRole;
            }
        }
    }
}
