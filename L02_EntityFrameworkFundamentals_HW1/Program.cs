using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_EntityFrameworkFundamentals_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (One_to_Many db = new One_to_Many())
            {
                // Creating articles.
                Article a1 = new Article { Name = "First Article", CreatingDate = new DateTime(2020, 01, 03) };
                Article a2 = new Article { Name = "Second Article", CreatingDate = new DateTime(2020, 05, 03) };
                Article a3 = new Article { Name = "Third Article", CreatingDate = new DateTime(2020, 06, 03) };
                Article a4 = new Article { Name = "Fourth Article", CreatingDate = new DateTime(2020, 08, 03) };
                Article a5 = new Article { Name = "Fifth Article", CreatingDate = new DateTime(2020, 09, 03) };

                db.Articles.AddRange(new List<Article> { a1, a2, a3, a4, a5 });
                db.SaveChanges();

                var articles = db.Articles.ToList();

                Console.WriteLine("Articles:");
                foreach (var article in articles)
                {
                    Console.WriteLine("{0}. {1}. Created {2} by {3}.", 
                        article.Id, article.Name, article.CreatingDate.ToShortDateString(), 
                        article.Author != null ? $"{article.Author.FName} {article.Author.LName}" : "No Author");
                }

                //Creating authors.
                Author autor1 = new Author
                { 
                    FName = "Robin",
                    LName = "Sloane",
                    DateOfBirth = new DateTime(1979, 12, 19),
                    Articles = new List<Article> { a1, a4, a5 }
                };

                Author autor2 = new Author
                {
                    FName = "Jason",
                    LName = "Miller",
                    DateOfBirth = new DateTime(1939, 04, 22),
                    Articles = new List<Article> { a2, a3 }
                };

                db.Authors.AddRange(new List<Author> { autor1, autor2 });
                db.SaveChanges();

                Console.WriteLine();
                Console.WriteLine("Articles with Authors:");
                foreach (var article in articles)
                {
                    Console.WriteLine("{0}. {1}. Created {2} by {3}.",
                        article.Id, article.Name, article.CreatingDate.ToShortDateString(),
                        article.Author != null ? $"{article.Author.FName} {article.Author.LName}" : "No Author");
                }

                // Display Articles by Authors.
                Console.WriteLine();
                Console.WriteLine("Articles by Authors:");

                var authors = db.Authors.ToList();

                foreach (var author in authors)
                {
                    Console.WriteLine("{0}. {1} {2} ({3})", 
                        author.Id, author.FName, author.LName, author.DateOfBirth.ToShortDateString());

                    if (author.Articles == null) continue;

                    foreach (var authorArticle in author.Articles)
                    {
                        Console.WriteLine("* {0} - created {1}",
                            authorArticle.Name, authorArticle.CreatingDate.ToShortDateString());
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
