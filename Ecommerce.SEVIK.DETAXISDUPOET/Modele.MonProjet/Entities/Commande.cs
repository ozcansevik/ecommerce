using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class Commande
    {
        [Key]
        private int ID { get; set; }

        [Required]
        private DateTime DateCommand { get; set; }

        [MaxLength(50)]
        private string Observation { get; set; }

        [Required]
        private int StatusID { get; set; }

        [Required]
        private int ClientID { get; set; }

    }
}
