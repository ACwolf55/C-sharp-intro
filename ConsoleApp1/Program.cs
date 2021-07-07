using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Asta";
            int numMembers;
            numMembers = 11;

            char letter = 'A';
            double price = 55.75;
            bool magicKnight = true;

            

            //Console.WriteLine("Hello World!");
            Console.WriteLine("    ^");
            Console.WriteLine("   / | ");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");

            Console.WriteLine("Black Bulls captain: " + name);
            Console.WriteLine("Black Bulls Squad had "+numMembers+" members");
            Console.WriteLine("Asta magic knight grade: " + letter);
            Console.WriteLine("Cost of Black Bulls robe: " + price);
            Console.WriteLine(magicKnight);
            Console.WriteLine(name[0]);

        }
    }
}
