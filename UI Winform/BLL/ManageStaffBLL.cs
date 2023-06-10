using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageStaffBLL
    {
        public DataTable dt; 
        public ManageStaffBLL()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Mã nhân viên", DataType = typeof(string)},
                new DataColumn {ColumnName = "Tên nhân viên", DataType = typeof(string)},
                new DataColumn {ColumnName = "Số điện thoại", DataType = typeof(string)},
                new DataColumn {ColumnName = "Ngày sinh", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Địa chỉ", DataType = typeof(string)},
                new DataColumn {ColumnName = "Lương", DataType = typeof(string)},
                new DataColumn {ColumnName = "Email", DataType = typeof(string)},
            });
        }
        public string setIDStaff()
        {
            ManageStaffDAL msd = new ManageStaffDAL();
            string ID_Staff;
            if (msd.GetAllStaff().Count < 9)
            {
                ID_Staff = "NV0" + (msd.GetAllStaff().Count + 1);
            }else
            {
                ID_Staff = "NV" + (msd.GetAllStaff().Count + 1);
            }
            return ID_Staff;
        }
        public DataTable GetAllStaffBLL()
        {
            dt.Rows.Clear();
            ManageStaffDAL mnd = new ManageStaffDAL();
            mnd.GetAllStaffDAL().ForEach(s =>
            {
                dt.Rows.Add(s.ID_Staff, s.Name, s.PhoneNumber, s.DateOfBirth, s.Address, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", s.Salary), s.Email);
            });
            return dt;
        }

        public DataTable GetAllStafByNamefBLL(string name)
        {
            dt.Rows.Clear();
            ManageStaffDAL mnd = new ManageStaffDAL();
            mnd.GetAllStaffByNameDAL(name).ForEach(s =>
            {
                dt.Rows.Add(s.ID_Staff, s.Name, s.PhoneNumber, s.DateOfBirth, s.Address, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", s.Salary), s.Email);
            });
            return dt;
        }

        public void DeleteStaffByIDBLL(string id)
        {
            ManageStaffDAL mnd = new ManageStaffDAL();
            mnd.DeleteStaffByIDDAL(id);
        }

        public DataTable SortStaffBLL(String KeyWord, string ascdesc)
        {
            dt.Rows.Clear();
            ManageStaffDAL mnd = new ManageStaffDAL();
            mnd.SortStaffDAL(KeyWord, ascdesc).ForEach(s =>
            {
                dt.Rows.Add(s.ID_Staff, s.Name, s.PhoneNumber, s.DateOfBirth, s.Address, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", s.Salary), s.Email);
            });
            return dt;
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
            temp.Deleted = false;

            ManageStaffDAL msd = new ManageStaffDAL();

            msd.AddStaffDAL(temp);
        }

        public bool CheckCbbTypeAccount(string text)
        {
            ManageRoleBLL mob = new ManageRoleBLL();    
 
            for (int i = 0; i < mob.GetCbbTypeAccounts().Count; i++)
            {
                if (mob.GetCbbTypeAccounts()[i].text == text) return true;
            }
            return false;
        }
        // Kiểm tra định dạng email
        public bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool CheckValidInfo(string ID_Staff, string Name, string Phone, string Address, string Salary, string Email, string Account)
        {
            if (ID_Staff != "" && Name != "" && Phone != "" && Address != ""
                && Salary != "" && Email != "" && Account != "")
            {
                if (IsEmail(Email))
                {
                    if (CheckCbbTypeAccount(Account))
                    {
                        if (IsNumber(Salary))
                        {
                            if (IsNumber(Phone))
                            {
                                return true;
                            }else
                            {
                                MessageBox.Show("Vui lòng lựa nhập đúng định dạng số điện thoại");
                                return false;
                            }
                        } else
                        {
                            MessageBox.Show("Vui lòng lựa nhập đúng định dạng lương");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng lựa chọn đúng Loại tài khoản!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng Email!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
        }
    }
}
