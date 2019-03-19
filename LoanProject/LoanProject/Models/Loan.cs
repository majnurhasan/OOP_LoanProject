using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProject.Models
{
    public class Loan : Transaction
    {
        public Loan()
        {
            
        }

        public override TransactionType TransactionType => TransactionType.Loan;
    }
}
