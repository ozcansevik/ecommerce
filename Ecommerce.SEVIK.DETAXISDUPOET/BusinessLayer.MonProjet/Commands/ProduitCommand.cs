using Modele.MonProjet;
using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.MonProjet.Commands
{
    /// <summary>
    /// COMMAND pour ajouter / modifier et supprimer un Produit
    /// </summary>
    public class ProduitCommand
    {
        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ProduitCommand(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le Produit en base à partir du contexte
        /// </summary>
        /// <param name="produit">Produit à ajouter</param>
        /// <returns>Identifiant du Produit ajouté</returns>
        public int Ajouter(Produit produit)
        {
            _contexte.Produits.Add(produit);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un Produit déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="changed">Produit à modifier</param>
        public void Modifier(Produit changed)
        {
            Produit upPrd = _contexte.Produits.Where(prd => prd.Id == changed.Id).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.Id = changed.Id;
                upPrd.Libelle = changed.Libelle;
                upPrd.Description = changed.Description;
                upPrd.Code = changed.Code;
                upPrd.Actif = changed.Actif;
                upPrd.Prix = changed.Prix;
                upPrd.Stock = changed.Stock;
                upPrd.CategorieId = changed.CategorieId;
                upPrd.Categorie = changed.Categorie;
                
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un Produit en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="produitID">Identifiant du Produit à supprimer</param>
        public void Supprimer(int produitID)
        {
            Produit delPrd = _contexte.Produits.Where(prd => prd.Id == produitID).FirstOrDefault();
            if (delPrd != null)
            {
                _contexte.Produits.Remove(delPrd);
            }
            _contexte.SaveChanges();
        }
    }
}
