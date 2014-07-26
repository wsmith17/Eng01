using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Library.Interfaces.Entities;
using Library.Interfaces.Helpers;

namespace Library.Interfaces.Daos
{
    interface IBookDAO
    {
        IBook addBook(string author, string title, string callNo);

        IBook getBookByID(int id);

        List<IBook> listBooks();

        List<IBook> findBooksByAuthor(string author);

        List<IBook> findBooksByTitle(string title);

        List<IBook> findBooksByAuthorTitle(string author, string title);

    }
}
