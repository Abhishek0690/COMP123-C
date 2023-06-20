using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LAB_9_SONGS
{
   
    enum SongGenre
    {
        Unclassified = 0,
        Pop = 0b1,
        Rock = 0b10,
        Blues = 0b100,
        Country = 0b1_000,
        Metal = 0b10_000,
        Soul = 0b100_000,
    }
    class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Length { get; }
        public SongGenre Genre { get; }
        public Song(string title, string artist, double length, SongGenre genre)
        {
            Title = title;
            Artist = artist;
            Length = length;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Title} by {Artist} ({Genre}) {Length}min";
        }
    }
    static class Library
    {
        static List<Song> songs = new List<Song>();
        static public void LoadSongs(string filename)
        {
            string title,artist;
            double length;
            SongGenre genre;
            StreamReader reader = new StreamReader(filename);
            while ((title = reader.ReadLine()) != null)
            {
                artist = reader.ReadLine();
                length = Convert.ToDouble(reader.ReadLine());
                genre = (SongGenre)Enum.Parse(typeof(SongGenre), reader.ReadLine());
                songs.Add(new Song(title, artist, length, genre));
            }
            reader.Close();
        }
    
        static public void DisplaySongs()
        {
            foreach (Song s in songs)
            {
                Console.WriteLine(s);
            }
        }
        static public void DisplaySongs(double longerThan)
        {
            foreach (Song s in songs)
            {
                if(s.Length > longerThan)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static public void DisplaySongs(SongGenre genre)
        {
            foreach (Song s in songs)
            {
                if (s.Genre == genre)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static public void DisplaySongs(string artist)
        {
            foreach (Song s in songs)
            {
                if (s.Artist == artist)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
    internal class Songs
    {
    }
}
