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
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ProduitViewModel produitViewModel = new ProduitViewModel();
            return View(produitViewModel);
        }

        public ActionResult Detail(int id)
        {
            BusinessLayerManager blm = BusinessLayerManager.Instance;

            Produit p = blm.GetProduit(id);

            return View(p);
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult AddSumbit()
        {
            /*BusinessLayerManager blm = BusinessLayerManager.Instance;

            Produit p = blm.GetProduit(id);*/

            return View("Index");
        }

    }
}