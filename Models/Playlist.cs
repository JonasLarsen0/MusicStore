﻿namespace MusicStore.Models
{
    public class Playlist
    {
        public int PlaylistId { get; set; }
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
