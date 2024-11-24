using Microsoft.EntityFrameworkCore;
using DTO_01.Models;

namespace DTO_01
{
    public class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions options): base(options)
        {
          
        }
    }
}
