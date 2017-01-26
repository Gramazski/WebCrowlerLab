using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrowlerProject.CrowlerConfig
{
    class DataContainer
    {
        public int CrawlDepth { get; private set; }
        public string[] Urls { get; private set; }

        public DataContainer(int crawlDeprth, string[] urls)
        {
            CrawlDepth = crawlDeprth;
            Urls = urls;
        }
    }
}
