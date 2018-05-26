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
    /// QUERY pour récupérer des entités de types CommandeProduit
    /// </summary>
    class CommandeProduitQuery
    {
        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CommandeProduitQuery(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer toutes les CommandeProduit
        /// </summary>
        /// <returns>IQueryable de CommandeProduit</returns>
        public IQueryable<CommandeProduit> GetAll()
        {
            return _contexte.CommandeProduits;
        }

        /// <summary>
        /// Récupérer une CommandeProduit par son ID
        /// </summary>
        /// <param name="id">Identifiant du CommandeProduit à récupérer</param>
        /// <returns>IQueryable de CommandeProduit</returns>
        public IQueryable<CommandeProduit> GetByID(int id)
        {
            return _contexte.CommandeProduits.Where(p => p.Id == id);
        }
    }
}
