using Modele.MonProjet;
using Modele.MonProjet.Entities;
using System.Linq;

namespace BusinessLayer.MonProjet.Commands
{
    /// <summary>
    /// COMMAND pour ajouter / modifier et supprimer une Catégorie
    /// </summary>
    public class CategorieCommand
    {

        private readonly EcommerceContext _contexte;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="contexte">Contexte EF à utiliser</param>
        public CategorieCommand(EcommerceContext contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Ajouter la Catégorie en base à partir du contexte
        /// </summary>
        /// <param name="cat">Catégorie à ajouter</param>
        /// <returns>Identifiant de la Catégorie ajoutée</returns>
        public int Ajouter(Categorie cat)
        {
            _contexte.Categories.Add(cat);
            return _contexte.SaveChanges();
        }

        /// <summary>
        /// Modifier une Catégorie déjà présent en base à partir du contexte
        /// </summary>
        /// <param name="changed">Catégorie à modifier</param>
        public void Modifier(Categorie changed)
        {
            Categorie updateCategorie = _contexte.Categories.Where(cat => cat.Id == changed.Id).FirstOrDefault();
            if (updateCategorie != null)
            {
                updateCategorie.Libelle = changed.Libelle;
                updateCategorie.Id = changed.Id;
                updateCategorie.Actif = changed.Actif;
            }
            _contexte.SaveChanges();
        }

        /// <summary>
        /// Supprimer une Catégorie en base à partir du contexte et de son identifiant
        /// </summary>
        /// <param name="categorieID">Identifiant de la Catégorie à supprimer</param>
        public void Supprimer(int categorieID)
        {
            Categorie deleteCategorie = _contexte.Categories.Where(cat => cat.Id == categorieID).FirstOrDefault();
            if (deleteCategorie != null)
            {
                _contexte.Categories.Remove(deleteCategorie);
            }
            _contexte.SaveChanges();
        }
    }
}
