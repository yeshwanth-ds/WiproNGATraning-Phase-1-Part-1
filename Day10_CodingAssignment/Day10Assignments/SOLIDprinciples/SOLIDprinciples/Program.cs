using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator generator = new ReportGenerator();
             UploadReport uploader = new ReportUploader();
            ReportSaver saver = new ReportSaver();
            IDownloadReport downloader = new ReportDownloader();
            //ReportManager reportManager=new ReportManager(generator, uploader,saver,downloader);
            string generatedreport = generator.GenerateReport();
            Console.WriteLine(generatedreport);
            string uploadreport =uploader.UploadReporter(generatedreport);
            Console.WriteLine(uploadreport);
            string savedreport=saver.SaveReport(generatedreport);
            Console.WriteLine(savedreport);
            string downloadreport=downloader.DownloadReporter(generatedreport);
            Console.WriteLine(downloadreport);
        }
    }
}
