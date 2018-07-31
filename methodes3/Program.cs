using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodes3
{
    class Program
    {
        static void Main(string[] args)
        {

            var saisie = SaisirEntier("Saisissez un entier:");
            Console.WriteLine(saisie);
            Console.ReadKey();


        }
        static int SaisirEntier(string texteAAfficher)
        {
            Console.WriteLine(texteAAfficher);
            return int.Parse(Console.ReadLine());
        }
    }
}
