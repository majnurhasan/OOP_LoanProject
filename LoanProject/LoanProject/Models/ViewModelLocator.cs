using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanProject.Module;

namespace LoanProject.Models
{
    public class ViewModelLocator
    {
        public TransactionModule TransactionModule { get; set; } = new TransactionModule();
        public OpenModule OpenModule { get; set; } = new OpenModule();
    }
}
