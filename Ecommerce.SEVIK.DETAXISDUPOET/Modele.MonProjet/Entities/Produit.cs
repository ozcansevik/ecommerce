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

        private int ID { get; set; }

        private  int Code { get; set; }

        private string Libelle { get; set; }

        private string Description { get; set; }

        private bool Actif { get; set; }

        private int Stock { get; set; }
        private int Prix { get; set; }
       
        private int CategorieID { get; set; }
    }
}
