using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Bibliologist
{
    public class Global
    {
        public static Dictionary<string, string> Formats;
        public static Dictionary<string, string> Genres;
        public static Dictionary<string, string> Locations;
        public static Dictionary<string, string> Messages;
        public static Dictionary<string, string> Statuses;

        public static Dictionary<string, string> LoadConfigValues(string langCode, string valueType)
        {
            string langFile = @"lang\" + langCode + ".xml";

            Dictionary<string, string> messageTable = new Dictionary<string, string>();

            if (File.Exists(langFile))
            {
                StreamReader sr = new StreamReader(langFile);
                var doc = XDocument.Parse(sr.ReadToEnd());

                foreach (var message in doc.Root.Element(valueType + "s").Elements(valueType))
                {
                    messageTable.Add(message.Attribute("key").Value, message.Attribute("value").Value);
                }

                sr.Close();
            }

            return messageTable;
        }
    }
}