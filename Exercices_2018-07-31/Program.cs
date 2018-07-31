using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int monEntier = 14;
            bool monBooleen = true;
            string maChaineCaracteres = "il fait beau";
            DateTime dateJour = DateTime.Now;
            Console.WriteLine("Présentation sur une seule ligne");
            Console.WriteLine("Le " + dateJour.ToShortDateString() + " " + maChaineCaracteres + "." + " Ceci est " + monBooleen + "." + " Nous sommes " + monEntier + " dans la classe.");
            Console.WriteLine("\n\nPrésentation sur plusieurs lignes en utilisant le retour chariot et donc une seule ligne de commande");
            Console.WriteLine("Le " + dateJour.ToShortDateString() + " " + maChaineCaracteres + "." + "\nCeci est " + monBooleen + "." + "\nNous sommes " + monEntier + " dans la classe.");
            Console.ReadKey();
            Tableau();
            TableauDynamique();
        }


        static void Tableau()
        {
            string[] prenoms = new string[3];
            Console.WriteLine("Nom 1?");
            prenoms[0] = Console.ReadLine();
            Console.WriteLine("Nom 2?");
            prenoms[1] = Console.ReadLine();
            Console.WriteLine("Nom 3?");
            prenoms[2] = Console.ReadLine();
            Console.WriteLine(prenoms[0]);
            Console.WriteLine(prenoms[1]);
            Console.WriteLine(prenoms[2]);
            Console.ReadKey();
        }

        static void TableauDynamique()
        {
            ArrayList prenomsDynamiques = new ArrayList();
            Console.WriteLine("Nom 1?");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine("Nom 2?");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine("Nom 3?");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine(prenomsDynamiques[0]);
            Console.WriteLine(prenomsDynamiques[1]);
            Console.WriteLine(prenomsDynamiques[2]);
            Console.ReadKey();
        }


        static void TableauDynamique2()
        {
            var prenomsDynamiques = new List<string>();
            Console.WriteLine("Nom 1?");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine("Nom 2?");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine("Nom 3?");
            prenomsDynamiques.Add(Console.ReadLine());
            Console.WriteLine(prenomsDynamiques[0]);
            Console.WriteLine(prenomsDynamiques[1]);
            Console.WriteLine(prenomsDynamiques[2]);
            Console.ReadKey();
        }
    }
}
