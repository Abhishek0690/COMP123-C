using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK5_LAB18_tHEATRE
{
    enum DayEnum
    {
        Sun,
        Mon,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat
    }

    [Flags]
    enum GenreEnum
    {
        Unrated = 0,
        Action = 2,
        Comedy = 4,
        Horror = 8,
        Fantasy = 16,
        Musical = 32,
        Mystery = 64,
        Romance = 128,
        Adventure = 256,
        Animation = 512,
        Documentary = 1024,
    }
    struct Time
    {
        public int Hours { get;}
        public int Minutes { get;}

        public Time(int hours, int minutes = 0)
        {
            Hours = hours;
            Minutes = minutes;
        }
        public override string ToString()
        {
            return "";
        }
        static public bool operator == (Time lhs,Time rhs)
        {
            int v1 = (lhs.Hours * 60) + lhs.Minutes;
            int v2 = (rhs.Hours * 60) + rhs.Minutes;
            int diff = Math.Abs(v1 - v2);
            bool result = diff <= 15;
            return result;
        }
        static public bool operator != (Time lhs, Time rhs)
        {
            return !(lhs == rhs);
        }
    }
    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public GenreEnum Genre { get; private set; }
        public List<string> Cast { get; }
        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;
            Cast = new List<string>();
        }
        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(GenreEnum genre)
        {
            Genre = genre;
        }
    }
    struct Show
    {
        public double Price { get; }
        public DayEnum Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie, Time time,DayEnum day, double price)
        {
            Movie = movie;
            Time = time;
            Day = day;
            Price = price;
        }
        public override string ToString()
        {
            //Mon 11:35 Terminator 2: Judgement Day (1991) 105min (Action, Horror) Arnold Schwarzenegger, Linda Hamilton $5.95
            return $" {Day} {Time.Hours}:{Time.Minutes} {Movie.Title} , {Time} ({Movie.Genre}), {string.Join(", ",Movie.Cast)} ";
        }
    }

    class Theatre
    {
        private List<Show> shows;
        public string Name { get;}
        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        public void PrintShows()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine("All Shows");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Show show in shows)
            {
                Console.WriteLine($"{i}  {show}");
                i++;
            }
            Console.WriteLine("\n\n");
        }
        public void PrintShows(GenreEnum genre)
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{genre} Movies");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Show show in shows)
            {
                if(show.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine($"{i}  {show}");
                    i++;
                }
            }
            Console.WriteLine("\n\n");
        }
        public void PrintShows(DayEnum day)
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"Movies on {day}");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Show show in shows)
            {
                if(show.Day == day)
                {
                    Console.WriteLine($"{i}  {show}");
                    i++;
                }

            }
            Console.WriteLine("\n\n");
        }
        public void PrintShows(Time time)
        {
            Console.WriteLine($"Movies @{time.Hours}:{time.Minutes}");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Show show in shows)
            {
                if(show.Time == time)
                {
                    Console.WriteLine($"{i}  {show}");
                    i++;
                }
            }
            Console.WriteLine("\n\n");
        }
        public void PrintShows(string actor) 
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{actor} Movies");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Show show in shows)
            {
                if(show.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine($"{i}  {show}");
                    i++;
                }
            }
            Console.WriteLine("\n\n");
        }
        public void PrintShows(DayEnum day, Time time) 
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{day} Movies @ {time.Hours}:{time.Minutes}");
            Console.WriteLine("=============");
            int i = 1;
            foreach (Show show in shows)
            {
                if(show.Day == day || show.Time == time)
                {
                    Console.WriteLine($"{i}  {show}");
                    i++;
                }
            }
            Console.WriteLine("\n\n");
        }

    }
    internal class Theatres
    {
    }
}
