using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LINQ_Queries
{
    internal class Program
    {
        static List<Student> students = new List<Student> 
        {
            new Student{ First="Xavier", Last="Thomas", Id=111, Scores=new List<int>{97,92 ,81 , 55, 60 } },
            new Student{ First="Lyoid", Last="Lopes", Id=112, Scores=new List<int>{96, 88, 86, 77, 55 } },
            new Student{ First="Navdeep", Last="Singh", Id=113, Scores=new List<int>{92, 97, 65, 89, 45} },
            new Student{ First="Lyle", Last="Spurrell", Id=114, Scores=new List<int>{90, 95, 75, 78, 83 } },
            new Student{ First="Viktor", Last="Salnichenko", Id=115, Scores=new List<int>{87, 96, 65, 34, 90} },
            new Student{ First="Sukhpratap", Last="Singh", Id=116, Scores=new List<int>{90, 87, 56, 98, 78 } },
            new Student{ First="Dannel", Last="Alon", Id=117, Scores=new List<int>{90, 84,59 ,67 , 98 } },
            new Student{ First="Francis", Last="Acheampong", Id=118, Scores=new List<int>{89, 56, 56, 67, 87 } },
            new Student{ First="Mahamod", Last="Masleh", Id=119, Scores=new List<int>{67, 78,46 , 78, 98 } },
            new Student{ First="John", Last="Calma", Id=120, Scores=new List<int>{89, 76, 78, 67, 87} },
            new Student{ First="Sarina", Last="Luu", Id=121, Scores=new List<int>{67, 67, 87, 74, 95} },
            new Student{ First="Valerie", Last="Chan", Id=122, Scores=new List<int>{87, 69, 95, 67, 49} },
            new Student{ First="Tej", Last="Singh", Id=127, Scores=new List<int>{90, 87, 96, 98, 78 } },
            new Student{ First="Mabel", Last="Tang", Id=123, Scores=new List<int>{87, 78,59 , 75, 67} },
            new Student{ First="Rishav", Last="Giri", Id=124, Scores=new List<int>{65, 87, 58, 92, 68} },
            new Student{ First="Toni", Last="Lea", Id=125, Scores=new List<int>{78, 97, 83, 83, 87} },
            new Student{ First="Melanie", Last="March", Id=126, Scores=new List<int>{89, 79, 80, 95, 97 } }
        };

        static List<Person> persons = new List<Person>()
        {
            new Person(){ Age = 72, Asset = 7.0, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
            new Person(){ Age = 67, Asset = 7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
            new Person(){ Age = 81, Asset = 3.1, Country="India", IsFemale=true, Name="Indu Jain"},
            new Person(){ Age = 70, Asset = 2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
            new Person(){ Age = 77, Asset = 27.0, Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
            new Person(){ Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo"},
            new Person(){ Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten"},
            new Person(){ Age = 53, Asset = 20.0, Country = "US",IsFemale = true,Name = "Laurene Jobs"},
            new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale=false, Name="Aliko Dangote" },
            new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
            new Person(){ Age = 60, Asset = 30.7, Country = "Canada", IsFemale=false, Name="David Thomson" },
            new Person(){ Age = 76, Asset = 11.4, Country = "Canada", IsFemale=false, Name="Galen Weston"},
            new Person(){ Age = 60, Asset = 22.3, Country = "India", IsFemale=false, Name="Mukesh Ambani"},
            new Person(){ Age = 50, Asset = 17.5, Country = "India", IsFemale=false, Name="Dilip Shanghvi"},
            new Person(){ Age = 83, Asset = 30.4, Country = "US", IsFemale=false, Name="Sheldon Adelson"},
            new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", IsFemale=false, Name="Jorge Lemann"},
            new Person(){ Age = 62, Asset = 18.4, Country = "Russia", IsFemale=false, Name="Leonid Mikhelson"},
            new Person(){ Age = 51, Asset = 17.5, Country = "Russia", IsFemale=false, Name="Alexey Mordashov"},
            new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale=false, Name="Li Ka-shing"},
            new Person(){ Age = 62, Asset = 31.2, Country = "China", IsFemale=false, Name="Wang Jianlin"},
            new Person(){ Age = 67, Asset = 33.8, Country = "US", IsFemale=true, Name="Alice Walton" },
            new Person(){ Age = 60, Asset = 34.0, Country = "US", IsFemale=false, Name="Jim Walton"},
            new Person(){ Age = 72, Asset = 34.1, Country = "US", IsFemale=false, Name="Rob Walton"},
            new Person(){ Age = 94, Asset = 39.5, Country = "France", IsFemale=true, Name="Liliane Bettencourt"},
            new Person(){ Age = 43, Asset = 39.8, Country = "US", IsFemale=false, Name="Sergey Brin"},
            new Person(){ Age = 43, Asset = 39.6, Country = "US", IsFemale=false, Name="Larry Page"},
            new Person(){ Age = 68, Asset = 41.5, Country = "France", IsFemale=false, Name="Bernard Arnault"},
            new Person(){ Age = 75, Asset = 47.5, Country = "US", IsFemale=false, Name="Michael Bloomberg"},
            new Person(){ Age = 77, Asset = 48.3, Country = "US", IsFemale=false, Name="David Koch"},
            new Person(){ Age = 81, Asset = 48.3, Country = "US", IsFemale=false, Name="Charles Koch"},
            new Person(){ Age = 72, Asset = 52.2, Country = "US", IsFemale=false, Name="Larry Ellison"},
            new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", IsFemale=false, Name="Carlos Slim Helu"},
            new Person(){ Age = 33, Asset = 56.0, Country = "US", IsFemale=false, Name="Mark Zuckerberg"},
            new Person(){ Age = 81, Asset = 71.3, Country = "Spain", IsFemale=false, Name="Amancio Ortega"},
            new Person(){ Age = 53, Asset = 72.8, Country = "US", IsFemale=false, Name="Jeff Bezos" },
            new Person(){ Age = 85, Asset = 75.6, Country = "US", IsFemale=false, Name="Warren Buffet" },
        new Person(){ Age = 60, Asset = 86.0, Country = "US", IsFemale=false, Name="Bill Gates"}
};
        static List<Fruit> fruits = new List<Fruit>()
        {
            new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
            new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
            new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
            new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
            new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25 },
            new Fruit(){ Name="Persimon", Origin="Spain", Price=1.36 },
            new Fruit(){ Name="Blueberry", Origin="Canada", Price=0.19 },
            new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
            new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Select all the persons with assets of over 50B dollars.\n");
            var q1 = from p in persons
                     where p.Asset > 50
                     select p;
            foreach (var p in q1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Select all non-US citizens\n");
            var q2 = from p in persons
                     where p.Country != "US"
                     select p;
            foreach (var p in q2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Select the name of all the females from India");
            var q3 = from p in persons
                     where p.Country == "India"
                     select p;
            var q31 = from p in q3
                      where p.IsFemale = true
                      select p.Name;
            foreach (var p in q31)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Select all persons whose first name is less than five letters long");
            var q4 = from p in persons
                     where p.Name.Split()[0].Length < 5
                     select p;
            foreach (var p in q4)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sort the collection by assets");
            var q5 = from p in persons
                     orderby p.Asset
                     select new{p.Name, p.Asset};
            foreach (var p in q5)
            {
                Console.WriteLine("Name " + p.Name + "  Asset: " + p.Asset);
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Group the collection by country");
            var q6 = from p in persons
                     group p by p.Country;
            foreach (var aGroup in q6)
            {
                Console.WriteLine("{0} ({1})",
                aGroup.Key, aGroup.Count());
                foreach (var item in aGroup)
                    Console.WriteLine(" " + item);
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sort the above group");
            var q7 = from p in persons
                     group p by p.Country
                     into g
                     orderby g.Count() descending
                     select g;
            foreach (var aGroup in q7)
            {
                Console.WriteLine("{0} ({1})",

                aGroup.Key, aGroup.Count());
                foreach (var item in aGroup)
                    Console.WriteLine(" " + item);
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Selecting person whose age is greater than 60 and assets are more than 10 million \n");
            var q8 = from p in persons
                     where p.Age > 60
                     where p.Asset > 10
                     select p;
            foreach(var p in q8)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("");

        }
    }
}
