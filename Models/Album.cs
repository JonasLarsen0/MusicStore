namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string GenreId { get; set; }
        public int ArtistId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public ICollection<Artist> Artists { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}
