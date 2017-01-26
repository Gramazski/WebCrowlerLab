using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebCrowlerLibrary.HTMLDocumentHandler
{
    internal class HTMLDocumentLoader
    {
        private static readonly HTMLDocumentLoader instance = new HTMLDocumentLoader();
        private HttpClient webClient;

        private HTMLDocumentLoader()
        {
            webClient = new HttpClient();
        }

        public static HTMLDocumentLoader GetInstance()
        {
            return instance;
        }

        public async Task<string> LoadDocument(string url)
        {
            try
            {
                return await webClient.GetStringAsync(url);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Load HTML document: uncorrect url. Exception message: " + e.Message);
            }
        }
    }
}
