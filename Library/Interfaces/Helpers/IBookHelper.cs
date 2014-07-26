using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Entities;

namespace Library.Interfaces.Helpers
{
    interface IBookHelper
    {
        IBook makeBook(string author, string title, string callNumber, int id);

    }
}
