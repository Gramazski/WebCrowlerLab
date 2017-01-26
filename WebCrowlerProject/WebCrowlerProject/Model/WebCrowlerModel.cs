using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCrowlerProject.CrowlerConfig;
using WebCrowlerProject.CrowlerConfig.ConfigReader;
using WebCrowlerLibrary.WebCrowler;
using WebCrowlerLibrary.CrowlerLogger;

namespace WebCrowlerProject.Model
{
    class WebCrowlerModel
    {
        private const string CrawlConfigFilePath = "..\\..\\CrowlerConfig\\XmlConfig\\config.xml";
        private DataContainer configData;
        private WebCrowler webCrowler;
        private ILogger logger;

        public WebCrowlerModel()
        {
            logger = new FileLogger();

            try
            {
                configData = CrowlerConfigReader.ReadCrowlerConfig(CrawlConfigFilePath);
            }
            catch(ArgumentException e)
            {
                logger.WriteToLog(e.Message);
                configData = new DataContainer(1, new string[2]);//??
            }
            
            webCrowler = new WebCrowler(configData.CrawlDepth);
        }

        public async Task<CrawlResult> GetWebCrawlingResultAsync()
        {
            return await webCrowler.PerformCrawlingAsync(configData.Urls);
        }
    }
}
