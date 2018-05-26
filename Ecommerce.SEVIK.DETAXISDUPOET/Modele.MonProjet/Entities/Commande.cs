using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class Commande
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateCommand { get; set; }

        [MaxLength(50)]
        public string Observation { get; set; }

        [Required]
        public int StatusId { get; set; }

        public Statut Statut { get; set; }

        [Required]
        public int ClientId { get; set; }
        
        public Client Client { get; set; }
        
        public virtual ICollection<CommandeProduit> CommandeProduits { get; set; }

    }
}
