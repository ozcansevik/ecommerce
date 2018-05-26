using Modele.MonProjet.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Modele.MonProjet.EntitiesFluent
{
    public class CommandeProduitFluent : EntityTypeConfiguration<CommandeProduit>
    {
        public CommandeProduitFluent()
        {
            ToTable("APP_CommandeProduit");
            HasKey(c => new { c.Id, c.CommandeId });

            Property(c => c.Id).HasColumnName("CAT_PRODUIT_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Quantite).HasColumnName("CAT_QUANTITE").IsRequired();

            HasRequired(cc => cc.Commande).WithMany(c => c.CommandeProduits).HasForeignKey(c => c.CommandeId);

        }
    }
}
