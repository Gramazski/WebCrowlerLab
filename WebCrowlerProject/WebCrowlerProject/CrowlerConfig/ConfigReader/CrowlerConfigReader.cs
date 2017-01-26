using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrowlerProject.CrowlerConfig.ConfigReader
{
    class CrowlerConfigReader
    {
        private const string depthTag = "depth";
        private const string rootUrlTag = "urls";
        private const string nestedUrlTag = "url";

        public static DataContainer ReadCrowlerConfig(string filePath)
        {
            try
            {
                DataContainer dataContainer =
                new DataContainer(int.Parse(XmlConfigReader.ReadSingleApplicationConfigByTag(filePath, depthTag)),
                XmlConfigReader.ReadMultiApplicationConfigByTag(filePath, rootUrlTag, nestedUrlTag));

                return dataContainer;
            }
            catch(Exception e)
            {
                throw new ArgumentException("XML reader: wrong xml data - " + e.Message);
            } 
        }
    }
}
