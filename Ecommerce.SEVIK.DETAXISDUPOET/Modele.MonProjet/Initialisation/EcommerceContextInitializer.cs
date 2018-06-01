using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Initialisation
{
    public class EcommerceContextInitializer : DropCreateDatabaseAlways<EcommerceContext>
    {

        /// <summary>
        /// Initialiser des données à la création du contexte
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(EcommerceContext context)
        {
            IList<Categorie> defaultCategories = new List<Categorie>();
            IList<Produit> defaultProducts = new List<Produit>();

            defaultCategories.Add(new Categorie() { Libelle = "Charcuterie" });
            defaultCategories.Add(new Categorie() { Libelle = "Produits laitiers" });
            defaultCategories.Add(new Categorie() { Libelle = "Liquides" });

            Categorie c = defaultCategories.First();

            defaultProducts.Add(new Produit { Code = 404, Libelle = "Balasssncoire", Description = "La boucave", Stock = 1000, Prix = 2000, Categorie = c});


            foreach (Categorie categ in defaultCategories)
            {
                context.Categories.Add(categ);
                context.SaveChanges();
            }
                

            foreach (Produit prd in defaultProducts)
            {
                context.Produits.Add(prd);
                context.SaveChanges();
            }



            base.Seed(context);
        }
    }
}
