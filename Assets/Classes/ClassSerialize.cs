using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace Assets.Classes
{
    public class ClassSerialize
    {	
        public static void SerializationYoXml<T>(ref T inObject, string fileName)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(T));
                StreamWriter file = new StreamWriter(fileName);
                writer.Serialize(file, inObject);
                file.Close();
            }
            catch (Exception ex)
            {
                Debug.Log(ex);
            }
        }

        public static void DeserializeFromXml<T>(ref T inObject, string fileName)
        {
            XmlSerializer reader = new XmlSerializer(typeof(T));
            StreamReader file = new StreamReader(fileName);
            inObject = (T)reader.Deserialize(file);
            file.Close();
        }
    }
}
