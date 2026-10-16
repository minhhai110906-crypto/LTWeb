using Microsoft.EntityFrameworkCore;
using PHMLesson9.Models;
using System.Reflection;
using System.Reflection.Metadata;

namespace PHMLesson9.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Khai báo các bảng dữ liệu tương ứng với các thực thể trong đề bài
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}