using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples
{
    public class ReportManager
    {
        public ReportGenerator generator;
        public UploadReport uploader;
        public ReportSaver saver;
        public IDownloadReport downloader;
        public ReportManager(ReportGenerator generator,UploadReport uploader, ReportSaver saver,IDownloadReport downloader)
        {
            generator = new ReportGenerator();
            uploader = new ReportUploader();
            saver=new ReportSaver();
            downloader = new ReportDownloader();
        }
    }
}
