using Microsoft.EntityFrameworkCore;
using WebAPI_02.Models;

namespace WebAPI_02
{
    public class DataContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DataContext(DbContextOptions options): base(options)
        {
          
        }
    }
}
