using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebCrowlerProject.CrowlerConfig.ConfigReader
{
    class XmlConfigReader
    {
        public static string[] ReadMultiApplicationConfigByTag(string configFilePath, string rootTag, string nestedTag)
        {
            XDocument xmlDocument = XDocument.Load(configFilePath);
            XElement rootResources = xmlDocument.Root.Element(rootTag);
            List<string> configStrings = new List<string>();

            foreach (XElement resource in rootResources.Elements(nestedTag))
            {
                configStrings.Add(resource.Value);
            }

            return configStrings.ToArray();
        }

        public static string ReadSingleApplicationConfigByTag(string configFilePath, string tag)
        {
            XDocument xmlDocument = XDocument.Load(configFilePath);

            return xmlDocument.Root.Element(tag).Value;
        }
    }
}
