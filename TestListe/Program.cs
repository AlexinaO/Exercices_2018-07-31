using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListe
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListString = new List<string>();
            Console.WriteLine("Veuillez entrer le 1er élément de votre liste");
            ListString.Add(Console.ReadLine());
            Console.WriteLine("Veuillez entrer le 2ème élément de votre liste");
            ListString.Add(Console.ReadLine());
            Console.WriteLine("Veuillez entrer le 3ème élément de votre liste");
            ListString.Add(Console.ReadLine());
            Console.WriteLine("Veuillez entrer le 4ème élément de votre liste");
            ListString.Add(Console.ReadLine());
            Console.WriteLine("Veuillez entrer le 5ème élément de votre liste");
            ListString.Add(Console.ReadLine());
            Console.WriteLine("Le 2ème élément de la liste est: " + ListString[1]);
           

            Console.ReadKey();
        }
    }
}
