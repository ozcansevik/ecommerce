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
    /// COMMAND pour ajouter / modifier et supprimer un Statut
    /// </summary>
    class StatutCommand
    {

        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public StatutCommand(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter le Statut en base à partir du contexte
        /// </summary>
        /// <param name="statut">Statut à ajouter</param>
        /// <returns>Identifiant du Statut ajouté</returns>
        public int Ajouter(Statut statut)
        {
            _contexte.Statuts.Add(statut);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier un Statut déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="changed">Statut à modifier</param>
        public void Modifier(Statut changed)
        {
            Statut statut = _contexte.Statuts.Where(stat => stat.Id == changed.Id).FirstOrDefault();
            if (statut != null)
            {
                statut.Id = changed.Id;
                statut.Libelle = changed.Libelle;
                statut.Commandes = changed.Commandes;

            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer un Statut en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="statutID">Identifiant du Statut à supprimer</param>
        public void Supprimer(int statutID)
        {
            Statut deleteStatut = _contexte.Statuts.Where(stat => stat.Id == statutID).FirstOrDefault();
            if (deleteStatut != null)
            {
                _contexte.Statuts.Remove(deleteStatut);
            }
            _contexte.SaveChanges();
        }
    }
}
