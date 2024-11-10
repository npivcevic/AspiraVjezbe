using Microsoft.EntityFrameworkCore;

namespace EF_05
{
    internal class DataContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=localhost; Initial Catalog=ef-05; Integrated Security=true; TrustServerCertificate=True");
        }
    }
}
