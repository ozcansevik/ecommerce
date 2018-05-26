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
    /// COMMAND pour ajouter / modifier et supprimer un Client
    /// </summary>
    public class ClientCommand
    {

        private readonly EcommerceContext _contexte;
        
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public ClientCommand(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le Client en base à partir du contexte
        /// </summary>
        /// <param name="cli">Client à ajouter</param>
        /// <returns>Identifiant du Client ajouté</returns>
        public int Ajouter(Client cli)
        {
            _contexte.Clients.Add(cli);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un Client déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="changed">Client à modifier</param>
        public void Modifier(Client changed)
        {
            Client client = _contexte.Clients.Where(cli => cli.Id == changed.Id).FirstOrDefault();
            if (client != null)
            {
                client.Id = changed.Id;
                client.Nom = changed.Nom;
                client.Prenom = changed.Prenom;
               
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un Client en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="clientID">Identifiant du Client à supprimer</param>
        public void Supprimer(int clientID)
        {
            Client deleteClient = _contexte.Clients.Where(cli => cli.Id == clientID).FirstOrDefault();
            if (deleteClient != null)
            {
                _contexte.Clients.Remove(deleteClient);
            }
            _contexte.SaveChanges();
        }
    }
}
