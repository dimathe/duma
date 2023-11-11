using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace _1.Model
{
    public class GeneratorDokumenta
    {
        public string GenerisiUgovorOKreditu(string Imeaplikanta, string tipPorizvoda, decimal odobrenIznos, string valuta )
        {
            string agreementText = $"Ugovor o kreditu\n\n"+
                $"Aplikant: {Imeaplikanta}\n"+
                $"Tip proizvoda: {tipPorizvoda}\n"+
                $"Odobren iznos: {odobrenIznos} {valuta}\n"+
                $"Datum odobrenja: {DateTime.Now}\n"+
                $"Dan predaje: {DateTime.Now.AddDays(1)}\n";

            string filePath = $"UgovorOkreditu_{Guid.NewGuid()}.pdf";
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph(agreementText));
                }
            }
            return filePath;

        }
    }
}
   
