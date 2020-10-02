namespace L02_EntityFrameworkFundamentals_HW1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;

    public class One_to_Many : DbContext
    {
        // Your context has been configured to use a 'One_to_Many' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'L02_EntityFrameworkFundamentals_HW1.One_to_Many' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'One_to_Many' 
        // connection string in the application configuration file.
        public One_to_Many()
            : base("name=One-to-Many")
        {
            Database.SetInitializer<One_to_Many>(new DropCreateDatabaseAlways<One_to_Many>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }
}