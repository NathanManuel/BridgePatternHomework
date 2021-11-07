using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookContentProvider
{
    class BridgeBookContentProvider : IBookContentProvider
    {
        IEnumerable<string> IBookContentProvider.GetBookContent()
        {
            return new List<string>()
            {
                "This is a book about the Bridge Pattern",
                "This is the content of the book",
                "Aditional info about the book"
            };
        }
    }
}
