using Microsoft.EntityFrameworkCore;
using RESR_API_TEMPLATE.Models;
using REST_API_TEMPLATE.Data;

namespace RESR_API_TEMPLATE.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }
        public DbSet<Author> Authors { get; set; }  
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>()
                .HasOne(x => x.Author)
                .WithMany(x => x.Books);

            new DbInitializer(builder).Seed();
        }
    }
}
