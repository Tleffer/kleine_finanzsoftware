using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kleine_Finanzsoftware
{
    [Serializable]
    public class DataFixEntry
    {
        public string usage { get; set; }
        public double money { get; set; }
        public DateTime datum { get; set; }
        public bool einnahme { get; set; } // true for income, false for expenses
        public string period { get; set; } // e.g. "monthly", "yearly"
    }
}
