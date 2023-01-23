using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        const string connectionString = "Server=DELLG15\\SQLEXPRESS;Database=Blog; Integrated Security =SSPI; TrustServerCertificate=True";
        public DbSet<Category> Categories { get; set; }

         public DbSet<Post> Posts { get; set; }
        // public DbSet<PostTag> PostTags { get; set; }
        //      public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        // public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(connectionString);
            options.LogTo(Console.WriteLine);

        }
    }
}