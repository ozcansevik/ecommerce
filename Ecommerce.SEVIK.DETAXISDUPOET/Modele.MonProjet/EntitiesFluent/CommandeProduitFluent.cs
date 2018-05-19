using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.EntitiesFluent
{
    public class CommandeProduitFluent : EntityTypeConfiguration<CommandeProduit>
    {
        public CommandeProduitFluent()
        {
            ToTable("APP_CommandeProduit");
            HasKey(c => new { c.ProduitID, c.CommandeID });

            Property(c => c.ProduitID).HasColumnName("CAT_PRODUIT_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.CommandeID).HasColumnName("CAT_COMMANDE_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Quantite).HasColumnName("CAT_QUANTITE").IsRequired();
        }
    }
}
