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

        public int Id { get; set; }

        public string Libelle { get; set;  }

        public virtual ICollection<Commande> Commandes { get; set; }

    }
}
