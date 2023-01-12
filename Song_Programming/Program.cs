using System;
using System.Collections.Generic;

namespace Song_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the number of songs: ");
            int numSongs = int.Parse(Console.ReadLine());

            List<Song_Programming.Song> songs = new List<Song_Programming.Song>();

            for (int i = 0; i < numSongs; i++)
            {
                string[] data = Console.ReadLine().Split('_');

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song_Programming.Song song = new Song_Programming.Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            Console.Write("Please enter the TypeList of song: ");
            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Song_Programming.Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song_Programming.Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }
}
