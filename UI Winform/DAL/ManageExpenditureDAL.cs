﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI_Winform.DTO;
namespace UI_Winform.DAL
{
    public class ManageExpenditureDAL
    {
        public List<Storage> getItems(DateTime startDate, DateTime endDate)
        {
            DBPM db = new DBPM();
            var s = db.Storages.Where(p => startDate <= p.ImportDate && p.ImportDate <= endDate).Select(p => p).ToList();
            return s;
        }

        public void AddSpendingBill(Storage s)
        {
            using(DBPM db = new DBPM()) { 
                db.Storages.Add(s);
                db.SaveChanges();
            }
        }
    }
}
