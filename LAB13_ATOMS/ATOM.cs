using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;;

namespace LAB13_ATOMS
{

    class Atom
    {
        static string Name { get; set; }
        static string Symbol { get; set; }
        static int Proton { get; set; }
        static int Neutron { get; set; }
        static double Weight { get; set; }
        public Atom() { }
        public Atom(string name, int proton, int neutron, double weight, string symbol) 
        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;
        }
        static public Atom Parse(string line)
        {
            string[] atoms = line.Split(' ');
            string name = atoms[0];
            int proton = Convert.ToInt32(atoms[1]);
            int neutron= Convert.ToInt32(atoms[2]);
            double weight = Convert.ToDouble(atoms[3]);
            string symbol = atoms[4];
            return new Atom(name,proton,neutron,weight,symbol);
        }
        public override string ToString()
        {
            return $"{Name}, {Symbol},{Proton},{Neutron},{Weight}";
        }
    }
    
}
