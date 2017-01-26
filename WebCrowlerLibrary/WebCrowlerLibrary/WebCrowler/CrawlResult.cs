using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrowlerLibrary.WebCrowler
{
    public class CrawlResult
    {
        public string Url { get; private set; }
        public ObservableCollection<CrawlResult> NestedUrls { get; private set; }

        public CrawlResult(string url)
        {
            NestedUrls = new ObservableCollection<CrawlResult>();
            if ((url == null) || (url.Equals("")))
            {
                Url = "undefined";
                throw new ArgumentException("Crawl result: uncorrect root url.");
            }
            else
            {
                Url = url;
            }
        }

        public void AddNestedUrl(CrawlResult crawlResult)
        {
            NestedUrls.Add(crawlResult);
        }


    }
}
