using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EF_02
{
    internal class DataContext: DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string dbPath = Path.Combine(AppContext.BaseDirectory, "../../..", "app.db");
            options.UseSqlite($"Data Source={dbPath}");
        }
    }
}
