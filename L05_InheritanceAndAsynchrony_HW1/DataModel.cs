namespace L05_InheritanceAndAsynchrony_HW1
{
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Linq;

    public class DataModel : DbContext
    {
        // Your context has been configured to use a 'DataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'L05_InheritanceAndAsynchrony_HW1.DataModel' database on your LocalDb instance. 
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

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<Smartphone> Smartphones { get; set; }
    }
}