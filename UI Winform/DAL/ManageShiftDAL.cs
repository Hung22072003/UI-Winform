using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageShiftDAL
    {
        public List<Shift> GetAllShiftDAL()
        {
            List<Shift> result = new List<Shift>();

            using (DBPM db = new DBPM())
            {
                result = db.Shifts.Select(s => s).ToList();
            }

            return result;
        }
    }
}
