using BridgePattern.BookContentProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.Books
{
    public  class PrintBook : IBook
    {
      
        
        private readonly IBookContentProvider _contentProvider;

        public PrintBook(IBookContentProvider contentProvider)
        {
            _contentProvider = contentProvider;
        }
        public void Publish()
        {
            IEnumerable<string> bookContent = _contentProvider.GetBookContent();
            Console.WriteLine("Succesfully printed book" + "(the book has " + bookContent.Count() + " lines)");
        }
    }
}
