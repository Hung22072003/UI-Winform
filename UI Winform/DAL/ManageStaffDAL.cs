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
        public dynamic GetAllStaffDAL()
        {

            using (DBPM db = new DBPM())
            {

                var d = db.Staffs.Select(p => new { p.ID_Staff, p.Name, p.PhoneNumber, p.DateOfBirth, p.Address, p.Salary, p.Email, p.Picture });
                return d.ToList();
            }

        }

        public dynamic GetAllStaffByNameDAL(string name)
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.Name.Contains(name)).Select(p => new { p.ID_Staff, p.Name, p.PhoneNumber, p.DateOfBirth, p.Address, p.Salary, p.Email, p.Picture }).ToList();
                return s;
            }

        }

        public void DeleteStaffByIDDAL(string ID)
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Find(ID);
                db.Staffs.Remove(s);
                db.SaveChanges();
            }

        }

        public dynamic SortStaffDAL(string KeyWord)
        {
            using (DBPM db = new DBPM())
            {

                if (KeyWord == "Tên")
                {
                    var s = db.Staffs.OrderBy(p => p.Name).Select(p => new { p.ID_Staff, p.Name, p.PhoneNumber, p.DateOfBirth, p.Address, p.Salary, p.Email, p.Picture }).ToList();
                    return s;
                }
                else if (KeyWord == "Lương")
                {
                    var s = db.Staffs.OrderBy(p => p.Salary).Select(p => new { p.ID_Staff, p.Name, p.PhoneNumber, p.DateOfBirth, p.Address, p.Salary, p.Email, p.Picture }).ToList();
                    return s;
                }
                else if (KeyWord == "Ngày Sinh")
                {
                    var s = db.Staffs.OrderBy(p => p.DateOfBirth).Select(p => new { p.ID_Staff, p.Name, p.PhoneNumber, p.DateOfBirth, p.Address, p.Salary, p.Email, p.Picture }).ToList();
                    return s;
                }

                return null;

            }
        }

        public dynamic GetStaffByIDDAL(string id)
        {

            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.ID_Staff == id).Select(p => new
                {
                    p.ID_Staff,
                    p.Name,
                    p.PhoneNumber,
                    p.DateOfBirth,
                    p.Address,
                    p.Salary,
                    p.Email,
                    p.Picture
                }).FirstOrDefault();
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
