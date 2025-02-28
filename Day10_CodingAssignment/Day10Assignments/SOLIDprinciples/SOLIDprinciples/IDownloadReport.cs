using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples
{
    public interface IDownloadReport
    {
        string DownloadReporter(string report);
    }
    public class ReportDownloader : IDownloadReport {
        public string DownloadReporter(string report) { 
        
            return $"Download Report : {report}";
        }
    }
}
