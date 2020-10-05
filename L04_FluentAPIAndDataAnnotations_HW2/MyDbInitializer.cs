using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L04_FluentAPIAndDataAnnotations_HW2
{
    class MyDbInitializer : DropCreateDatabaseAlways<ForumModel>
    {
        protected override void Seed(ForumModel db)
        {
            var forums = new List<Forum>()
            {
                new Forum {Name = "Code Forum"},
                new Forum {Name = "Design Forum"},
                new Forum {Name = "Developers Forum"}
            };

            db.Forums.AddRange(forums);
            db.SaveChanges();

            var messages = new List<Message>()
            {
                new Message {Text = "Some message on Code Forum", Status = true, ForumId = 1},
                new Message {Text = "Some message on Code Forum",  Status = false, ForumId = 1},
                new Message {Text = "Some message on Developers Forum", Status = true, ForumId = 3}
            };

            db.Messages.AddRange(messages);
            db.SaveChanges();
        }
    }
}
