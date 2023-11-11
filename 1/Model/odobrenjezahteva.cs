using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Model
{
    class odobrenjezahteva
    {
        public int Id { get; set; }
        public int OdobrenjeZahtevaId { get; set; }
        public decimal OdobrenaSuma { get; set; }
        public bool Odobreno { get; set; }
    }
}
