using System.Collections.Generic;


namespace Question3
{
    class RichPerson
    {
        public string Name { get; }
        public double Worth { get; }
        public int Age { get; }
        public string Country { get; }
        public string Source { get; }
        public string Industry { get; }
        public RichPerson(string name, double worth, int age,
            string country, string source, string industry)
        {
            Name = name; Worth = worth; Age = age;
            Country = country; Source = source; Industry = industry;
        }
        public static List<RichPerson> GetList()
            => new List<RichPerson> 
            {
                new RichPerson("Jeff Bezos", 177,57, "United States", "Amazon","Technology"),
                new RichPerson("Elon Musk", 151,49, "United States", "Tesla, SpaceX","Automotive"),
                new RichPerson("Bernard Arnault", 150,72, "France", "LVMH","Fashion & Retail"),
                new RichPerson("Bill Gates", 124,65, "United States", "Microsoft","Technology"),
                new RichPerson("Mark Zuckerberg", 97,36, "United States", "Facebook","Technology"),
                new RichPerson("Warren Buffett", 96,90, "United States", "Berkshire Hathaway","Finance & Investments"),
                new RichPerson("Larry Ellison", 93,76, "United States", "software","Technology"),
                new RichPerson("Larry Page", 91.5,48, "United States", "Google","Technology"),
                new RichPerson("Sergey Brin", 89,47, "United States", "Google","Technology"),
                new RichPerson("Mukesh Ambani", 84.5,63, "India", "diversified","Diversified"),
                new RichPerson("Amancio Ortega", 77,85, "Spain", "Zara","Fashion & Retail"),
                new RichPerson("Francoise Bettencourt Meyers", 73.6,67, "France", "L'Oréal","Fashion & Retail"),
                new RichPerson("Zhong Shanshan", 68.9,66, "China", "beverages, pharmaceuticals","Food & Beverage"),
                new RichPerson("Steve Ballmer", 68.7,65, "United States", "Microsoft","Technology"),
                new RichPerson("Ma Huateng", 65.8,49, "China", "internet media","Technology"),
                new RichPerson("Carlos Slim Helu", 62.8,81, "Mexico", "telecom","Telecom"),
                new RichPerson("Alice Walton", 61.8,71, "United States", "Walmart","Fashion & Retail"),
                new RichPerson("Jim Walton", 60.2,72, "United States", "Walmart","Fashion & Retail"),
                new RichPerson("Rob Walton", 59.5,76, "United States", "Walmart","Fashion & Retail"),
                new RichPerson("Michael Bloomberg", 59,79, "United States", "Bloomberg LP","Media & Entertainment"),
                new RichPerson("Colin Zheng Huang", 55.3,41, "China", "e-commerce","Technology"),
                new RichPerson("MacKenzie Scott", 53,50, "United States", "Amazon","Technology"),
                new RichPerson("Daniel Gilbert", 51.9,59, "United States", "Quicken Loans","Finance & Investments"),
                new RichPerson("Gautam Adani", 50.5,58, "India", "infrastructure, commodities","Diversified"),
                new RichPerson("Phil Knight", 49.9,83, "United States", "Nike","Fashion & Retail"),
                new RichPerson("Jack Ma", 48.4,56, "China", "e-commerce","Technology"),
                new RichPerson("Charles Koch", 46.4,85, "United States", "Koch Industries","Diversified"),
                new RichPerson("Julia Koch", 46.4,58, "United States", "Koch Industries","Diversified"),
                new RichPerson("Masayoshi Son", 45.4,63, "Japan", "internet, telecom","Telecom"),
                new RichPerson("Michael Dell", 45.1, 56, "United States","Dell Computers", "Technology")
            };
    }
}
