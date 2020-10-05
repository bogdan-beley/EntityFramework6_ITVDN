using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace L04_FluentAPIAndDataAnnotations_HW1
{
    // Fluent API Model Config
    class Program
    {
        static void Main(string[] args)
        {
            DataModel db = new DataModel();

            var query = db.Blogs.Include(b => b.Articles);

            foreach (var blog in query)
            {
                Console.WriteLine($"{blog.Id}. {blog.Name}:");

                if (blog.Articles == null) continue;

                foreach (var article in blog.Articles)
                {
                    Console.WriteLine($" * {article.Id}. {article.Title}: {article.Text}");
                }
            }


        }
    }
}
