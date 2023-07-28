using CopyLingo.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CopyLingo.Core.Models
{
    public class DatabaseContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=copylingo;Integrated Security=true;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>()
                .Property(x => x.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);
        }

        public DbSet<Test> TblTest { get; set; }
        public DbSet<Word> TblWorldList { get; set; }
    }
}
