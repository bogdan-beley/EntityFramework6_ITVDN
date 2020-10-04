using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace L03_LINQFeatures_HW
{
    class Program
    {
        public static void OutpootBooks(IQueryable<Book> queryable)
        {
            foreach (var book in queryable)
            {
                Console.WriteLine($"{book.Id}. {book.Name}");
            }
            Console.WriteLine();
        }

        public static void OutpootBook(Book book)
        {
            if (book != null)
                Console.WriteLine($"{book.Id}. {book.Name}");
            Console.WriteLine();
        }

        public static void OutpootAuthors(IQueryable<Author> queryable)
        {
            foreach (var author in queryable)
            {
                Console.WriteLine($"{author.Id}. {author.FName} {author.LName} - {author.DateOfBirth.ToShortDateString()}");
            }
            Console.WriteLine();
        }

        public static void OutpootAuthor(Author author)
        {
            if (author != null)
                Console.WriteLine($"{author.Id}. {author.FName} {author.LName} - {author.DateOfBirth.ToShortDateString()}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            using (DataModel db = new DataModel())
            {
                // First()
                Console.WriteLine("Find first author by Id:");
                var book1 = db.Books.First(b => b.Id == 5);
                OutpootBook(book1);

                // FirstOrDefault()
                Console.WriteLine("FirstOfDefault author by Id:");
                var book2 = db.Books.FirstOrDefault(b => b.Id == 3);
                OutpootBook(book2);

                // OrderBy()
                Console.WriteLine("Authors ordered by date of birth:");
                var authors1 = db.Authors
                    .OrderBy(a => a.DateOfBirth);
                OutpootAuthors(authors1);

                // Count()
                int numberOfBooks = db.Books.Count();
                Console.WriteLine($"Number of Books: {numberOfBooks}");
                Console.WriteLine();

                // Min()
                Console.WriteLine("The oldest author from the list:");
                var author1 = db.Authors
                    .Where(a => a.DateOfBirth == db.Authors.Min(ar => ar.DateOfBirth)).FirstOrDefault();
                OutpootAuthor(author1);

                // Max()
                Console.WriteLine("The youngest author from the list:");
                var author2 = db.Authors
                    .Where(a => a.DateOfBirth == db.Authors.Max(ar => ar.DateOfBirth)).FirstOrDefault();
                OutpootAuthor(author2);

                // Average()
                Console.WriteLine("The averege age of authors from the list -):");
                var author3 = db.Authors
                    .Average(a => (DateTime.Now.Year - a.DateOfBirth.Year));
                Console.WriteLine($"{author3} years");
                Console.WriteLine();

                // Include()
                Console.WriteLine("All books by Tolkien:");
                var books1 = db.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.LName == "Tolkien");
                OutpootBooks(books1);

                // Select()
                Console.WriteLine("Books and Authors:");
                var books2 = db.Books
                    .Select(b => new { b.Id, b.Name, AuthorName = b.Author.FName, AuthorSurname = b.Author.LName });

                foreach (var book in books2)
                {
                    Console.WriteLine($"{book.Id}. {book.Name} - {book.AuthorName} {book.AuthorSurname}");
                }
                Console.WriteLine();

                // Find()
                Console.WriteLine("Find an author by Id:");
                var author4 = db.Authors
                    .Find(3);
                OutpootAuthor(author4);







            }
        }
    }
}
