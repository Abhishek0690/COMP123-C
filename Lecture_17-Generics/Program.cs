using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_17_Generics
{
    internal class Program
    {
        static void Display<T>(string msg, T value)
        {
            Console.WriteLine($"{msg} {value}");
        }

        static void Swap<T> (ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Addition<T> ( T a,  T b)
        {
            dynamic x = a;
            dynamic y = b;

            dynamic sum = x + y;
            Console.WriteLine($"Sum of {a} and {b} is {sum}");
        }
        static void Main(string[] args)
        {
            Display<int>("abhishek", 10);
            //Swapping
            int x = 4, y = 8;
            Console.WriteLine($"Before x: {x} y: {y}");
            Swap<int>(ref x, ref y);
            Console.WriteLine($"After x: {x} y: {y}");
            //Addition
            Addition<string> ("Abhishek", "Narang");

        }
    }
}
