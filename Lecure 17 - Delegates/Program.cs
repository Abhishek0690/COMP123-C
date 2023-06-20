using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lecure_17___Delegates
{

    class Program
    {

    //STEP I - Code the intended method(s) (can be in the same class
    private static void Picasso()
    {
        Console.WriteLine("Done by picasso");
    }
    private static void Vangogh()
    {
        Console.WriteLine("Done by van gogh");
    }

    public static void Main(string[] args)
        {
            //STEP III - Instantiation of the delegate
            //#1 – static method
            Signor picasso = new Signor(Picasso); //Picasso is a static method
                                                  //#2 – static method
            Signor vangogh = Vangogh;
            //#3 – instance method
            Signor narendra =
            new Signor(new AnotherClass().Narendra); //Narendra is an instance method
                                                     //#4 – anonymous method
            Signor ilia = delegate
            {
                Console.WriteLine("Done by without a name");
            };
            //#5 – lambda expression
            Signor hao = () => Console.WriteLine("Genius of lamdba");
            //#6 – you may also chain all of them together
            Signor all = picasso + hao + ilia + narendra + hao;
        }
    }

