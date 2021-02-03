using ConsoleEntityFramework.Models;
using System;
using System.Linq;

namespace ConsoleEntityFramework
{
    class Program
    {
        /* Avant d'exécuter ce code, créez la base de données en exécutant le script Scott.Sql.
         * Et modifiez la chaine de connexion à votre serveur SQL dans App.Config.
         */

        static void Main(string[] args)
        {
            using (var context = new ScottContext())
            {
                // Nombre d'employé
                var count = context.Employees.Count();
                Console.WriteLine($"Nombre d'employé : {count}");

                // Mr Smith
                var smith = context.Employees
                                   .First(i => i.Name == "Smith");

                Console.WriteLine($"Employé :");
                Console.WriteLine($"  - Nom : {smith.Name}");
                Console.WriteLine($"  - Travail : {smith.Job}");
                Console.WriteLine($"  - Département : {smith.Department.Name}");

                Console.ReadKey();
            }
        }
    }
}
