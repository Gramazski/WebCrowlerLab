using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WebCrowlerLibrary.WebCrowler;

namespace WebCrowlerProject.CrawlResultConverter
{
    class TreeViewCreator
    {
        public static TreeViewItem CreateTreeView(CrawlResult crawlResult)
        {
            TreeViewItem root = CreateTreeViewItem(crawlResult.Url);
            foreach (CrawlResult url in crawlResult.NestedUrls)
            {
                TreeViewItem nestedItem = CreateTreeView(url);
                root.Items.Add(nestedItem);
            }
            return root;
        }

        private static TreeViewItem CreateTreeViewItem(string itemHeader)
        {
            TreeViewItem newItem = new TreeViewItem();
            newItem.Header = itemHeader;

            return newItem;
        }
    }
}
