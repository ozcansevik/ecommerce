﻿using Modele.MonProjet;
using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.MonProjet.Queries
{

    /// <summary>
    /// QUERY pour récupérer des entités de types Produit
    /// </summary>
    public class ProduitQuery
    {
        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ProduitQuery(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les produits
        /// </summary>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Produit> GetAll()
        {
            return _contexte.Produits;
        }

        /// <summary>
        /// Récupérer un produit par son ID
        /// </summary>
        /// <param name="id">Identifiant du produit à récupérer</param>
        /// <returns>IQueryable de Produit</returns>
        public IQueryable<Produit> GetByID(int id)
        {
            return _contexte.Produits.Where(p => p.Id == id);
        }
    }
}
