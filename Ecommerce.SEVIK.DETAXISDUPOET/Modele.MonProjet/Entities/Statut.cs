using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class Statut
    {
        [Key]
        private int ID { get; set; }

        [Required]
        [MaxLength(50)]
        private string Libelle { get; set;  }

    }
}
