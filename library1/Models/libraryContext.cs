using Microsoft.EntityFrameworkCore;

namespace library1.Models
{
    public class libraryContext : DbContext
    {
        internal readonly object Alerts;

        public libraryContext(DbContextOptions<libraryContext> options)
           : base(options)
        { }
        public DbSet<user>? users { get; set; }
        public DbSet<book>? books { get; set; }
        public DbSet<author>? authors { get; set; }
        public DbSet<genre>? genres { get; set; }
        public DbSet<mainGenre>? mainGenres { get; set; }
        public DbSet<typeOfBook>? typeOfBooks { get; set; }
        public DbSet<favoriteBooks>? favoriteBooks { get; set; }
        public DbSet<placeHoldBooks>? placeHoldBooks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<placeHoldBooks>()
                .HasKey(t => new { t.bookID, t.userID });

            modelBuilder.Entity<favoriteBooks>()
                .HasKey(t => new { t.bookID, t.userID });
        }
    }
}
