using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kleine_Finanzsoftware
{
    [XmlRoot("Export")]
    public class Export
    {
        [XmlArray("data")]
        [XmlArrayItem("data")]
        public List<ImportEntry> Data { get; set; } = new List<ImportEntry>();
    }
}
