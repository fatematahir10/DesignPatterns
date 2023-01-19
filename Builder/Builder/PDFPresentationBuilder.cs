using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class PDFPresentationBuilder : PresentationBuilder
    {
        PDFDocument _pdfDocument = new PDFDocument();

        public PDFDocument PdfDocument { get => _pdfDocument;}

        public void addSlide(string text)
        {
            _pdfDocument.addPage(text);
        }
    }
}
