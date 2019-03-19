using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProject.Models
{
    public class Payback : Transaction
    {
        private double _fullInterestValue;
        private double _payment;

        public Payback()
        {
            
        }

        public double FullInterestValue
        {
            get { return _fullInterestValue; }
            set
            {
                _fullInterestValue = value;
                RaisePropertyChanged(nameof(FullInterestValue));
            }
        }

        public double Payment
        {
            get { return _payment; }
            set
            {
                _payment = value;
                RaisePropertyChanged(nameof(Payment));
            }
        }

        public override TransactionType TransactionType => TransactionType.Payback;
    }
}
