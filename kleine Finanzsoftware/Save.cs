using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace kleine_Finanzsoftware
{
    public class Save
    {
        public string fileName { get; set; }
        public string filePath { get; set; }
        public string filePref { get; set; }
        public PrefData prefData { get; set; }
        public bool pref_exists = false;
        public Save()
        {
            string dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FinanzSW");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            filePref = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"FinanzSW\pref.xml");

            try
            {
                FileStream loadstream = new FileStream(filePref, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                XmlSerializer serializer = new XmlSerializer(typeof(PrefData));
                prefData = (PrefData)serializer.Deserialize(loadstream);
                loadstream.Close();
                filePath = prefData.Path;
                fileName = prefData.Name;
                pref_exists = true;
            }
            catch (Exception ex)
            {
                prefData = new PrefData();
            }
        }

        public void SaveData(Daten data)
        {
            prefData.count++;
            FileStream saveStream = new FileStream(filePath + "&" + prefData.count + ".xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(Daten));
            serializer.Serialize(saveStream, data);
            saveStream.Close();
            if(prefData.count > 10)
            {
                File.Delete(filePath + "&" + (prefData.count - 10) + ".xml"); // Delete old files to keep the last 10 saves
            }
            
            SavePrefernce();
        }
        public void SavePrefernce()
        {
            FileStream saveStream = new FileStream(filePref, FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(PrefData));
            serializer.Serialize(saveStream, prefData);
            saveStream.Close();
        }
        public Daten LoadData()
        {
            try
            {
                FileStream loadStream = new FileStream(filePath + "&" + prefData.count + ".xml", FileMode.Open, FileAccess.Read);
                XmlSerializer serializer = new XmlSerializer(typeof(Daten));
                Daten loadedData = (Daten)serializer.Deserialize(loadStream);
                loadStream.Close();
                return loadedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
                return null;
            }
        }
    }
}
