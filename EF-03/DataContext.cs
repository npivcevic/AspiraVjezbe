using Microsoft.EntityFrameworkCore;

namespace EF_03
{
    internal class DataContext: DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost; Initial Catalog=ef-03; Integrated Security=true; TrustServerCertificate=True");
        }
    }
}
