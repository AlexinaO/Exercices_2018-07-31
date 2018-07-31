using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonjour2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel est ton Prénom ?");
            var prenom = Console.ReadLine();
            Console.WriteLine("Quel est ton Nom ?");
            var nom = Console.ReadLine();
            Console.WriteLine("Quel est ton âge ?");
            var age = Console.ReadLine();
            Console.WriteLine($"\nBonjour {prenom} {nom}. Tu as {age} ans."); // le $ permet de mettre des variables dans le texte
            
            Console.ReadKey();
        }
    }
}
