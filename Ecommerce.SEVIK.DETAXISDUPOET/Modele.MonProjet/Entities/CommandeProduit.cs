using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class CommandeProduit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Quantite { get; set; }

        public int CommandeId { get; set; }

        public virtual Commande Commande { get; set; }
    }
}
