using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kleine_Finanzsoftware
{
    [Serializable]
    public class PrefData
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public ulong count { get; set; } = 0;
    }
}
