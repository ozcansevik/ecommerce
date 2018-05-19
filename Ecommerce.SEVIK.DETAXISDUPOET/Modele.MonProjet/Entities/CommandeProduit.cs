using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Entities
{
    public class CommandeProduit
    {
        private int ProduitID { get; set; }

        private int CommandeID { get; set; }

        [Required]
        private int Quantite { get; set; }
    }
}
