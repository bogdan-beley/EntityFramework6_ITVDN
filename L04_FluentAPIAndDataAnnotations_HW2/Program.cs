using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace L04_FluentAPIAndDataAnnotations_HW2
{
    // Data Annotations Attributes
    class Program
    {
        static void Main(string[] args)
        {
            ForumModel db = new ForumModel();

            var query = db.Forums.Include(f => f.Messages);

            foreach (var forum in query)
            {
                Console.WriteLine($"{forum.Id}. {forum.Name}:");

                if (forum.Messages.Count <= 0)
                {
                    Console.WriteLine("There are no messages.");
                    continue;
                }

                foreach (var message in forum.Messages)
                {
                    Console.WriteLine($" * {message.Id}. {message.Text}. Status: {message.Status}");
                }
            }
        }
    }
}
