﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Winform.DTO
{
    public class ViewOrderDetail
    {
        public string ID_Item { get; set; }
        public string NameItem { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? AmountPrice { get; set; }

    }
}
