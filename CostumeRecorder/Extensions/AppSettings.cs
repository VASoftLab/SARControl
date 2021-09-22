using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace CostumeRecorder.Extensions
{
    public class AppSettings
    {
        [XmlElement("IP")]
        public string IP { get; set; }
        [XmlElement("Port")]
        public int Port { get; set; }        
        [XmlElement("PPS")]
        public int PPS { get; set; }

        [XmlElement("PathToCostumeConfig")]
        public string PathToCostumeConfig { get; set; }

        [XmlElement("ServerIP")]
        public string ServerIP { get; set; }
        [XmlElement("ServerPort")]
        public int ServerPort { get; set; }

        [XmlElement("ConverToRadians")]
        public bool ConverToRadians { get; set; }

        [XmlElement("CollisionK")]
        public double CollisionK { get; set; }

        [XmlElement("CheckCollision")]
        public bool CheckCollision { get; set; }

        [XmlElement("RobotIP")]
        public string RobotIP { get; set; }
        [XmlElement("RobotPort")]
        public int RobotPort { get; set; }


        public AppSettings()
        {
            IP = "127.0.0.1";
            Port = 10003;
            PPS = 10;

            ServerIP = "127.0.0.1";
            ServerPort = 1234;

            PathToCostumeConfig = "costumecfg.xml";

            ConverToRadians = false;
            CollisionK = 0.14;
            CheckCollision = true;

            RobotIP = "127.0.0.1";
            RobotPort = 10099;
        }

        public String SerializeToString()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, this);
            return textWriter.ToString();
        }

        public void DeserializeFromString(String stringData)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
            using (TextReader reader = new StringReader(stringData))
            {
                AppSettings temp = (AppSettings)xmlSerializer.Deserialize(reader);

                this.IP = temp.IP;
                this.Port = temp.Port;
                this.PPS = temp.PPS;

                this.ServerIP = temp.ServerIP;
                this.ServerPort = temp.ServerPort;

                this.PathToCostumeConfig = temp.PathToCostumeConfig;

                this.ConverToRadians = temp.ConverToRadians;
                this.CollisionK = temp.CollisionK;
                this.CheckCollision = temp.CheckCollision;

                this.RobotIP = temp.RobotIP;
                this.RobotPort = temp.RobotPort;
            }
        }

        public void Load()
        {
            String dataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            dataFile = Path.Combine(dataFile, "settings.dat");
            if (File.Exists(dataFile))
            {
                String serializedString = System.IO.File.ReadAllText(dataFile);
                this.DeserializeFromString(serializedString);
            }
        }

        public void Save()
        {
            String dataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            dataFile = Path.Combine(dataFile, "settings.dat");
            String serializedString = this.SerializeToString();
            System.IO.File.WriteAllText(dataFile, serializedString);
        }
    }
}
