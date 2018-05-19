using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class Produit
    {
       [Key]
        private int ID { get; set; }
        [Required]
        private  int Code { get; set; }

        [Required]
        [MaxLength(50)]
        private string Libelle { get; set; }

        [MaxLength(50)]
        private string Description { get; set; }
        [Required]
        private bool Actif { get; set; }
        [Required]
        private int Stock { get; set; }
        private int Prix { get; set; }
        
        private int CategorieID { get; set; }
    }
}
