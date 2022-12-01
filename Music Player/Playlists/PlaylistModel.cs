using Music_Player.Songs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Playlists
{
    internal class PlaylistModel
    {
        public string Name { get; set;}
        public  List<SongModel> NameOfSong { get; set; }
    }
}
