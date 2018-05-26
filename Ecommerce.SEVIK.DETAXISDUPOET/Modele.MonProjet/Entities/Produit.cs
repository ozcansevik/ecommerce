using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string Libelle { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        public bool Actif { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public int Prix { get; set; }
       
        public int CategorieId { get; set; }

        public Categorie Categorie { get; set; }

    }
}
