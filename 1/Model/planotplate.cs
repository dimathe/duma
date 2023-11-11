using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Model
{
    internal class databaseservis
    {
        public int Id { get; set; }
        public int LoanApprovalId { get; set; }
        public DateTime DueDate { get; set; }
        public decimal AmountDue { get; set; }
    }
}
