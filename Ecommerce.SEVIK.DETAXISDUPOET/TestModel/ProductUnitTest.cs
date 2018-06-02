using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.MonProjet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.MonProjet.Entities;

namespace TestModel
{
    [TestClass]
    public class ProductUnitTest
    {
        private Produit prd;
        private int id;
        private BusinessLayerManager blm;
        private Categorie c;

        [TestInitialize]
        public void Initialize()
        {
            blm = BusinessLayerManager.Instance;
            c = blm.GetAllCategorie().First();
            prd = new Produit() { Code = 404, Libelle = "Balancoire", Description = "La boucave", Stock = 1000, Prix = 2000, CategorieId = c.Id, Categorie = c };
            id = blm.AjouterProduit(prd);

        }

        [TestMethod]
        public void TestProductCreation()
        {
            Produit p = blm.GetProduit(id);
            Assert.AreEqual(prd.Prix, p.Prix);
        }
    }
}
