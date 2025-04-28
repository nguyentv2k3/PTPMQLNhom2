using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace MvcMovie.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>


    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Person> Person { get; set; }
        public DbSet<MvcMovie.Models.Customer> Customer { get; set; } = default!;
        public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;

        // Thêm đoạn cấu hình OnModelCreating này
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Cấu hình kế thừa TPH (Table per Hierarchy)
            modelBuilder.Entity<Person>()
                .UseTphMappingStrategy()
                .HasDiscriminator<string>("Discriminator")
                
                .HasValue<Person>("Person")
                .HasValue<Employee>("Employee")
                .HasValue<Customer>("Customer"); // Nếu không dùng Customer thì xóa dòng này
        }
    }
}
