using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageStaffDAL
    {
        public List<Staff> GetAllStaffDAL()
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.Deleted == false).Select(p => p).ToList();
                return s;
            }

        }


        public dynamic GetAllStaff()
        {
            using (DBPM db = new DBPM())
            {
                var d = db.Staffs.Select(p => new { p.ID_Staff, p.Name, p.PhoneNumber, p.DateOfBirth, p.Address, p.Salary, p.Email, p.Picture });
                return d.ToList();
            }
        }
        public List<Staff> GetAllStaffByNameDAL(string name)
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.Name.Contains(name) && p.Deleted == false).Select(p => p).ToList();
                return s;
            }

        }

        public void DeleteStaffByIDDAL(string ID)
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Find(ID);
                s.Deleted = true;
                db.SaveChanges();
            }

        }

        public List<Staff> SortStaffDAL(string KeyWord, string ascdesc)
        {
            using (DBPM db = new DBPM())
            {

                if (KeyWord == "Tên" && ascdesc == "Tăng dần")
                {
                    var s = db.Staffs.Where(p => p.Deleted == false).OrderBy(p => p.Name).Select(p => p).ToList();
                    return s;
                }
                else if (KeyWord == "Lương" && ascdesc == "Tăng dần")
                {
                    var s = db.Staffs.Where(p => p.Deleted == false).OrderBy(p => p.Salary).Select(p => p).ToList();
                    return s;
                }
                else if (KeyWord == "Ngày Sinh" && ascdesc == "Tăng dần")
                {
                    var s = db.Staffs.Where(p => p.Deleted == false).OrderBy(p => p.DateOfBirth).Select(p => p).ToList();
                    return s;
                }
                else if (KeyWord == "Tên" && ascdesc == "Giảm dần")
                {
                    var s = db.Staffs.Where(p => p.Deleted == false).OrderByDescending(p => p.Name).Select(p => p).ToList();
                    return s;
                }
                else if (KeyWord == "Ngày Sinh" && ascdesc == "Giảm dần")
                {
                    var s = db.Staffs.Where(p => p.Deleted == false).OrderByDescending(p => p.DateOfBirth).Select(p => p).ToList();
                    return s;
                }
                else if (KeyWord == "Lương" && ascdesc == "Giảm dần")
                {
                    var s = db.Staffs.Where(p => p.Deleted == false).OrderByDescending(p => p.Salary).Select(p => p).ToList();
                    return s;
                }
                return null;
            }
        }

        public Staff GetStaffByIDDAL(string id)
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.ID_Staff == id).Select(p => p).FirstOrDefault();
                return s;
            }
        }
        public void UpdateStaffDAL(Staff temp)  
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Find(temp.ID_Staff);

                s.Name = temp.Name;
                s.PhoneNumber = temp.PhoneNumber;
                s.DateOfBirth = temp.DateOfBirth;
                s.Address = temp.Address;
                s.Salary = temp.Salary;
                s.Email = temp.Email;
                s.Picture = temp.Picture;
                db.SaveChanges();

            }

        }

        public void AddStaffDAL(Staff temp)
        {

            using (DBPM db = new DBPM())
            {
                try
                {
                    db.Staffs.Add(temp);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var error in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in error.ValidationErrors)
                        {
                            Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }
                }
            }

        }
    }
}
