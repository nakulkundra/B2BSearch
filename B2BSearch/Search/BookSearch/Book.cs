using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace B2BSearch.Search.BookSearch
{
    public class Book
    {
        private Book()
        {
        }
        public Book(Xml book)
        {
            string x = book.ToString();
        }
    }
}
