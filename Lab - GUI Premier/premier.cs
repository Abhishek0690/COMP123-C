using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab___GUI_Premier
{
    class Premier
    {
        public string Name { get; }
        public string Life { get; }
        public string Constituent { get; }
        public string Start { get; }
        public string End { get; }
        public string Party { get; }
        public Premier(string name, string life, string constituent, string start, string end, string party)
        {
            Name = name;
            Life = life;
            Constituent = constituent;
            Start = start;
            End = end;
            Party = party;
        }
        public string GenerateKey()
        {
            return Name.Split().Last();//uses linq to get the last name
        }
        public static List<Premier> GetPremiers()
        => new List<Premier>
        {
                new Premier("John Sandfield Macdonald", "(1812-1872)", "MLA for Cornwall", "16 July 1867", "20 December 1871", "Liberal-Conservative Party"),
                new Premier("Edward Blake", "(1833-1912)", "MLA for Bruce South", "20 December 1871", "25 October 1872", "Liberal Party"),
                new Premier("Sir Oliver Mowat", "(1820-1903)", "MLA for Oxford North", "25 October 1872", "21 July 1896", "Liberal Party"),
                new Premier("Arthur Sturgis Hardy", "(1837-1901)", "MLA for Brant South", "21 July 1896", "21 October 1899", "Liberal Party"),
                new Premier("Sir George William Ross", "(1841-1914)", "MLA for Middlesex West", "21 October 1899", "8 February 1905", "Liberal Party"),
                new Premier("Sir James Whitney", "(1843-1914)", "MLA for Dundas", "8 February 1905", "25 September 1914", "Conservative Party"),
                new Premier("Sir William Hearst", "(1864-1941)", "MLA for Sault Ste. Marie", "2 October 1914", "14 November 1919", "Conservative Party"),
                new Premier("Ernest Drury", "(1878-1968)", "MLA for Halton", "14 November 1919", "16 July 1923", "United Farmers"),
                new Premier("George Howard Ferguson", "(1870-1946)", "MLA for Grenville", "16 July 1923", "15 December 1930", "Conservative Party Named leader in 1920"),
                new Premier("George Stewart Henry", "(1871-1958)", "MLA for York East", "15 December 1930", "10 July 1934", "Conservative Party"),
                new Premier("Mitchell Hepburn", "(1896-1953)", "MLA for Elgin (until 1938) MPP for Elgin (from 1938)", "10 July 1934", "21 October 1942", "Liberal Party Named leader in 1930"),
                new Premier("Gordon Daniel Conant", "(1885-1953)", "MPP for Ontario", "21 October 1942", "18 May 1943", "Liberal Party"),
                new Premier("Harry Nixon", "(1891-1961)", "MPP for Brant", "18 May 1943", "17 August 1943", "Liberal Party Named leader in 1943"),
                new Premier("George A. Drew", "(1894-1973)", "MPP for High Park (until 1948)", "17 August 1943", "19 October 1948", "Progressive Conservative Party Named leader in 1938"),
                new Premier("Thomas Laird Kennedy", "(1878-1959)", "MPP for Peel", "19 October 1948", "4 May 1949", "Progressive Conservative Party"),
                new Premier("Leslie Frost", "(1895-1973)", "MPP for Victoria", "4 May 1949", "8 November 1961", "Progressive Conservative Party Named leader in 1949"),
                new Premier("John Robarts", "(1917-1982)", "MPP for London North", "8 November 1961", "1 March 1971", "Progressive Conservative Party Named leader in 1961"),
                new Premier("Bill Davis", "(b. 1929)", "MPP for Peel North (until 1975) MPP for Brampton (from 1975)", "1 March 1971", "8 February 1985", "Progressive Conservative Party Named leader in 1971"),
                new Premier("Frank Miller", "(1927-2000)", "MPP for Muskoka", "8 February 1985", "26 June 1985", "Progressive Conservative Party named leader in 1985"),
                new Premier("David Peterson", "(b. 1943)", "MPP for London Centre", "26 June 1985", "1 October 1990", "Liberal Party Named leader in 1982"),
                new Premier("Bob Rae", "(b. 1948)", "MPP for York South", "1 October 1990", "26 June 1995", "New Democratic Party Named leader in 1982"),
                new Premier("Mike Harris", "(b. 1945)", "MPP for Nipissing", "26 June 1995", "14 April 2002", "Progressive Conservative Party Named leader in 1990"),
                new Premier("Ernie Eves", "(b. 1946)", "MPP for Dufferin—Peel—Wellington—Grey", "15 April 2002", "22 October 2003", "Progressive Conservative Party Named leader in 2002"),
                new Premier("Dalton McGuinty", "(b. 1955)", "MPP for Ottawa South", "23 October 2003", "11 February 2013", "Liberal Party Named leader in 1996"),
                new Premier("Kathleen Wynne", "(b. 1953)", "MPP for Don Valley West", "11 February 2013", "29 June 2018", "Liberal Party Named leader in 2013"),
                new Premier("Doug Ford", "(b. 1964)", "MPP for Etobicoke North", "29 June 2018", "Present", "Progressive Conservative Party Named leader in 2018")
        };
    }
}
