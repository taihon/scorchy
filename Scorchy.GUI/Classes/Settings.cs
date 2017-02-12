using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Scorchy.GUI.Classes
{
    public class Settings
    {
        public string OrchestratorUrl { get; set; }
        public bool ResolveSID { get; set; }
        public bool HideInfoAlerts { get; set; }
        public int RowsPerPage { get; set; }
        private static Settings _instance;
        public static Settings Instance { get { if (_instance == null) _instance = new Settings(); return _instance; } }
        private Settings()
        {
            
        }
        public void Load()
        {
            var path = "Settings.xml";
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(Settings));
                using (StreamReader sr = new StreamReader(path))
                {
                    var t = (Settings)x.Deserialize(sr);
                    OrchestratorUrl = t.OrchestratorUrl;
                    ResolveSID = t.ResolveSID;
                    HideInfoAlerts = t.HideInfoAlerts;
                    RowsPerPage = t.RowsPerPage;
                }
            }
            catch (FileNotFoundException)
            {
                //there is no file to load from
                RowsPerPage = 35; //default values
            }
        }
    }
}
