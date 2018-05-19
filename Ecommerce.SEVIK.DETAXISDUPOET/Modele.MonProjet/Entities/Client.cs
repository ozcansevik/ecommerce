using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class Client
    {
        [Key]
        private int ID { get; set; }

        [Required]
        [MaxLength(50)]
        private string Nom { get; set; }

        [Required]
        [MaxLength(50)]
        private string Prenom { get; set; }

        private bool Actif { get; set; }

    }
}
