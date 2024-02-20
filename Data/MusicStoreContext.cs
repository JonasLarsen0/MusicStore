using Microsoft.EntityFrameworkCore;
using MusicStore.Models;

namespace MusicStore.Data
{
    public class MusicStoreContext : DbContext
    {
        public MusicStoreContext(DbContextOptions<MusicStoreContext> options) : base(options)
        {
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().ToTable("Album");
            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Song>().ToTable("Song");
            modelBuilder.Entity<Playlist>().ToTable("Playlist");
        }
    }
}
