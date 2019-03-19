using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace LoanProject.Models
{
    public class Customer : ObservableObject
    {
        //Insert Loan and Payback Transactions here soon

        private string _customerName;
        private string _customerAddress;
        private string _customerContactNumber;
        private string _customerId;

        public string CustomerID
        {
            get { return _customerId; }
            set
            {
                _customerId = value;
                RaisePropertyChanged(nameof(CustomerID));
            }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                _customerName = value;
                RaisePropertyChanged(nameof(CustomerName));
            }
        }

        public string CustomerAddress
        {
            get { return _customerAddress; }
            set
            {
                _customerAddress = value;
                RaisePropertyChanged(nameof(CustomerAddress));
            }
        }

        public string CustomerContactNumber
        {
            get { return _customerContactNumber; }
            set
            {
                _customerContactNumber = value;
                RaisePropertyChanged(nameof(CustomerContactNumber));
            }
        }

    }
}
