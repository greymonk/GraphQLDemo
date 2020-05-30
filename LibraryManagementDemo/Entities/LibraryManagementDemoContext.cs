using Microsoft.EntityFrameworkCore;

namespace LibraryManagementDemo.Entities
{
    public partial class LibraryManagementDemoContext : DbContext
    {
        public LibraryManagementDemoContext()
        {
        }

        public LibraryManagementDemoContext(DbContextOptions<LibraryManagementDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
    }
}