using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace L04_FluentAPIAndDataAnnotations_HW1
{
    class MyDbInitializer : DropCreateDatabaseAlways<DataModel>
    {
        protected override void Seed(DataModel db)
        {
            var blogs = new List<Blog>()
            {
                new Blog {Name = "Code Blog"},
                new Blog {Name = "Design Blog"}

            };

            db.Blogs.AddRange(blogs);
            db.SaveChanges();

            var articles = new List<Article>()
            {
                new Article {Title = "Start coding", Text = "Some text...", BlogId = 1},
                new Article {Title = "Code Examples", Text = "Some text...", BlogId = 1},
                new Article {Title = "Design technics", Text = "Some text...", BlogId = 2}
            };

            db.Articles.AddRange(articles);
            db.SaveChanges();
        }
    }
}
