using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Entities;

namespace Library.Interfaces.Helpers
{
    interface ILoanHelper
    {
        ILoan makeLoan(IBook book, IMember borrower, DateTime borrowDate, DateTime dueDate, int id);

    }
}
