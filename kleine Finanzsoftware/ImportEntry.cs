using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kleine_Finanzsoftware
{
    public class ImportEntry
    {
        [XmlElement("amount")]
        public double amount { get; set; }
        [XmlElement("usage")]
        public string usage { get; set; }
        [XmlElement("gebucht")]
        public bool gebucht { get; set; }
        [XmlElement("einnahme")]
        public bool einnahme { get; set; }
        [XmlElement("date")]
        public long DateRaw { get; set; }
        [XmlIgnore]
        public DateTime date => DateTimeOffset.FromUnixTimeMilliseconds(DateRaw).ToLocalTime().DateTime;
        [XmlElement("check")]
        public bool check { get; set; }
    }
}
