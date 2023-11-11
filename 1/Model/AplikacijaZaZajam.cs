using _1.Model.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Model
{
    internal class AplikacijaZaZajam
    {
        private databaseservis _dbServis;
        private QRKodGenerator _qRKodGenerator;
        private GeneratorDokumenta _dokGenerator;
        public AplikacijaZaZajam()
        {
            _dbServis = new databaseservis();
            _qRKodGenerator = new QRKodGenerator();
            _dokGenerator = new GeneratorDokumenta();
        }
        public void ProcesiranjeZahtevaZaZajam(zahtevzazajam request)
        {
            _dbServis.SaveLoanRequest(request);
            string qrkoddata = "Agreement data";
            Bitmap qrCodeImage = _qRKodGenerator.GenerisiQRKod(qrkoddata);
            string ugovorFilePath = _dokGenerator.GenerisiUgovorOKreditu(request.Imeaplikanta, "Zajam", request.OdobrenaSuma, "RSD");
        }

    }
}
