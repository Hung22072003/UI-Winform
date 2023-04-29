using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageStaff_ShiftDAL
    {
        public dynamic GetStaff_ShiftDAL(string IDStaff)
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Shifts
                    .SelectMany(sh => sh.Staffs, (sh, st) => new { Staff = st, Shift = sh })
                    .Where(a => a.Staff.ID_Staff == IDStaff)
                    .Select(stsh => new { stsh.Staff.ID_Staff, stsh.Shift.ID_Shift }).ToList();
                return s;
            }
        }

        public void DeleteByID_StaffDAL(string IDStaff, int ID_Shift)
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.ID_Staff == IDStaff).Select(p => p).FirstOrDefault();
                s.Shifts.Remove(db.Shifts.Where(p => p.ID_Shift == ID_Shift).Select(p => p).FirstOrDefault());

                db.SaveChanges();
            }
        }

        public void AddByID_StaffDAL(string ID_Staff, int ID_Shift)
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.ID_Staff == ID_Staff).Select(p => p).FirstOrDefault();
                s.Shifts.Add(db.Shifts.Where(p => p.ID_Shift == ID_Shift).Select(p => p).FirstOrDefault());
                db.SaveChanges();
            }
        }
    }
}
