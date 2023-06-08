using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;

namespace UI_Winform.DAL
{
    public class ManageVoucherDAL
    {
        public Voucher GetVoucherByID(String id)
        {

            using (DBPM db = new DBPM())
            {
                return db.Vouchers.Find(id);
            }

        }

        public void SetVoucherBeingUsedDAL(String ID_Voucher)
        {
            using (DBPM db = new DBPM())
            {
                Voucher a = db.Vouchers.Find(ID_Voucher);
                if (a != null)
                {
                    a.Tick = false;
                    db.SaveChanges();
                }

            }
        }

        public List<Voucher> GetAllVoucherDAL()
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Vouchers.Select(p => p).ToList();
                return s;
            }
        }

        public List<Voucher> GetAllVoucherDAL(DateTime date)
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Vouchers.Select(p => p).Where(p => p.StartDate <= date.Date && date.Date <= p.EndDate).ToList();
                return s;
            }
        }

        public List<String> GetAllID_VoucherDAL()
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Vouchers.Select(p => p.ID_Voucher).ToList();
                return s;
            }
        }

        public void AddVoucherDAL(Voucher temp)
        {
            using (DBPM db = new DBPM())
            {
                db.Vouchers.Add(temp);
                db.SaveChanges();

            }
        }
    }
}
