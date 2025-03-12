using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;
namespace FirstWebMVC.Data
{
    public class ApplicationDbContext : Dbcontext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {}
        public DbSet<Person> Persons { get; set; }
    }
}