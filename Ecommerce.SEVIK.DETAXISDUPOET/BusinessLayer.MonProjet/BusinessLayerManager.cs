using BusinessLayer.MonProjet.Commands;
using BusinessLayer.MonProjet.Queries;
using Modele.MonProjet;
using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.MonProjet
{
    public class BusinessLayerManager
    {
        private readonly EcommerceContext contexte;
        private static BusinessLayerManager _businessManager = null;

        /// <summary>
        /// Constructeur, initialisation du contexte EF
        /// </summary>
        private BusinessLayerManager()
        {
            contexte = new EcommerceContext();
        }

        /// <summary>
        /// Récupérer l'instance du pattern Singleton
        /// </summary>
        public static BusinessLayerManager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BusinessLayerManager();
                return _businessManager;
            }
        }

        #region Produit

        /// <summary>
        /// Récupérer une liste de produit en base
        /// </summary>
        /// <returns>Liste de Produit</returns>
        public List<Produit> GetAllProduit()
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return pq.GetAll().ToList();
        }

        /// <summary>
        /// Récupérer une produit en base
        /// </summary>
        /// <returns>Produit</returns>
        public Produit GetProduit(int id)
        {
            ProduitQuery pq = new ProduitQuery(contexte);
            return pq.GetByID(id).First();
        }

        /// <summary>
        /// Ajouter un produit en base
        /// </summary>
        /// <param name="p">Produit à ajouter</param>
        /// <returns>identifiant du nouveau produit</returns>
        public int AjouterProduit(Produit p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProduitCommand pc = new ProduitCommand(contexte);
            return pc.Ajouter(p);
        }

        /// <summary>
        /// Modifier un produit en base
        /// </summary>
        /// <param name="p">Produit à modifier</param>
        public void ModifierProduit(Produit p)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Modifier(p);
        }

        /// <summary>
        /// Supprimer une produit en base
        /// </summary>
        /// <param name="produitID">Identifiant du produit à supprimer</param>
        public void SupprimerProduit(int produitID)
        {
            ProduitCommand pc = new ProduitCommand(contexte);
            pc.Supprimer(produitID);
        }

        #endregion

        #region Categorie

        /// <summary>
        /// Récupérer une liste de catégories en base
        /// </summary>
        /// <returns>Liste de Categorie</returns>
        public List<Categorie> GetAllCategorie()
        {
            CategorieQuery pq = new CategorieQuery(contexte);
            return pq.GetAll().ToList();
        }

        #endregion
    }
}
