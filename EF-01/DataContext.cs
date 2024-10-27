using Microsoft.EntityFrameworkCore;

namespace EF_01
{
    internal class DataContext: DbContext
    {
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseInMemoryDatabase("test");
    }
}
