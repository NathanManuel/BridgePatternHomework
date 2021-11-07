using BridgePattern.BookContentProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Books
{
    public  class DigitalBook : IBook
    {
        private readonly IBookContentProvider _contentProvider;

        public DigitalBook(IBookContentProvider contentProvider)
        {
            _contentProvider = contentProvider;
        }

        public void Publish()
        {
            IEnumerable<string> bookContent = _contentProvider.GetBookContent();
            Console.WriteLine("Succesfully uploaded book to Amazon." + "(the book has " + bookContent.Count() + " lines)");
        }
        
    }
}
