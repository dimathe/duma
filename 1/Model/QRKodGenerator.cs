using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;

namespace _1.Model.Common
{
    public class QRKodGenerator
    {
        public Bitmap GenerisiQRKod(string data)
        {
            QRCodeGenerator qrGenerator=new QRCodeGenerator();
            QRCodeData qRCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode =new QRCode(qRCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }
    }
}
