using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageShiftBLL
    {
        public List<CheckBoxShift> SetCheckBoxShiftBLL()
        {

            List<CheckBoxShift> result = new List<CheckBoxShift>();

            ManageShiftDAL msd = new ManageShiftDAL();

            foreach (Shift i in msd.GetAllShiftDAL())
            {
                result.Add(new CheckBoxShift { value = i.ID_Shift, text = i.TimeStart.ToString() + " - " + i.TimeEnd.ToString(), check = false });
            }

            return result;

        }
    }
}
