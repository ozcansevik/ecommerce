using Modele.MonProjet;
using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.MonProjet.Queries
{
    /// <summary>
    /// QUERY pour récupérer des entités de types Categorie
    /// </summary>
    public class CategorieQuery
    {
        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CategorieQuery(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer toutes les catégories
        /// </summary>
        /// <returns>IQueryable de Catégorie</returns>
        public IQueryable<Categorie> GetAll()
        {
            return _contexte.Categories;
        }

        /// <summary>
        /// Récupérer une catégorie par son ID
        /// </summary>
        /// <param name="id">Identifiant de l catégorie à récupérer</param>
        /// <returns>IQueryable de Catégorie</returns>
        public IQueryable<Categorie> GetByID(int id)
        {
            return _contexte.Categories.Where(p => p.Id == id);
        }
    }
}
