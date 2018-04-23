namespace WebDashboard_EFDataSource.Models {
    using System.Data.Entity;

    public partial class NorthwindDataModel : DbContext {
        public NorthwindDataModel()
            : base("name=NWindConnectionString") {
        }

        public virtual DbSet<SalesPerson> SalesPersons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);

            modelBuilder.Entity<SalesPerson>()
                .Property(e => e.Extended_Price)
                .HasPrecision(19, 4);
        }
    }
}
