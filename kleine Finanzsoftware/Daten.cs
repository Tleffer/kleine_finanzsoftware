using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kleine_Finanzsoftware
{
    [Serializable]
    public class Daten
    {
        public List<DataEntry> datenList = new List<DataEntry>();
        public DateTime lastUpdate { get; set; }
        public List<DataFixEntry> fixList = new List<DataFixEntry>();
        public List<DataFixEntry> fixListHistory = new List<DataFixEntry>();
    }
}
