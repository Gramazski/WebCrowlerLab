using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCrowlerLibrary.WebCrowler;
using WebCrowlerProject.Model;
using WebCrowlerProject.ViewModel.Command;

namespace WebCrowlerProject.ViewModel
{
    class WebCrowlerViewModel : Notifier
    {
        private WebCrowlerModel webCrowlerModel;
        private CrawlResult webCrawlResult;
        private readonly CrawlStartCommand command;
        public CrawlStartCommand Command
        {
            get { return command; }
            private set { }
        }

        public CrawlResult WebCrawlResult
        {
            get
            {
                return webCrawlResult;
            }
            set
            {
                webCrawlResult = value;
                NotifyPropertyChanged(nameof(WebCrawlResult));
            }
        }

        public WebCrowlerViewModel()
        {
            webCrowlerModel = new WebCrowlerModel();
            command = new CrawlStartCommand(
                async () =>
                {
                    if (command.CanExecute(null))
                    {
                        command.DisableExecute();
                        WebCrawlResult = await webCrowlerModel.GetWebCrawlingResultAsync();
                        command.EnableExecute();
                    }

                }
            );
        }
    }
}
