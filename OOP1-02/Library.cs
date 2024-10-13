using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramiranjeUDotNetuOOPVjezba2
{
    internal class Library
    {
        private List<Book> BookList { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            BookList.Add(book);
        }

        public void PrintTitles()
        {
            foreach (Book book in BookList)
            {
                Console.WriteLine($"Title: {book.Title}");
            }
        }

        public void PrintUniqueAuthors()
        {
            List<string> authors = new List<string>();

            foreach (Book book in BookList)
            {
                if (authors.Contains(book.Author))
                {
                    continue;
                }
                authors.Add(book.Author);
            }

            foreach (string author in authors) {
                Console.WriteLine($"Author: {author}");
            }
        }
    }
}
