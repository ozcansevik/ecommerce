using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer.MonProjet;
using Modele.MonProjet.Entities;

namespace WebApplication.Models.ViewModel
{
    public class AddProduitViewModel
    {
        public Produit produit { get; set; }

        public List<Categorie> categories { get; set; }

        public BusinessLayerManager blm = BusinessLayerManager.Instance;

        public Boolean edition;

        public AddProduitViewModel()
        {
            this.categories = blm.GetAllCategorie();
            this.edition = false;
        }

        public AddProduitViewModel(Produit p)
        {
            this.produit = p;
            this.categories = blm.GetAllCategorie();
            this.edition = true;
        }

    }
}
