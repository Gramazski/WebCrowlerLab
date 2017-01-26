using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebCrowlerLibrary.WebCrowler.CrowlerSettingManager;
using WebCrowlerLibrary.WebCrowler.TreeHandler;
using WebCrowlerLibrary.CrowlerLogger;

namespace WebCrowlerLibrary.WebCrowler
{
    public class WebCrowler : ISimpleWebCrawler
    {
        private CrowlerTreeHandler crowlerTreeHandler;
        private ILogger logger;

        public WebCrowler(int analazingDepth)
        {
            logger = new FileLogger();
            int crawlAnalizingDepth;
            if (!CrowlerSettingsManager.SetAnalazingDepth(analazingDepth, out crawlAnalizingDepth))
            {
                logger.WriteToLog("Uncorrect input depth: " + analazingDepth + "! Was set: " + crawlAnalizingDepth);
            }

            crowlerTreeHandler = new CrowlerTreeHandler(crawlAnalizingDepth);
        }

        public async Task<CrawlResult> PerformCrawlingAsync(string[] rootUrls)
        {
            try
            {
                return await crowlerTreeHandler.CreateCrawlTree(rootUrls);
            }
            catch(ArgumentException e)
            {
                logger.WriteToLog(e.Message);
                return null;
            }
            
        }
    }
}
