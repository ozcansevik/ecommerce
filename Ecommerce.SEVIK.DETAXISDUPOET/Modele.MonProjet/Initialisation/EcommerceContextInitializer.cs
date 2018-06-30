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
            IList<Commande> defaultCommandes = new List<Commande>();

            defaultCategories.Add(new Categorie() { Libelle = "Charcuterie" });
            defaultCategories.Add(new Categorie() { Libelle = "Produits laitiers" });
            defaultCategories.Add(new Categorie() { Libelle = "Liquides" });
            defaultCategories.Add(new Categorie() { Libelle = "Vehicules" });

            Categorie c = defaultCategories.First();

            Categorie cVoiture = defaultCategories.Last();

            defaultProducts.Add(new Produit { Code = 404, Libelle = "Balasssncoire", Description = "La boucave", Stock = 1000, Prix = 2000, CategorieId = c.Id,  Categorie = c});
            defaultProducts.Add(new Produit { Code = 405, Libelle = "Voiture", Description = "BMW", Stock = 100, Prix = 20000, CategorieId = cVoiture.Id, Categorie = cVoiture });

            Client client = new Client { Nom = "Sevik", Prenom = "Ozcan", Actif = true };
            Statut s = new Statut { Libelle = "En Cours" };

            defaultCommandes.Add(new Commande { DateCommand = DateTime.Now, Client = client, ClientId = client.Id, Observation = "Première Commande", Statut = s, StatusId = s.Id });

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

            foreach (Commande commande in defaultCommandes) {
                context.Commandes.Add(commande);
                context.SaveChanges();
            }

            base.Seed(context);
        }
    }
}
