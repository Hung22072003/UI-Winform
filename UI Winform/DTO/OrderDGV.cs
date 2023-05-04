using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Winform.DTO
{
    public class OrderDGV
    {
        public string ID_Order { get; set; }
        public string NameStaff { get; set; }
        public string NameCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        public DateTime OrderDate { get; set; } 
        public decimal? Total { get; set; }
    }
}
