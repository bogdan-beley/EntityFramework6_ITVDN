using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03_LINQFeatures_HW
{
    class MyContexInitializer : DropCreateDatabaseAlways<DataModel>
    {
        protected override void Seed(DataModel context)
        {
            var authors = new List<Author>
            {
                new Author { FName = "Stephen Edwin", LName = "King", DateOfBirth = new DateTime(1947, 09, 21) },
                new Author { FName = "John Ronald Reuel", LName = "Tolkien", DateOfBirth = new DateTime(1892, 01, 03) },
                new Author { FName = "Charles", LName = "Dickens", DateOfBirth = new DateTime(1812, 02, 07) },
                new Author { FName = "Joanne", LName = "Rowling", DateOfBirth = new DateTime(1965, 07, 31) },
                new Author { FName = "Edgar Allan", LName = "Poe", DateOfBirth = new DateTime(1809, 01, 19) },
            };

            context.Authors.AddRange(authors);
            context.SaveChanges();

            var books = new List<Book>
            {
                new Book { Name = "The Green Mile", Author = authors.FirstOrDefault(a => a.Id == 1) },
                new Book { Name = "The Stand", Author = authors.FirstOrDefault(a => a.Id == 1) },
                new Book { Name = "The Shining", Author = authors.FirstOrDefault(a => a.Id == 1) },
                new Book { Name = "The Hobbit", Author = authors.FirstOrDefault(a => a.Id == 2) },
                new Book { Name = "The Lord of the Rings", Author = authors.FirstOrDefault(a => a.Id == 2) },
                new Book { Name = "The Silmarillion", Author = authors.FirstOrDefault(a => a.Id == 2) },
                new Book { Name = "Little Dorrit", Author = authors.FirstOrDefault(a => a.Id == 3) },
                new Book { Name = "Great Expectations", Author = authors.FirstOrDefault(a => a.Id == 3) },
                new Book { Name = "Our Mutual Friend", Author = authors.FirstOrDefault(a => a.Id == 3) },
                new Book { Name = "Oliver Twist", Author = authors.FirstOrDefault(a => a.Id == 3) },
                new Book { Name = "Harry Potter", Author = authors.FirstOrDefault(a => a.Id == 4) },
                new Book { Name = "Fantastic Beasts and Where to Find Them", Author = authors.FirstOrDefault(a => a.Id == 4) },
                new Book { Name = "The black cat and other stories", Author = authors.FirstOrDefault(a => a.Id == 5) },
                new Book { Name = "The Murders in the Rue Morgue", Author = authors.FirstOrDefault(a => a.Id == 5) },
                new Book { Name = "The Purloined letter", Author = authors.FirstOrDefault(a => a.Id == 5) }
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
}
