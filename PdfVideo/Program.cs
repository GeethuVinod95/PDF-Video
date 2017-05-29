using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPdfFileWriter;

namespace PdfVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new OtherExample();
            p.Test(false, @"C:\Test\sample6y.pdf");
        }
    }
}
