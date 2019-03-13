using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_1003_Knight
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundTable<Knight> knights = new RoundTable<Knight>();
            RoundTable<Magician> magicians = new RoundTable<Magician>();

            Knight k1 = new Knight("yeuda", "maccabi", "sword");
            Knight k2 = new Knight("shimshon", "plishtim", "natural");
            Knight k3 = new Knight("tuval", "knaan", "arrow");
            Knight k4 = new Knight("auvalaa", "aaknaan", "aaarrow");
            Knight k5 = new Knight("jarta", "harta", "harta");
            
            
            knights.Add(k1);
            knights.Add(k2);
            knights.Add(k3);
            knights.Add(k4);
            
            foreach (Knight knight in knights)
            {
                Console.WriteLine(knight);
            }
            Console.WriteLine("\n\n");
            
            knights.RemoveAt(4);
            foreach (Knight knight in knights)
            {
                Console.WriteLine(knight);
            }
            Console.WriteLine("\n\n");
            
            knights.InsertAt(3,k5);
            foreach (Knight knight in knights)
            {
                Console.WriteLine(knight);
            }
            Console.WriteLine("\n\n");
            
            knights.Sort();
            foreach (Knight knight in knights)
            {
                Console.WriteLine(knight);
            }
            Console.WriteLine("\n\n");
            
            knights.GetRounded(10);
            Console.WriteLine("\n\n");
            
            //Console.WriteLine(knights["k3"]);
            Console.WriteLine(k1["Name"]);
            Console.WriteLine(k1["Title"]);
            Console.WriteLine(k2["BirthTown"]);
            
            Console.WriteLine(k1["gaba"]);

            Console.WriteLine("\n\n\n");



            Magician m1 = new Magician("yeuda", "maccabi", "sword");
            Magician m2 = new Magician("shimshon", "plishtim", "natural");
            Magician m3 = new Magician("tuval", "knaan", "arrow");
            Magician m4 = new Magician("auvalaa", "aaknaan", "aaarrow");
            Magician m5 = new Magician("jarta", "harta", "harta");
            
            
            magicians.Add(m1);
            magicians.Add(m2);
            magicians.Add(m3);
            magicians.Add(m4);
            
            foreach (Magician magician in magicians)
            {
                Console.WriteLine(magician);
            }
            Console.WriteLine("\n\n");

            magicians.RemoveAt(4);
            foreach (Magician magician in magicians)
            {
                Console.WriteLine(magician);
            }
            Console.WriteLine("\n\n");
            
            magicians.InsertAt(3,m5);
            foreach (Magician magician in magicians)
            {
                Console.WriteLine(magician);
            }
            Console.WriteLine("\n\n");

            magicians.Sort();
            foreach (Magician magician in magicians)
            {
                Console.WriteLine(magician);
            }
            Console.WriteLine("\n\n");

            magicians.GetRounded(10);
            Console.WriteLine("\n\n");
            
            //Console.WriteLine(knights["k3"]);
            Console.WriteLine(m1["Name"]);
            Console.WriteLine(m1["Title"]);
            Console.WriteLine(m2["BirthTown"]);
            Console.WriteLine(m1["gaba"]);

            Console.WriteLine("\n\n\n");

            Console.WriteLine(knights);
            Console.WriteLine("\n\n\n");
            Console.WriteLine(magicians);
        }
    }
}
