using Music_Player.Playlists;
using Music_Player.Songs;
using Music_Player.Utility;
using System;

namespace Music_Player.UI
{
    internal class WelcomeNote
    {
        public static void Welcome()
        {
            Headings.Heading("Soft Ears");
            Console.WriteLine("\n1. List Available Songs\t\t2. My Playlists\n3. Add new song\t\t\t4. Exit");
            int selected;
            bool checker;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out selected))
                {
                    if (selected < 0 || selected > 4)
                    {
                        checker = false;
                    }else if(selected == 1)
                    {
                        loading.Loading();
                        Console.Clear();
                        Console.WriteLine("\t\t************* MY SONGS *************");
                        var TotalSongs = AddNewSong.TotalSongs; int i = 1;
                        foreach(var s in TotalSongs)
                        {
                            Colors.Yellow($"{i}: {s.SongName}");
                            Console.WriteLine($"\t{s.SongArtist}\n\t{s.SongReleaseDate}\n");
                            Console.WriteLine("-----------------------------------------------------------------------------");
                            i++;
                        }
                    }
                    else if (selected == 2)
                    {
                        loading.Loading();
                        Console.Clear();
                        Console.WriteLine("\t\t************* MY Playlists *************");
                        
                    }
                    else if(selected == 3)
                    {

                    }
                    else if(selected == 4)
                    {
                        Console.WriteLine("Thank you for using our Music APP\nPress any key to terminate");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
