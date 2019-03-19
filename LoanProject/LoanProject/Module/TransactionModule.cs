using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LoanProject.Models;

namespace LoanProject.Module
{
    public class TransactionModule : ObservableObject
    {
        private string _inputJewelryWeight;
        private string _inputJewelryDiscount;
        private string _inputJewelryValue;
        private string _inputJewelryOtherDetails;
        private string _inputCustomerName;
        private string _inputCustomerContactNumber;
        private string _inputCustomerAddress;
        private string _inputLoanValue;
        private JewelryType _selectedJewelryType;
        private JewelryQuality _selectedJewelryQuality;
        private Loan _newLoan;
        private Payback _newPayback;
        private Jewelry _newJewelry;
        private Customer _newCustomer;
        private string _inputJewelryId;
        private string _inputPayment;
        private string _displayFullInterestValue;
        private string _displayCustomerName;
        private string _displayCustomerContactNumber;
        private string _displayCustomerAddress;
        private string _displayBalance;
        private Loan _selectedLoan;
        private Payback _selectedPayback;

        //Enum Lists
        public string[] JewelryTypes => Enum.GetNames(typeof(JewelryType));
        public string[] JewelryQualities => Enum.GetNames(typeof(JewelryQuality));

        //Big Lists
        public ObservableCollection<Loan> ListOfLoans { get; } = new ObservableCollection<Loan>();
        public ObservableCollection<Payback> ListOfPaybacks { get; } = new ObservableCollection<Payback>();
        public ObservableCollection<Customer> CustomerList { get; } = new ObservableCollection<Customer>();
        public ObservableCollection<Jewelry> JewelryList { get; } = new ObservableCollection<Jewelry>();

        //Selected Elements
        public JewelryType SelectedJewelryType
        {
            get { return _selectedJewelryType; }
            set
            {
                _selectedJewelryType = value;
                RaisePropertyChanged(nameof(SelectedJewelryType));
            }
        }

        public JewelryQuality SelectedJewelryQuality
        {
            get { return _selectedJewelryQuality; }
            set
            {
                _selectedJewelryQuality = value;
                RaisePropertyChanged(nameof(SelectedJewelryQuality));
            }
        }

        public Loan SelectedLoan
        {
            get { return _selectedLoan; }
            set
            {
                _selectedLoan = value;
                RaisePropertyChanged(nameof(SelectedLoan));
            }
        }

        public Payback SelectedPayback
        {
            get { return _selectedPayback; }
            set
            {
                _selectedPayback = value;
                RaisePropertyChanged(nameof(SelectedPayback));
            }
        }

        //Display Elements
        public string DisplayFullInterestValue
        {
            get { return _displayFullInterestValue; }
            set
            {
                _displayFullInterestValue = value;
                RaisePropertyChanged(nameof(DisplayFullInterestValue));
            }
        }

        public string DisplayBalance
        {
            get { return _displayBalance; }
            set
            {
                _displayBalance = value;
                RaisePropertyChanged(nameof(DisplayBalance));
            }
        }

        public string DisplayCustomerName
        {
            get { return _displayCustomerName; }
            set
            {
                _displayCustomerName = value;
                RaisePropertyChanged(nameof(DisplayCustomerName));
            }
        }

        public string DisplayCustomerContactNumber
        {
            get { return _displayCustomerContactNumber; }
            set
            {
                _displayCustomerContactNumber = value;
                RaisePropertyChanged(nameof(DisplayCustomerContactNumber));
            }
        }

        public string DisplayCustomerAddress
        {
            get { return _displayCustomerAddress; }
            set
            {
                _displayCustomerAddress = value;
                RaisePropertyChanged(nameof(DisplayCustomerAddress));
            }
        }



        //Inputs
        public string InputJewelryWeight
        {
            get { return _inputJewelryWeight; }
            set
            {
                _inputJewelryWeight = value;
                RaisePropertyChanged(nameof(InputJewelryWeight));
            }
        }

        public string InputJewelryDiscount
        {
            get { return _inputJewelryDiscount; }
            set
            {
                _inputJewelryDiscount = value;
                RaisePropertyChanged(nameof(InputJewelryDiscount));
            }
        }

        public string InputJewelryValue
        {
            get { return _inputJewelryValue; }
            set
            {
                _inputJewelryValue = value;
                RaisePropertyChanged(nameof(InputJewelryValue));
            }
        }

        public string InputJewelryOtherDetails
        {
            get { return _inputJewelryOtherDetails; }
            set
            {
                _inputJewelryOtherDetails = value;
                RaisePropertyChanged(nameof(InputJewelryOtherDetails));
            }
        }

        public string InputCustomerName
        {
            get { return _inputCustomerName; }
            set
            {
                _inputCustomerName = value;
                RaisePropertyChanged(nameof(InputCustomerName));
            }
        }

        public string InputCustomerContactNumber
        {
            get { return _inputCustomerContactNumber; }
            set
            {
                _inputCustomerContactNumber = value;
                RaisePropertyChanged(nameof(InputCustomerContactNumber));
            }
        }

        public string InputCustomerAddress
        {
            get { return _inputCustomerAddress; }
            set
            {
                _inputCustomerAddress = value;
                RaisePropertyChanged(nameof(InputCustomerAddress));
            }
        }

        public string InputLoanValue
        {
            
            get { return _inputLoanValue; }
            set
            {
                _inputLoanValue = value;
                RaisePropertyChanged(nameof(InputLoanValue));
            }
        }

        public string InputJewelryID
        {
            get { return _inputJewelryId; }
            set
            {
                _inputJewelryId = value;
                RaisePropertyChanged(nameof(InputJewelryID));
            }
        }

        public string InputPayment
        {
            get { return _inputPayment; }
            set
            {
                _inputPayment = value;
                RaisePropertyChanged(nameof(InputPayment));
            }
        }

        //Added Elements
        public Loan NewLoan
        {
            get { return _newLoan; }
            set
            {
                _newLoan = value;
                RaisePropertyChanged(nameof(NewLoan));
            }
        }

        public Payback NewPayback
        {
            get { return _newPayback; }
            set
            {
                _newPayback = value;
                RaisePropertyChanged(nameof(NewPayback));
            }
        }

        public Jewelry NewJewelry
        {
            get { return _newJewelry; }
            set
            {
                _newJewelry = value;
                RaisePropertyChanged(nameof(NewJewelry));
            }
        }

        public Customer NewCustomer
        {
            get { return _newCustomer; }
            set
            {
                _newCustomer = value;
                RaisePropertyChanged(nameof(NewCustomer));
            }
        }

        //Initial Commands
        public TransactionModule()
        {
            SetFirstData();
        }

        private void SetFirstData()
        {
            Random rnd = new Random();
            Jewelry firstJewelry = new Jewelry();
            Customer firstCustomer = new Customer();
            Loan firstLoan = new Loan();
            Payback firstPayback = new Payback();

            firstJewelry.JewelryID = "J-8044";
            firstJewelry.JewelryType = JewelryType.Bracelets;
            firstJewelry.JewelryQuality = JewelryQuality.TwentyOneKarats;
            firstJewelry.JewelryWeight = 50;
            firstJewelry.JewelryDiscount = 5;
            firstJewelry.JewelryValue = rnd.Next(35000, 45000);
            firstJewelry.JewelryOtherDetails = "Perfectly Fine";
            JewelryList.Add(firstJewelry);

            firstCustomer.CustomerID = "C-" + Convert.ToString(rnd.Next(1, 9999));
            firstCustomer.CustomerName = "Emery Huang";
            firstCustomer.CustomerContactNumber = "0931 123 1423";
            firstCustomer.CustomerAddress = "Suite 3, California Street";
            CustomerList.Add(firstCustomer);

            firstLoan.TransactionID = "L-" + Convert.ToString(rnd.Next(1, 9999));
            firstLoan.LoanValue = 40000;
            firstLoan.Balance = firstLoan.LoanValue * 1.13;
            firstLoan.TransactionDate = DateTime.Today;
            firstLoan.JewelryID = firstJewelry.JewelryID;
            firstLoan.CustomerID = firstCustomer.CustomerID;
            ListOfLoans.Add(firstLoan);

            firstPayback.JewelryID = firstLoan.JewelryID;
            firstPayback.TransactionID = "P-" + Convert.ToString(rnd.Next(1, 9999));
            firstPayback.CustomerID = firstLoan.CustomerID;
            firstPayback.LoanValue = firstLoan.LoanValue;
            firstPayback.TransactionDate = DateTime.Today;
            firstPayback.Payment = 4000;
            firstPayback.FullInterestValue = firstPayback.LoanValue * 1.13;
            firstPayback.Balance = firstLoan.Balance;
            firstPayback.Balance = firstPayback.Balance - firstPayback.Payment;
            ListOfPaybacks.Add(firstPayback);

            foreach (var loan in ListOfLoans)
            {
                if (firstPayback.JewelryID == loan.JewelryID)
                {
                    loan.Balance = firstPayback.Balance;
                }
            }
        }

        //Executable Commands
        public ICommand CheckLoanCommand => new RelayCommand(CheckLoanProc);

        private void CheckLoanProc()
        {
            foreach (var loan in ListOfLoans)
            {
                if (InputJewelryID != null)
                {
                    if (InputJewelryID == loan.JewelryID)
                    {
                        Random rnd = new Random();
                        NewPayback = new Payback();

                        NewPayback.JewelryID = InputJewelryID;
                        NewPayback.TransactionID = "P-" + Convert.ToString(rnd.Next(1, 9999));
                        NewPayback.CustomerID = loan.CustomerID;
                        NewPayback.LoanValue = loan.LoanValue;
                        NewPayback.FullInterestValue = NewPayback.LoanValue * 1.13;
                        NewPayback.TransactionDate = DateTime.Today;
                        NewPayback.Balance = loan.Balance;

                        DisplayFullInterestValue = "Php " + Convert.ToString(NewPayback.FullInterestValue);
                        DisplayBalance = "Php " + Convert.ToString(loan.Balance);
                        foreach (var customer in CustomerList)
                        {
                            if (loan.CustomerID == customer.CustomerID)
                            {
                                DisplayCustomerName = customer.CustomerName;
                                DisplayCustomerContactNumber = customer.CustomerContactNumber;
                                DisplayCustomerAddress = customer.CustomerAddress;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a code.", "Error", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
        }

        public ICommand AddPaybackTransactionCommand => new RelayCommand(AddPaybackTransactionProc);

        private void AddPaybackTransactionProc()
        {
            if (InputPayment != null)
            {
                NewPayback.Payment = double.Parse(InputPayment);
                NewPayback.Balance = NewPayback.Balance - NewPayback.Payment;

                foreach (var loan in ListOfLoans)
                {
                    if (NewPayback.JewelryID == loan.JewelryID)
                    {
                        loan.Balance = NewPayback.Balance;
                    }
                }

                

                ListOfPaybacks.Add(NewPayback);

                MessageBox.Show("Payment received!", "Payment Successful", MessageBoxButton.OK,
                    MessageBoxImage.Information);

                InputPayment = null;
                InputJewelryID = null;
                DisplayFullInterestValue = null;
                DisplayBalance = null;
                DisplayCustomerName = null;
                DisplayCustomerContactNumber = null;
                DisplayCustomerAddress = null;
            }
            else
            {
                MessageBox.Show("Please enter a payment.", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            
        }

        public ICommand AddLoanTransactionCommand => new RelayCommand(AddLoanTransactionProc);

        private void AddLoanTransactionProc()
        {
            if (InputCustomerAddress != null && InputCustomerContactNumber != null && InputCustomerName != null &&
                InputJewelryDiscount != null && InputJewelryOtherDetails != null && InputJewelryValue != null &&
                InputJewelryWeight != null && InputLoanValue != null)
            {
                Random rnd = new Random();
                NewJewelry = new Jewelry();
                NewCustomer = new Customer();
                NewLoan = new Loan();

                NewJewelry.JewelryType = SelectedJewelryType;
                NewJewelry.JewelryQuality = SelectedJewelryQuality;
                NewJewelry.JewelryWeight = double.Parse(InputJewelryWeight);
                NewJewelry.JewelryDiscount = double.Parse(InputJewelryDiscount);
                NewJewelry.JewelryValue = double.Parse(InputJewelryValue);
                NewJewelry.JewelryOtherDetails = (InputJewelryOtherDetails);
                NewJewelry.JewelryID = "J-" + Convert.ToString(rnd.Next(1, 9999));
                JewelryList.Add(NewJewelry);

                NewCustomer.CustomerName = InputCustomerName;
                NewCustomer.CustomerContactNumber = InputCustomerContactNumber;
                NewCustomer.CustomerAddress = InputCustomerAddress;
                NewCustomer.CustomerID = "C-" + Convert.ToString(rnd.Next(1, 9999));
                CustomerList.Add(NewCustomer);

                NewLoan.LoanValue = double.Parse(InputLoanValue);
                NewLoan.Balance = NewLoan.LoanValue * 1.13;
                NewLoan.TransactionDate = DateTime.Today;
                NewLoan.TransactionID = "L-" + Convert.ToString(rnd.Next(1, 9999));
                NewLoan.JewelryID = NewJewelry.JewelryID;
                NewLoan.CustomerID = NewCustomer.CustomerID;
                ListOfLoans.Add(NewLoan);

                MessageBox.Show("Transaction submitted!", "Loan Transaction Successful", MessageBoxButton.OK,
                    MessageBoxImage.Information);

                InputCustomerAddress = null;
                InputCustomerContactNumber = null;
                InputCustomerName = null;
                InputJewelryDiscount = null;
                InputJewelryOtherDetails = null;
                InputJewelryValue = null;
                InputJewelryWeight = null;
                InputLoanValue = null;
            }
            else
            {
                MessageBox.Show("Please fill in all details.", "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
