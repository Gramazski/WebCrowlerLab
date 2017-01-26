using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrowlerLibrary.CrowlerLogger
{
    public interface ILogger
    {
        void WriteToLog(string data);
    }
}
