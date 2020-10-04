using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L02_EntityFrameworkFundamentals_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Many_to_Many db = new Many_to_Many())
            {
                // Creating Types.
                Type t1 = new Type { Name = "Classics" };
                Type t2 = new Type { Name = "Comic Books" };
                Type t3 = new Type { Name = "Detective and Mistery" };
                Type t4 = new Type { Name = "Fantasy" };
                Type t5 = new Type { Name = "Horror" };
                Type t6 = new Type { Name = "Romance" };
                Type t7 = new Type { Name = "Science Fiction" };
                Type t8 = new Type { Name = "Biographies" };
                Type t9 = new Type { Name = "Special E-book jenre" };

                db.Types.AddRange(new List<Type> { t1, t2, t3, t4, t5, t6, t7, t8, t9 });
                db.SaveChanges();

                var types = db.Types.ToList();

                foreach (var type in types)
                {
                    Console.WriteLine($"* {type.Name}");
                }
                Console.WriteLine();

                //Creating Sections.
                Section s1 = new Section { Name = "Books" };
                Section s2 = new Section { Name = "E-books"};

                db.Sections.AddRange(new List<Section> { s1, s2 });
                db.SaveChanges();

                var sections = db.Sections.ToList();

                foreach (var section in sections)
                {
                    Console.WriteLine($"* {section.Name}");
                }
                Console.WriteLine();

                // Adding Types to Sections.
                var books = db.Sections
                    .Where(b => b.Name == "Books")
                    .AsEnumerable()
                    .Select(b =>
                    {
                        b.Types = new List<Type> { t1, t2, t3, t4, t5, t6, t7, t8 };
                        return b;
                    });

                foreach (Section book in books)
                {
                    db.Entry(book).State = EntityState.Modified;
                }
                db.SaveChanges();

                var ebooks = db.Sections
                    .Where(eb => eb.Name == "E-books")
                    .AsEnumerable()
                    .Select(eb =>
                    {
                        eb.Types = new List<Type> { t1, t2, t3, t4, t5, t6, t7, t8, t9 };
                        return eb;
                    });

                foreach (Section ebook in ebooks)
                {
                    db.Entry(ebook).State = EntityState.Modified;
                }
                db.SaveChanges();

                // Sections and Types.
                var allSections = db.Sections.ToList();

                foreach  (var section in allSections)
                {
                    Console.WriteLine($"{section.Name}");

                    if (section.Types == null) continue;

                    foreach (var sectionType in section.Types)
                    {
                        Console.WriteLine($"* {sectionType.Name}");
                    }
                    Console.WriteLine();
                }

                // Adding Products.
                Product p1 = new Product { Name = "The Hunger Games", Types = new List<Type> { t7 } };
                Product p2 = new Product { Name = "Watchman", Types = new List<Type> { t2, t9 } };

                db.Products.AddRange(new List<Product> { p1, p2, p3});
                db.SaveChanges();

                //Sections, Types and Products.
                foreach (var section in allSections)
                {
                    Console.WriteLine($"{section.Name}");

                    if (section.Types == null) continue;

                    foreach (var sectionType in section.Types)
                    {
                        Console.WriteLine($" * {sectionType.Name}");

                        if (sectionType.Products == null) continue;

                        foreach (var product in sectionType.Products)
                        {
                            Console.WriteLine($"  - {product.Name}");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
