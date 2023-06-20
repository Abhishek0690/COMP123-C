using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK5_LAB18_tHEATRE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie terminator = new Movie("Terminator 2: Judgement Day", 1991, 105);
            terminator.AddActor("Arnold Schwarzenegger");
            terminator.SetGenre(GenreEnum.Horror | GenreEnum.Action);
            terminator.AddActor("Linda Hamilton");
            Show s1 = new Show(terminator, new Time(11, 35), DayEnum.Mon, 5.95);

            Console.WriteLine(s1);              //displays one object
            Theatre eglinton = new Theatre("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows();              //displays one object

            Movie godzilla = new Movie("Godzilla 2014", 2014, 123);
            godzilla.AddActor("Aaron Johnson");
            godzilla.AddActor("Ken Watanabe");
            godzilla.AddActor("Elizabeth Olsen");
            godzilla.SetGenre(GenreEnum.Action | GenreEnum.Documentary | GenreEnum.Comedy);

            Movie trancendence = new Movie("Transendence", 2014, 120);
            trancendence.AddActor("Johnny Depp");
            trancendence.AddActor("Morgan Freeman");
            trancendence.SetGenre(GenreEnum.Comedy);
            eglinton.AddShow(new Show(trancendence, new Time(18, 5), DayEnum.Sun, 7.87));

            Movie m1 = new Movie("The Shawshank Redemption", 1994, 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(GenreEnum.Action);
            eglinton.AddShow(new Show(m1, new Time(14, 5), DayEnum.Sun, 8.87));

            Movie avengers = new Movie("Avengers: Endgame", 2019, 120);
            avengers.AddActor("Robert Downey Jr.");
            avengers.AddActor("Chris Evans");
            avengers.AddActor("Chris Hemsworth");
            avengers.AddActor("Scarlett Johansson");
            avengers.AddActor("Mark Ruffalo");
            avengers.SetGenre(GenreEnum.Action | GenreEnum.Fantasy | GenreEnum.Adventure);
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));

            m1 = new Movie("Olympus Has Fallen", 2013, 120);
            m1.AddActor("Gerard Butler");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(GenreEnum.Action);
            eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Sun, 8.87));

            m1 = new Movie("The Mask of Zorro", 1998, 136);
            m1.AddActor("Antonio Banderas");
            m1.AddActor("Anthony Hopkins");
            m1.AddActor("Catherine Zeta-Jones");
            m1.SetGenre(GenreEnum.Action | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Sun, 8.87));

            m1 = new Movie("Four Weddings and a Funeral", 1994, 117);
            m1.AddActor("Hugh Grant");
            m1.AddActor("Andie MacDowell");
            m1.AddActor("Kristin Scott Thomas");
            m1.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(15, 5), DayEnum.Sat, 8.87));
            eglinton.AddShow(new Show(m1, new Time(16, 5), DayEnum.Tue, 6.50));

            m1 = new Movie("You've Got Mail", 1998, 119);
            m1.AddActor("Tom Hanks");
            m1.AddActor("Meg Ryan");
            m1.SetGenre(GenreEnum.Comedy | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(15, 5), DayEnum.Sat, 8.87));

            m1 = new Movie("The Poison Rose", 2019, 98);
            m1.AddActor("John Travolta");
            m1.AddActor("Morgan Freeman");
            m1.AddActor("Brendan Fraser");
            m1.SetGenre(GenreEnum.Action | GenreEnum.Romance);
            eglinton.AddShow(new Show(m1, new Time(22, 5), DayEnum.Sun, 10.25));

            Movie car3 = new Movie("Cars 3", 2017, 109);
            car3.AddActor("Owen Williams");
            car3.AddActor("Cristela Alonzo");
            car3.AddActor("Arnie Hammer");
            car3.AddActor("Chris Cooper");
            car3.SetGenre(GenreEnum.Comedy | GenreEnum.Animation | GenreEnum.Romance);
            eglinton.AddShow(new Show(car3, new Time(09, 55), DayEnum.Sat, 6.40));
            eglinton.AddShow(new Show(car3, new Time(11, 05), DayEnum.Sat, 6.50));

            Movie toys4 = new Movie("Toys Story 4", 2019, 89);
            toys4.AddActor("Keanu Reeves");
            toys4.AddActor("Christina Hendricks");
            toys4.AddActor("Tom Hanks");
            toys4.AddActor("Tim Allen");
            toys4.SetGenre(GenreEnum.Comedy | GenreEnum.Fantasy | GenreEnum.Animation);
            eglinton.AddShow(new Show(toys4, new Time(14, 10), DayEnum.Sat, 6.40));

            eglinton.AddShow(new Show(godzilla, new Time(13, 55), DayEnum.Mon, 6.89));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));
            eglinton.AddShow(new Show(godzilla, new Time(14), DayEnum.Sun, 6.89));
            eglinton.AddShow(new Show(toys4, new Time(14, 10), DayEnum.Sat, 6.40));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));
            eglinton.AddShow(new Show(godzilla, new Time(16, 55), DayEnum.Sun, 6.89));
            eglinton.AddShow(new Show(avengers, new Time(21, 5), DayEnum.Sat, 12.25));
            eglinton.AddShow(new Show(m1, new Time(20, 35), DayEnum.Sat, 10.25));
            eglinton.AddShow(new Show(godzilla, new Time(22, 5), DayEnum.Wed, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(20, 30), DayEnum.Tue, 10.75));
            eglinton.AddShow(new Show(godzilla, new Time(20, 15), DayEnum.Thu, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(20, 30), DayEnum.Wed, 10.75));
            eglinton.AddShow(new Show(godzilla, new Time(18, 25), DayEnum.Fri, 8.50));
            eglinton.AddShow(new Show(avengers, new Time(14, 15), DayEnum.Sun, 10.75));

            eglinton.PrintShows();                                      //displays 27 objects
            eglinton.PrintShows(DayEnum.Sun);                           //displays 8 objects
            eglinton.PrintShows(GenreEnum.Action);                      //displays 19 objects
            eglinton.PrintShows(GenreEnum.Romance);                     //displays 8 objects
            eglinton.PrintShows(GenreEnum.Action | GenreEnum.Romance);  //displays 3 objects
            eglinton.PrintShows("Morgan Freeman");                      //displays 5 objects

            Time time = new Time(14, 05);
            eglinton.PrintShows(time);                                  //displays 6 objects

            eglinton.PrintShows(DayEnum.Sun, time);                     //displays 3 objects


        }
    }
}
