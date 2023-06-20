using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            RunTest();
        }
        class pet
        {
            public string Name { get; }
            public string Owner { get; set; }
            public string Description { get; }
            public int Age { get; }
            public bool IsHouseTrained { get; private set; }
            public pet(string name, int age)
            {
                Name = name;
                Age = age;
                Owner = "No One";
                IsHouseTrained = false;
            }

            public void train()
            {
                IsHouseTrained = true;
            }
            public void SetOwner(string name)
            {
                Owner = name;
            }
            public override string ToString()
            {
                return $"hey my name is {Name}, I am a {Description}. I am {Age} years old and my owner is {Owner}. I am {(IsHouseTrained ? " " : "not")} housetrained.";
            }
        }
            public static void RunTest()
            {
            string Owner = "";
                List<pet> pets = new List<pet>
                {
                    new pet("Bee", 3),
                    new pet("bruno", 7),
                    new pet ("Oreo", 8),
                    new pet ("Kiwi", 3)
                };
                string owner = "Luke";
                pets[0].SetOwner(owner);
                pets[2].train();
                pets[1].train();
                string owner2 = "Bud";
                pets[1].SetOwner(owner2);
                foreach (pet p in pets)
                {
                    Console.WriteLine(p);
                }

                // Prompting the user for a name of particular person 
                Console.Write("Enter the name of owner: ");

                string name = Convert.ToString(Console.ReadLine());
                foreach (pet p in pets)
                {
                    if(p.Owner == name)
                    {
                        Console.WriteLine(p);
                    }
                    else
                    {
                        break;
                    }
                  }
            }
        }
    }

