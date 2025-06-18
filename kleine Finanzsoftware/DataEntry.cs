using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kleine_Finanzsoftware
{
    [Serializable]
    public class DataEntry
    {
        public string usage { get; set; }
        public double money { get; set; }
        public bool gebucht { get; set; }
        public DateTime datum { get; set; }
        public bool einnahme { get;set; }
        public bool fix { get; set; } = false;
    }
}
