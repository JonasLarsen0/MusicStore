namespace MusicStore.Models
{
    public class Song
    {
        public int SongID { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }
        public int AlbumId { get; set; }
        ICollection<Artist> Artists { get; set; }
    }
}
