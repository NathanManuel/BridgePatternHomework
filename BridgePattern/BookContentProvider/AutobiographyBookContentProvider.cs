using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.BookContentProvider
{
   public class AutobiographyBookContentProvider : IBookContentProvider
    {
        IEnumerable<string> IBookContentProvider.GetBookContent()
        {
            return new List<string>()
            {
                "This is the title of the book",
                "This is the content of the book"
            };
        }
    }
}
