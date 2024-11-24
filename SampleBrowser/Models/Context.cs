using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleBrowser.Models
{
    public class Context : DbContext
    {

        public DbSet <ArtistModel> Artists { get; set; }
        public DbSet<SongModel> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Get the path of the app's current directory
            string appDirectory = Directory.GetCurrentDirectory();

            // Set the database file path relative to the app directory
            string dbPath = Path.Combine(appDirectory, "SampleBrowser.db");

            // Configure SQLite to use this path
            options.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongModel>()
                .HasOne(s => s.Artist) // Each Song has one Artist
                .WithMany(a => a.Songs) // Each Artist can have many Songs
                .HasForeignKey(s => s.ArtistId); // Foreign key in Song
        }
       

    }
}









