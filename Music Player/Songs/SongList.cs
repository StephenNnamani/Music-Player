using System;
using System.Collections.Generic;

namespace Music_Player.Songs
{
    public class SongList
    {
        public static List<SongModel> SongFact()
        {
            List<SongModel> songList = new List<SongModel>()
            {
                new SongModel
                {
                    SongName ="Goodness of God",
                    SongArtist = "Hillsongs",
                    SongGenre = "Gospel",
                    SongReleaseDate = DateTime.Now,
                    SongPlayLength = 4.3,
                },
                new SongModel
                {
                    SongName ="Devil Doesn't Bargain",
                    SongArtist = "Alec Benjamin",
                    SongGenre = "Love",
                    SongReleaseDate = DateTime.Now,
                    SongPlayLength = 2.43,
                },
                new SongModel
                {
                    SongName ="7 Years",
                    SongArtist = "Lukas Graham",
                    SongGenre = "True Life",
                    SongReleaseDate = DateTime.Now,
                    SongPlayLength = 3.57,
                },
                new SongModel
                {
                    SongName ="Soweto",
                    SongArtist = "Victony ft Tempoe",
                    SongGenre = "African Song",
                    SongReleaseDate = DateTime.Now,
                    SongPlayLength = 2.28,
                },
                new SongModel
                {
                    SongName ="Cough (Odo)",
                    SongArtist = "Kizz Daniel",
                    SongGenre = "Best Jonsing Love Song",
                    SongReleaseDate = DateTime.Now,
                    SongPlayLength = 2.56,
                }
            };
            return songList;
        }
    }
}
