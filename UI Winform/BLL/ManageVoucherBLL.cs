using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.DAL;
using UI_Winform.DTO;

namespace UI_Winform.BLL
{
    public class ManageVoucherBLL
    {
        public DataTable dt;

        public ManageVoucherBLL()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName = "Mã Voucher", DataType = typeof(string)},
                new DataColumn {ColumnName = "Giảm giá", DataType = typeof(Double)},
                new DataColumn {ColumnName = "Ngày bắt đầu", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Ngày kết thúc", DataType = typeof(DateTime)},
                new DataColumn {ColumnName = "Điều kiện tối thiểu", DataType = typeof(string)},
                new DataColumn {ColumnName = "Trạng thái", DataType = typeof(bool)},
                new DataColumn {ColumnName = "Giảm tối đa", DataType = typeof(string)},
            });
        }
        public Voucher GetVoucherByID(String id, Decimal min_Total)
        {
            ManageVoucherDAL mvd = new ManageVoucherDAL();

            Voucher temp = mvd.GetVoucherByID(id);
            if (temp == null)
            {
                MessageBox.Show("Không tim thấy voucher");
                return null;
            }
            else if ((temp.StartDate <= DateTime.Now.Date) && (DateTime.Now.Date <= temp.EndDate))
            {
                if (temp.Tick == true)
                {
                    if (temp.MinTotal <= min_Total)
                    {
                        return temp;
                    }
                    else
                    {
                        MessageBox.Show("Tổng tiền của hóa đơn ít nhất phải đạt " + Convert.ToDouble(temp.MinTotal).ToString());
                        return null;
                    }

                }
                else
                {
                    MessageBox.Show("Voucher đã có người sử dụng trước đó, vui lòng nhập voucher mới");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Voucher đã hết hạn sử dụng");
                return null;
            }
        }

        public void SetVoucherBeingUsedBLL(String ID_Voucher)
        {
            ManageVoucherDAL mvd = new ManageVoucherDAL();
            mvd.SetVoucherBeingUsedDAL(ID_Voucher);
        }

        public bool CheckStatusVoucherBLL(String ID_Voucher)
        {

            ManageVoucherDAL mvb = new ManageVoucherDAL();
            Voucher v = mvb.GetVoucherByID(ID_Voucher);
            if (v.Tick == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public String CheckBonusPointBLL(String BonusPoint)
        {
            if (BonusPoint == "")
            {
                return "0";
            }
            else
            {
                return Convert.ToString(Convert.ToInt32(BonusPoint) * (-100000));
            }
        }

        /*Them ham de kiem tra tối đa giảm bao nhiêu trong một hóa đơn*/

        public double CheckMaxDiscount(string ID_Voucher)
        {

            ManageVoucherDAL mvd = new ManageVoucherDAL();
            Voucher v = mvd.GetVoucherByID(ID_Voucher);
            return (double)v.MaxDiscount;

        }

        public Voucher GetVoucherByID(String ID_Voucher)
        {
            ManageVoucherDAL mvd = new ManageVoucherDAL();
            return mvd.GetVoucherByID(ID_Voucher);
        }

        public DataTable GetAllVoucherBLL()
        {
            dt.Rows.Clear();
            ManageVoucherDAL mvd = new ManageVoucherDAL();
            mvd.GetAllVoucherDAL().ForEach(v =>
            {
                dt.Rows.Add(v.ID_Voucher, v.Discount, v.StartDate, v.EndDate, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", v.MinTotal), v.Tick, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", v.MaxDiscount));
            });
            return dt;
        }

        public DataTable GetAllVoucherBLL(DateTime date)
        {
            dt.Rows.Clear();
            ManageVoucherDAL mvd = new ManageVoucherDAL();
            mvd.GetAllVoucherDAL(date).ForEach(v =>
            {
                dt.Rows.Add(v.ID_Voucher, v.Discount, v.StartDate, v.EndDate, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", v.MinTotal), v.Tick, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", v.MaxDiscount));
            });
            return dt;
        }

        public List<string> GetAllID_VoucherBLL()
        {
            ManageVoucherDAL mvd = new ManageVoucherDAL();
            return mvd.GetAllID_VoucherDAL();
        }

        public bool CheckSameID_Voucher(String ID_Voucher)
        {

            ManageVoucherDAL mvd = new ManageVoucherDAL();
            foreach (string i in mvd.GetAllID_VoucherDAL())
            {
                if (ID_Voucher == i)
                {
                    return true;
                }
            }
            return false;

        }

        public string GenerateRandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder stringBuilder = new StringBuilder(6);

            for (int i = 0; i < 6; i++)
            {
                int randomIndex = random.Next(0, chars.Length);
                char randomChar = chars[randomIndex];
                stringBuilder.Append(randomChar);
            }

            return stringBuilder.ToString();
        }

        public void AddVoucherBLL(Voucher a, int Loop)
        {
            dt.Rows.Clear();
            ManageVoucherDAL mvd = new ManageVoucherDAL();
            for (int i = 0; i < Loop; i++)
            {
                while (true)
                {
                    if (CheckSameID_Voucher(a.ID_Voucher))
                    {
                        a.ID_Voucher = GenerateRandomString();
                    }
                    else
                    {
                        break;

                    }
                }
                mvd.AddVoucherDAL(a);
                dt.Rows.Add(a.ID_Voucher, a.Discount, a.StartDate, a.EndDate, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", a.MinTotal), a.Tick, string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", a.MaxDiscount));
            }
        }

        public DataTable GetListNewVoucher()
        {
            return dt;
        }

        public bool CheckEmptyInfor(string Quantity, string MaxDiscount, string MinTotal, string Discount)
        {
            if (Quantity == "" || MaxDiscount == "" || MinTotal == "" || Discount == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return false;
            }
            else
            {
                if (0 < Convert.ToDouble(Discount) && Convert.ToDouble(Discount) <= 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại khuyến mãi", "Thông báo");
                    return false;
                }
            }
        }

        /*Them ham de kiem tra giam gia toi da*/

        public bool CheckMaxDiscount(double DiscountVC, string ID_Voucher)
        {
            ManageVoucherBLL mvb = new ManageVoucherBLL();
            Voucher v = mvb.GetVoucherByID(ID_Voucher);
            if (DiscountVC >= v.MaxDiscount && v.MaxDiscount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
