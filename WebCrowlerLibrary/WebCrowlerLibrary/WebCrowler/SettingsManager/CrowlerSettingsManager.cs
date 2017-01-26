using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrowlerLibrary.WebCrowler.CrowlerSettingManager
{
    internal class CrowlerSettingsManager
    {
        private const int maxAnalazingDepth = 6;
        private const int minAnalazingDepth = 1;

        public static bool SetAnalazingDepth(int userAnalazingDepth, out int crowlerAnalazingDepth)
        {
            if (userAnalazingDepth > maxAnalazingDepth)
            {
                crowlerAnalazingDepth = maxAnalazingDepth;

                return false;
            }

            if (userAnalazingDepth < minAnalazingDepth)
            {
                crowlerAnalazingDepth = minAnalazingDepth;

                return false;
            }

            crowlerAnalazingDepth = userAnalazingDepth;

            return true;
        }
    }
}
