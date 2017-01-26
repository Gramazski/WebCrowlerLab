using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using WebCrowlerLibrary.WebCrowler;

namespace WebCrowlerProject.CrawlResultConverter
{
    class ResultConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CrawlResult crawlResult = value as CrawlResult;

            if (value == null)
            {
                return new object();
            }

            List<TreeViewItem> urlsTreeList = new List<TreeViewItem>();
            urlsTreeList.Add(TreeViewCreator.CreateTreeView(crawlResult));

            return urlsTreeList;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
