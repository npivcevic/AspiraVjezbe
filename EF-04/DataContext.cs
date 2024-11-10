using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EF_04
{
    internal class DataContext: DbContext
    {
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost; Initial Catalog=ef-04; Integrated Security=true; TrustServerCertificate=True");
        }
    }
}
