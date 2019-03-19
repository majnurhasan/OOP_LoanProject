using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace LoanProject.Models
{
    public abstract class Transaction : ObservableObject
    {
        private double _loanValue;
        private DateTime _transactionDate;
        private string _customerId;
        private string _jewelryId;
        private string _transactionId;
        private TransactionType _transactionType;
        private double _balance;

        public string CustomerID
        {
            get { return _customerId; }
            set
            {
                _customerId = value;
                RaisePropertyChanged(nameof(CustomerID));
            }
        }

        public string JewelryID
        {
            get { return _jewelryId; }
            set
            {
                _jewelryId = value;
                RaisePropertyChanged(nameof(JewelryID));
            }
        }

        public string TransactionID
        {
            get { return _transactionId; }
            set
            {
                _transactionId = value;
                RaisePropertyChanged(nameof(TransactionID));
            }
        }

        public double LoanValue
        {
            get { return _loanValue; }
            set
            {
                _loanValue = value;
                RaisePropertyChanged(nameof(LoanValue));
            }
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                RaisePropertyChanged(nameof(Balance));
            }
        }

        public DateTime TransactionDate
        {
            get { return _transactionDate; }
            set
            {
                _transactionDate = value;
                RaisePropertyChanged(nameof(TransactionDate));
            }
        }

        public virtual TransactionType TransactionType
        {
            get { return _transactionType; }
            set
            {
                _transactionType = value;
                RaisePropertyChanged(nameof(TransactionType));
            }
        }
    }

    public enum TransactionType
    {
        Loan,
        Payback
    }


}
