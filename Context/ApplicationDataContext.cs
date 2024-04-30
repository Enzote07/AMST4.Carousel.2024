using AMST4.CAROUSEL.Models;
using Microsoft.EntityFrameworkCore;

namespace AMST4.CAROUSEL.Context
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> option) : base(option) { }
        public DbSet<Category> Category { get; set; }
    }
}
