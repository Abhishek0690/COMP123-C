using fraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
        public class Fraction
        {
            public int Top { get; }
            public int Bottom { get; }

            public Fraction(int top = 0, int bottom = 1)
            {
                Top = top;
                Bottom = bottom;
            }

            public override string ToString()
            {
                return $"{Top} / {Bottom}";
            }

            public static Fraction operator +(Fraction lhs, Fraction rhs)
            {
                int top = lhs.Top * rhs.Bottom + lhs.Bottom * rhs.Top;
                int bottom = lhs.Bottom * rhs.Bottom;
                return new Fraction(top, bottom);
            }

            public static Fraction operator -(Fraction lhs, Fraction rhs)
            {
                int top = lhs.Top * rhs.Bottom - lhs.Bottom * rhs.Top;
                int bottom = lhs.Bottom * rhs.Bottom;
            if(rhs.Top > lhs.Top)
            {
                throw new Exception("Please write a number lower than the left hand side");
            }
            return new Fraction(top, bottom);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Fraction f = new Fraction(1, 4);
            Fraction g = new Fraction(3, 4);
            Console.WriteLine(f - g);
            Console.WriteLine(g - f);
            Console.WriteLine(f + g);
        }
    }

