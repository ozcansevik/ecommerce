using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.MonProjet;
using Modele.MonProjet.Entities;
using WebApplication.Models.ViewModel;

namespace WebApplication.Controllers
{
    public class EditController : Controller
    {
        [HttpPost]
        public ActionResult HandleForm(AddProduitViewModel p)
        {
            BusinessLayerManager blm = BusinessLayerManager.Instance;

            p.produit.Categorie = p.categories.Find(c => c.Id == p.produit.CategorieId);

            blm.ModifierProduit(p.produit);
          
            return RedirectToAction("Index", "Home");
        }

    }
}