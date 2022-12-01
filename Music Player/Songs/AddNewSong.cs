using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player.Songs
{
    internal class AddNewSong
    {
        public static List<SongModel> TotalSongs = SongList.SongFact();
        public static List<SongModel> NewSong()
        {
            //var newSongList = SongList.SongFact();

            Console.Write("Input the name of Song: ");
            string name = Console.ReadLine();
            Console.Write("Input the name of Artist: ");
            string artist = Console.ReadLine();
            Console.Write("Input the name of Genre: ");
            string genre = Console.ReadLine();
            songDuration: Console.Write("Input the duration of the song: ");
            if(double.TryParse(Console.ReadLine(), out double songLength))
            {

                SongModel newSong = new SongModel()
                {
                    SongName = name,
                    SongArtist = artist,
                    SongGenre = genre,
                    SongReleaseDate = DateTime.Now,
                    SongPlayLength = songLength,
                };
                TotalSongs.Add(newSong);
            }
            else
            {
                Console.WriteLine("Please type a number.");
                goto songDuration;
            }

            return TotalSongs;
        }
    }
}
