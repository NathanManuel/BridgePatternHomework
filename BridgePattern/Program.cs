using BridgePattern.BookContentProvider;
using BridgePattern.Books;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookContentProvider contentProvider1 = new AutobiographyBookContentProvider();
            PrintBook book = new PrintBook(contentProvider1);
            book.Publish();

            IBookContentProvider contentProvider2 = new BridgeBookContentProvider();
            DigitalBook digitaBook = new DigitalBook(contentProvider2);
            digitaBook.Publish();

            PrintBook printBook = new PrintBook(contentProvider2);
            printBook.Publish();
        }
    }
}
