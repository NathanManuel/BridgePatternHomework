using BridgePattern.BookContentProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Books
{
    public  class AudioBook : IBook
    {

        private readonly IBookContentProvider _contentProvider;

        public AudioBook(IBookContentProvider contentProvider)
        {
            _contentProvider = contentProvider;
        }
        public void Publish()
        {
            IEnumerable<string> bookContent = _contentProvider.GetBookContent();
            Console.WriteLine("Succesfully uploaded book to Audioble." + "(the book has " + bookContent.Count() + " lines)" );
        }
    }
}
