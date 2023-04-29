using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Winform.DTO
{
    public class CheckBoxShift
    {
        public int value { get; set; }
        public string text { get; set; }

        public string ID_Staff { get; set; }
        public bool check { get; set; }
        public override string ToString()
        {
            return text;
        }
    }
}
