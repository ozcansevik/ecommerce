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
            AddProduitViewModel addproduitViewModel = new AddProduitViewModel();
            return View(addproduitViewModel);
        }

        public ActionResult Edit(int id)
        {
            BusinessLayerManager blm = BusinessLayerManager.Instance;
            Produit pToEdit = blm.GetProduit(id);

            AddProduitViewModel addproduitViewModel = new AddProduitViewModel(pToEdit);
            return View(addproduitViewModel);
        }

        public ActionResult Delete()
        {
            AddProduitViewModel addproduitViewModel = new AddProduitViewModel();
            return View(addproduitViewModel);
        }


        public ActionResult Search(String search)
        {
            ProduitViewModel produitViewModel = new ProduitViewModel(search);
            return View(produitViewModel);
        }
    }
}