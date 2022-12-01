using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Songs
{
    public class SongModel
    {
        public string? SongName { get; set; }
        public string? SongArtist { get; set; }
        public string? SongGenre { get; set; }
        public DateTime SongReleaseDate { get; set; }
        public double SongPlayLength { get; set; }
    }
}
