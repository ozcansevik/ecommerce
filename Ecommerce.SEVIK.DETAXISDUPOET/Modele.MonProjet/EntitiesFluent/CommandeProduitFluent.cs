using Modele.MonProjet.Entities;
using System.ComponentModel.DataAnnotations.Schema;

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
