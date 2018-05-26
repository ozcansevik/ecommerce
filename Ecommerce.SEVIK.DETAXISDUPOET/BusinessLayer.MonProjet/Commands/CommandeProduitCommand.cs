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
    /// COMMAND pour ajouter / modifier et supprimer une CommandeProduit
    /// </summary>
    class CommandeProduitCommand
    {

        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CommandeProduitCommand(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter la CommandeProduit en base à partir du contexte
        /// </summary>
        /// <param name="cmdProduit">CommandeProduit à ajouter</param>
        /// <returns>Identifiant du CommandeProduit ajouté</returns>
        public int Ajouter(CommandeProduit cmdProduit)
        {
            _contexte.CommandeProduits.Add(cmdProduit);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une CommandeProduit déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="changed">CommandeProduit à modifier</param>
        public void Modifier(CommandeProduit changed)
        {
            CommandeProduit cmdProduit = _contexte.CommandeProduits.Where(cmdPrd => cmdPrd.Id == changed.Id).FirstOrDefault();
            if (cmdProduit != null)
            {
                cmdProduit.Id = changed.Id;
                cmdProduit.Quantite = changed.Quantite;
                cmdProduit.CommandeId = changed.CommandeId;
                cmdProduit.Commande = changed.Commande;

            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une CommandeProduit en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="cmdproduitID">Identifiant de la CommandeProduit à supprimer</param>
        public void Supprimer(int cmdproduitID)
        {
            CommandeProduit deletedCmdProduit = _contexte.CommandeProduits.Where(cmdPrd => cmdPrd.Id == cmdproduitID).FirstOrDefault();
            if (deletedCmdProduit != null)
            {
                _contexte.CommandeProduits.Remove(deletedCmdProduit);
            }
            _contexte.SaveChanges();
        }
    }
}
