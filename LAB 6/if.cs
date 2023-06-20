using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6
{
    enum MedalColor { Bronze, Silver, Gold }
    class Medal
    {
        public string Name { get;  }
        public string TheEvent { get; }
        public MedalColor Color { get; }
        public int Year { get;}
        public bool IsRecord { get; }

        public Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }

        public override string ToString()
        {
            return $"{Year} - {TheEvent} ({(IsRecord ? "R" : "")}) {Name}({Color})";
        }
        static void Main(string[] args)
        {
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);
            //print the object
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);
            //create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);
            //print the updated m2
            Console.WriteLine(m2);
            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };
            medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));
            //prints a numbered list of 16 medals.
            int cout = 1;
            Console.WriteLine("\n\nAll 16 medals");
            foreach (var item in medals)
            {
                Console.WriteLine($"{cout++,2} - {item}" );
            }
            int cout2 = 1;
            //prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            foreach (var item in medals)
            {
                Console.WriteLine($"{cout2++,2} - {item.Name}");
            }
            //prints a numbered list of 9 gold medals
            int cout3 = 1;
            Console.WriteLine("\n\nAll 9 gold medals");
            foreach (var item in medals)
            {
                if (item.Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{cout3++, 2} - {item.Name} - {item.Year}");
                }
            }
            //prints a numbered list of 9 medals in 2012
            int c = 1;
            Console.WriteLine("\n\nAll 9 medals");
            foreach (var item in medals)
            {
                if(item.Year == 2012)
                {
                    Console.WriteLine($"{c++,2} - {item.Name} - {item.Color}");
                }
            }

            //prints a numbered list of 4 gold medals in 2012
            int a = 1;
            
            Console.WriteLine("\n\nAll 4 gold medals");
            foreach (var item in medals)
            {
                if (item.Color == MedalColor.Gold && item.Year == 2012)
                {
                    Console.WriteLine($"{a++,2} - {item.Name}  ");
                }
            }
            //prints a numbered list of 3 world record medals
            int w = 1;
            Console.WriteLine("\n\nAll 3 records");
            foreach(var item in medals)
            {
                if (item.IsRecord == true)
                {
                    Console.WriteLine($"{w++,2} - {item.Name} - {item.Year}");
                }
            }
            //saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            TextWriter writer = new StreamWriter("D:\\College\\COMP123 - C#\\Class Labs\\Week1 Lab1\\LAB 6\\Medals.txt");
            foreach (var item in medals)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
    }
}
