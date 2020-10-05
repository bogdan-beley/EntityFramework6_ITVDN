namespace L04_FluentAPIAndDataAnnotations_HW2
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ForumModel : DbContext
    {
        // Your context has been configured to use a 'ForumModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'L04_FluentAPIAndDataAnnotations_HW2.ForumModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ForumModel' 
        // connection string in the application configuration file.
        static ForumModel()
        {
            Database.SetInitializer<ForumModel>(new MyDbInitializer());
        }

        public ForumModel()
            : base("name=ForumModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Forum> Forums { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
    }
}