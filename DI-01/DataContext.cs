using Microsoft.EntityFrameworkCore;
using DI_01.Models;

namespace DI_01
{
    public class DataContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DataContext(DbContextOptions options): base(options)
        {
          
        }
    }
}
