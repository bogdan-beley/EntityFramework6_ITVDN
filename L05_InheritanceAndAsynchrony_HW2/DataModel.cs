namespace L05_InheritanceAndAsynchrony_HW2
{
    using L05_InheritanceAndAsynchrony_HW2.Configuration;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataModel : DbContext
    {
        // Your context has been configured to use a 'DataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'L05_InheritanceAndAsynchrony_HW2.DataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DataModel' 
        // connection string in the application configuration file.
        static DataModel()
        {
            Database.SetInitializer(new DataModelInitializer());
        }

        public DataModel()
            : base("name=DataModel")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PhonebookConfig());
            modelBuilder.Configurations.Add(new ContactConfig());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Phonebook> Phonebooks { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
    }
}