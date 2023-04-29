using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageStaff_ShiftBLL
    {
        public DataTable ListToDatatable(string IDStaff)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_Staff", typeof(string));
            dt.Columns.Add("ID_Shift", typeof(int));

            ManageStaffDAL msd = new ManageStaffDAL();

            ManageStaff_ShiftDAL mssd = new ManageStaff_ShiftDAL();
            var s = mssd.GetStaff_ShiftDAL(IDStaff);

            foreach (var a in s)
            {
                dt.Rows.Add(a.ID_Staff, a.ID_Shift);
            }

            return dt;
        }

        public void DeleteByID_StaffBLL(string ID_Staff, List<CheckBoxShift> li)
        {
            ManageStaff_ShiftDAL mssd = new ManageStaff_ShiftDAL();

            foreach (CheckBoxShift i in li)
            {

                mssd.DeleteByID_StaffDAL(ID_Staff, i.value);
            }

        }

        public void AddStaffByID_StaffBLL(string ID_Staff, List<CheckBoxShift> li)
        {
            ManageStaff_ShiftDAL mssd = new ManageStaff_ShiftDAL();
            foreach (CheckBoxShift i in li)
            {
                if (i.check == true)
                {
                    mssd.AddByID_StaffDAL(ID_Staff, i.value);
                }

            }
        }
    }
}
