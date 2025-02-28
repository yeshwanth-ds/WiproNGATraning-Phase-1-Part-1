using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples
{
    public interface UploadReport
    {
        string UploadReporter(string report);
    }
    public class ReportUploader : UploadReport{
        public string UploadReporter(string report) {

            return $"Report Uploaded Successfully";
        }
    }
}
