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

        public BusinessLayerManager blm = BusinessLayerManager.Instance;

        public ProduitViewModel()
        {
            this.Produits = blm.GetAllProduit();
        }

    }
}
