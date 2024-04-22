using LibraryManagementShared;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementServer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
