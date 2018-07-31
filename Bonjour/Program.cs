using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonjour
{
    class Program
    {
        static void Main(string[] args)
        {
            var informations = new List<string>();
            Console.WriteLine("Quel est ton Prénom ?");
            informations.Add(Console.ReadLine());
            Console.WriteLine("Quel est ton Nom ?");
            informations.Add(Console.ReadLine());
            Console.WriteLine("Quel est ton âge ?");
            informations.Add(Console.ReadLine());
            Console.WriteLine("Bonjour " + informations[0] + " " + informations[1] + "." + " Tu as " + informations[2]+".");
            //console.writeline("Bonjour {0} {1}. Tu as {2}.", liste[0], liste[1], liste[2]);
            Console.ReadKey();
         }
    }
}
