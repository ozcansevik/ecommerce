using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.MonProjet;
using Modele.MonProjet.Entities;

namespace WebApplication.Models.ViewModel
{
    public class ProduitViewModel
    {
        public List<Produit> Produits { get; set; }

        public List<Commande> Commandes { get; set; }

        public BusinessLayerManager blm = BusinessLayerManager.Instance;

        public ProduitViewModel()
        {
            this.Produits = blm.GetAllProduit();
            this.Commandes = blm.GetAllCommande();
        }

        public ProduitViewModel(string searchQuery)
        {
            if (searchQuery != null)
            {
                int result = 0;
                Int32.TryParse(searchQuery, out result);

                this.Produits = blm.GetAllProduit()
                                .FindAll(p => p.Id == result
                                          || p.Code == result 
                                          || p.Description.ToLower() == searchQuery.ToLower()
                                          || p.Libelle.ToLower() == searchQuery.ToLower()
                                          || p.Prix == result
                                          || p.Stock == result
                                          || p.Categorie.Libelle == searchQuery);

                this.Commandes = blm.GetAllCommande()
                                 .FindAll(c => c.Id == result
                                            || c.Observation.ToLower() == searchQuery.ToLower());
            }
            else
            {
                this.Produits = new List<Produit>();
                this.Commandes = new List<Commande>();
            }
        }

    }
}
