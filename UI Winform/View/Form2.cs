using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Winform.DAL;
using UI_Winform.DTO;
namespace UI_Winform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DBPM db = new DBPM())
            {
                var s = db.Staffs.SelectMany(p => p.Shifts.Select(c => 
                new { c.ID_Shift, c.TimeStart, c.TimeEnd, c.Staffs.Where(q => q.ID_Staff == p.ID_Staff).Select(q => 
                new {q.Name}).FirstOrDefault().Name })).ToList();
                dataGridView1.DataSource = s;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.ID_Staff == "NV01").Select(p => p).FirstOrDefault();
                s.Shifts.Add(db.Shifts.Where(p => p.ID_Shift == 2).Select(p=>p).FirstOrDefault());
                db.SaveChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (DBPM db = new DBPM())
            {
                var s = db.Staffs.Where(p => p.ID_Staff == "NV01").Select(p => p).FirstOrDefault();
                s.Shifts.Remove(db.Shifts.Where(p => p.ID_Shift == 2).Select(p => p).FirstOrDefault());
                s.Shifts.Add(db.Shifts.Where(p => p.ID_Shift == 3).Select(p => p).FirstOrDefault());
                db.SaveChanges();
            }
        }
    }
}
