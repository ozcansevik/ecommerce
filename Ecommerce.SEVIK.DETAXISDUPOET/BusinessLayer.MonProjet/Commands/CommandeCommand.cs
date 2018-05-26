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
    /// COMMAND pour ajouter / modifier et supprimer une Commande
    /// </summary>
    class CommandeCommand
    {

        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CommandeCommand(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter la Commande en base à partir du contexte
        /// </summary>
        /// <param name="cmd">Commande à ajouter</param>
        /// <returns>Identifiant de la Commande ajouté</returns>
        public int Ajouter(Commande cmd)
        {
            _contexte.Commandes.Add(cmd);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une Commande déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="changed">Commande à modifier</param>
        public void Modifier(Commande changed)
        {
            Commande commande = _contexte.Commandes.Where(cmd => cmd.Id == changed.Id).FirstOrDefault();
            if (commande != null)
            {
                commande.Id = changed.Id;
                commande.Observation = changed.Observation;
                commande.DateCommand = changed.DateCommand;
                commande.ClientId = changed.ClientId;
                commande.Client = changed.Client;
                commande.StatusId = changed.StatusId;
                commande.Statut = changed.Statut;

            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une Commande en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="cmdID">Identifiant de la Commande à supprimer</param>
        public void Supprimer(int cmdID)
        {
            Commande deleteCmd = _contexte.Commandes.Where(cmd => cmd.Id == cmdID).FirstOrDefault();
            if (deleteCmd != null)
            {
                _contexte.Commandes.Remove(deleteCmd);
            }
            _contexte.SaveChanges();
        }
    }
}
