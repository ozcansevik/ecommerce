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
    /// QUERY pour récupérer des entités de types Client
    /// </summary>
    class ClientQuery
    {

        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ClientQuery(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Récupérer tous les clients
        /// </summary>
        /// <returns>IQueryable de Client</returns>
        public IQueryable<Client> GetAll()
        {
            return _contexte.Clients;
        }

        /// <summary>
        /// Récupérer un client par son ID
        /// </summary>
        /// <param name="id">Identifiant du client à récupérer</param>
        /// <returns>IQueryable de Client</returns>
        public IQueryable<Client> GetByID(int id)
        {
            return _contexte.Clients.Where(p => p.Id == id);
        }
    }
}
