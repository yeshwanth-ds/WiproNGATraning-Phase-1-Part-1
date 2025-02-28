using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples
{
    public interface IReportFormatter
    {
        string FormatReport(string contenttoformat);
    }
    public class PdfFormatter : IReportFormatter
    {
        public string FormatReport(string contenttoformat) {
            return $"pdf formated {contenttoformat}";
        }
    }
    public class ExcelFormatter : IReportFormatter
    {
        public string FormatReport(string contenttoformat)
        {
            return $"pdf formated {contenttoformat}";
        }
    }
}
