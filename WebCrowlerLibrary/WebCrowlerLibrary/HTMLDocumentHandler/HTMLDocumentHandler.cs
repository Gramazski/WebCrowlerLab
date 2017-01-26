using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebCrowlerLibrary.CrowlerLogger;
using HtmlAgilityPack;

namespace WebCrowlerLibrary.HTMLDocumentHandler
{
    internal class HTMLDocumentHandler
    {
        private const string urlTag = "a";
        private const string urlAttribute = "href";
        private const string urlStartString = "http";

        public static async Task<ConcurrentBag<string>> FindNestedUrls(string url)
        {
            string pageContent = await HTMLDocumentLoader.GetInstance().LoadDocument(url);
            HtmlDocument htmlPage = new HtmlDocument();
            htmlPage.LoadHtml(pageContent);

            ConcurrentBag<string> hrefTags = new ConcurrentBag<string>();

            try
            {
                Parallel.ForEach(htmlPage.DocumentNode.Descendants(urlTag), (link) =>
                {
                    if (link.Attributes.Contains(urlAttribute))
                    {
                        string attribute = link.Attributes[urlAttribute].Value;
                        if (attribute.StartsWith(urlStartString))
                        {
                            hrefTags.Add(attribute);
                        }

                    }
                });
            }
            catch(ArgumentNullException e)
            {
                throw new ArgumentException("Find nected url: HTML descendants are null.");
            }
            

            return hrefTags;
        }
    }
}
