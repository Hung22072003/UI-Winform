using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageStaffBLL
    {
        public dynamic GetAllStaffBLL()
        {
            ManageStaffDAL mnd = new ManageStaffDAL();

            return mnd.GetAllStaffDAL();
        }

        public dynamic GetAllStafByNamefBLL(string name)
        {

            ManageStaffDAL mnd = new ManageStaffDAL();
            return mnd.GetAllStaffByNameDAL(name);

        }

        public void DeleteStaffByIDBLL(string id)
        {

            ManageStaffDAL mnd = new ManageStaffDAL();
            mnd.DeleteStaffByIDDAL(id);


        }

        public dynamic SortStaffBLL(String KeyWord)
        {

            ManageStaffDAL mnd = new ManageStaffDAL();

            return mnd.SortStaffDAL(KeyWord);

        }

        public dynamic GetStaffByID(string id)
        {
            ManageStaffDAL mnd = new ManageStaffDAL();

            return mnd.GetStaffByIDDAL(id);
        }


        public void UpdateStaffBLL(string Id, string Name, string PhoneNumber, DateTime DateOfBirth, string Address, decimal Salary, string Email, Image Picture)
        {

            Staff temp = new Staff();

            temp.ID_Staff = Id;
            temp.Name = Name;
            temp.PhoneNumber = PhoneNumber;
            temp.DateOfBirth = DateOfBirth;
            temp.Address = Address;
            temp.Salary = Salary;
            temp.Email = Email;


            if (Picture != null)
            {
                MemoryStream memory = new MemoryStream();
                Picture.Save(memory, ImageFormat.Jpeg);
                temp.Picture = memory.ToArray();
            }
            ManageStaffDAL msd = new ManageStaffDAL();

            msd.UpdateStaffDAL(temp);

        }

        public void AddStaffBLL(string Id, string Name, string PhoneNumber, DateTime DateOfBirth, string Address, decimal Salary, string Email, Image Picture)
        {
            Staff temp = new Staff();

            temp.ID_Staff = Id;
            temp.Name = Name;
            temp.PhoneNumber = PhoneNumber;
            temp.DateOfBirth = DateOfBirth;
            temp.Address = Address;
            temp.Salary = Salary;
            temp.Email = Email;
            if (Picture != null)
            {
                MemoryStream memory = new MemoryStream();
                Picture.Save(memory, ImageFormat.Jpeg);
                temp.Picture = memory.ToArray();
            }

            ManageStaffDAL msd = new ManageStaffDAL();

            msd.AddStaffDAL(temp);
        }
    }
}
