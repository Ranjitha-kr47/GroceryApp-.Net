using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Api_project.Properties.Models
{
    public class ApplicationContext : IdentityDbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Register> register { get; set; }
        
        public DbSet<Address> address { get; set; }


        public DbSet<Country> country{ get; set; }


        public DbSet<Customer> customers { get; set; }
        
        public DbSet<Order> orders { get; set; }
        
        public DbSet<OrderItem> orderitem { get; set; }
        
        public DbSet<Product> product { get; set; }

        public DbSet<ProductCategory> productCategories { get; set; }
        
        public DbSet<State> state { get; set; }

        public DbSet<Login> login { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            // builder.Entity<Register>()
            //     .Property(b => b.Password)
            //     .IsRequired();
            //base.OnModelCreating(builder);
            builder.Entity<IdentityUserRole<string>>().ToTable("aspnetuserroles");
            builder.Ignore<IdentityUserLogin<string>>();
            //builder.Ignore <IdentityUserRole<string>>();
            //builder.Ignore<IdentityUserClaim<string>>();
            builder.Ignore<IdentityUserToken<string>>();
            // builder.Ignore<IdentityUser<string>>();
            //builder.Ignore<ApplicationUser>();

        }
    }
}
