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
    public class AddController : Controller
    {
        [HttpPost]
        public ActionResult HandleForm(Produit p)
        {
            BusinessLayerManager blm = BusinessLayerManager.Instance;

            blm.AjouterProduit(p);

            return View("Index");
        }

    }
}