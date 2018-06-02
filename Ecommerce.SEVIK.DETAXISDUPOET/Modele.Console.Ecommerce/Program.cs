
using BusinessLayer.MonProjet;
using Modele.MonProjet.Entities;
using System.Collections.Generic;

namespace Modele.Console.Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayerManager blm = BusinessLayerManager.Instance;

            List<Categorie> categories = blm.GetAllCategorie();
            System.Console.WriteLine("LISTE DES CATEGORIES");
            System.Console.WriteLine("{0}", categories.Count);
            foreach (Categorie c in categories)
            {
                System.Console.WriteLine("Catégorie ID {0} : {1}", c.Id, c.Libelle);
            }
            System.Console.WriteLine("Press enter to close...");
            System.Console.ReadLine();

        }
    }
}
