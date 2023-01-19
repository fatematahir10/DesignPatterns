using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class PDFDocument
    {
        public void addPage(string text)
        {
            Console.WriteLine("Adding Page:" + text);
        }
    }
}
