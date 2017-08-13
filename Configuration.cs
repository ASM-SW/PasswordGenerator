using System;
using System.IO;
using System.Xml.Serialization;

namespace PasswordGenerator
{
    /// <summary>
    /// This class is used to store user input between runs.  The Password is not stored.  D
    /// </summary>
    [Serializable]
    public class ConfigPasswordGenerator
    {
        public string SpecialCharacters { get; set; }
        public string WordFileName { get; set; }
        public decimal WordCount { get; set; }
        public decimal PasswordCount { get; set; }
        public bool CapitalizeWord { get; set; }

        [XmlIgnore]
        public string ConfigFileName { get; set; }              // name of file containing configuration information

        public ConfigPasswordGenerator()
        {
            string appData = Environment.GetEnvironmentVariable("APPDATA");
            string dataDir = Path.Combine(appData, "PasswordGen");
            if (!Directory.Exists(dataDir))
                Directory.CreateDirectory(dataDir);
            ConfigFileName = Path.Combine(dataDir, "Configuration.xml");
        }




        public bool Serialize(string fileName)
        {
            try
            {
                using (TextWriter writer = new StreamWriter(fileName))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(ConfigPasswordGenerator));
                    ser.Serialize(writer, this);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.ToString());
            }
            return true;
        }

        public static bool DeSerialize(string fileName, ref ConfigPasswordGenerator cfg)
        {
            if (!File.Exists(fileName))
                return true;
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(ConfigPasswordGenerator));
                    cfg = (ConfigPasswordGenerator)ser.Deserialize(fileStream);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            return true;
        }

    }
}
