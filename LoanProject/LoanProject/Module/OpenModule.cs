using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LoanProject.Views;

namespace LoanProject.Module
{
    public class OpenModule : ObservableObject
    {
        private LoanView _loanView;
        private PaybackView _paybackView;
        private ListOfTransactionsView _listOfTransactionsView;

        public ICommand ShowLoanViewCommand => new RelayCommand(ShowLoanViewProc);

        private void ShowLoanViewProc()
        {
            _loanView = new LoanView();
            _loanView.Owner = Application.Current.MainWindow;
            _loanView.ShowDialog();
        }

        public ICommand ShowPaybackViewCommand => new RelayCommand(ShowPaybackViewProc);

        private void ShowPaybackViewProc()
        {
            _paybackView = new PaybackView();
            _paybackView.Owner = Application.Current.MainWindow;
            _paybackView.ShowDialog();
        }

        public ICommand ShowListOfTransactionsViewCommand => new RelayCommand(ShowListOfTransactionsViewProc);

        private void ShowListOfTransactionsViewProc()
        {
            _listOfTransactionsView = new ListOfTransactionsView();
            _listOfTransactionsView.Owner = Application.Current.MainWindow;
            _listOfTransactionsView.ShowDialog();
        }
    }
}
