using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCrowlerLibrary.HTMLDocumentHandler;

namespace WebCrowlerLibrary.WebCrowler.TreeHandler
{
    internal class CrowlerTreeHandler
    {
        //ОПРОБОВАТЬ
        private CrawlResult crawlTree;
        private int analizingDepth;

        public CrowlerTreeHandler(int analizingDepth)
        {
            crawlTree = new CrawlResult("UrlCrowlingRoot");
            this.analizingDepth = analizingDepth;
        }

        public CrowlerTreeHandler(string rootUrl, int analazingDepth) : this(analazingDepth)
        {
            if ((rootUrl != null) && !(rootUrl.Equals("")))
            {
                crawlTree = new CrawlResult(rootUrl);
            }

            this.analizingDepth = analazingDepth;
        }

        public async Task<CrawlResult> CreateCrawlTree(string[] rootUrls)
        {
            foreach (string rootUrl in rootUrls)
            {
                CrawlResult crawlTreeNode = await AddNode(rootUrl, 1);
                crawlTree.AddNestedUrl(crawlTreeNode);
            }

            return crawlTree;
        }

        private async Task<CrawlResult> AddNode(string rootUrl, int currentDepth)
        {
            CrawlResult crawlResult = new CrawlResult(rootUrl);

            if (currentDepth < analizingDepth)
            {
                ConcurrentBag<string> urls = await HTMLDocumentHandler.HTMLDocumentHandler.FindNestedUrls(rootUrl);

                foreach (string url in urls)
                {
                    CrawlResult innerUrl = await AddNode(url, currentDepth + 1);
                    crawlResult.AddNestedUrl(innerUrl);
                }
            }

            return crawlResult;
        }

    }
}
