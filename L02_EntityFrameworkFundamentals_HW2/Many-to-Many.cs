namespace L02_EntityFrameworkFundamentals_HW2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Many_to_Many : DbContext
    {
        public Many_to_Many()
            : base("name=ManyToManyModel")
        {
            Database.SetInitializer<Many_to_Many>(new DropCreateDatabaseAlways<Many_to_Many>());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Type> Types { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(e => e.Types)
                .WithMany(e => e.Products)
                .Map(m => m.ToTable("ProductsTypes").MapLeftKey("ProductId").MapRightKey("TypeId"));

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Types)
                .WithMany(e => e.Sections)
                .Map(m => m.ToTable("SectionsTypes").MapLeftKey("SectionId").MapRightKey("TypeId"));
        }
    }
}
