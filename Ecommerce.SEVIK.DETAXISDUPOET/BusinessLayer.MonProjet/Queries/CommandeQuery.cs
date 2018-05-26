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
    /// QUERY pour récupérer des entités de types Commande
    /// </summary>
    class CommandeQuery
    {

        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CommandeQuery(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer toutes les commandes
        /// </summary>
        /// <returns>IQueryable de Commande</returns>
        public IQueryable<Commande> GetAll()
        {
            return _contexte.Commandes;
        }

        /// <summary>
        /// Récupérer une commande par son ID
        /// </summary>
        /// <param name="id">Identifiant de la commande à récupérer</param>
        /// <returns>IQueryable de Commande</returns>
        public IQueryable<Commande> GetByID(int id)
        {
            return _contexte.Commandes.Where(p => p.Id == id);
        }
    }
}
