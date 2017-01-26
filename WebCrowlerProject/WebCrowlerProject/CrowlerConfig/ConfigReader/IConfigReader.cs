using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrowlerProject.CrowlerConfig.ConfigReader
{
    abstract class IConfigReader
    {
        static abtract int Go();
        static string[] ReadMultiApplicationConfigByTag(string configFilePath, string rootTag, string nestedTag);
    }
}
