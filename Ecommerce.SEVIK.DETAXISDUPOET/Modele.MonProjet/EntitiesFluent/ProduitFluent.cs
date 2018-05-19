using Modele.MonProjet.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.MonProjet.EntitiesFluent
{
    public class ProduitFluent : EntityTypeConfiguration<Produit>
    {
        public ProduitFluent()
        {
            ToTable("APP_Produit");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("PRD_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Code).HasColumnName("PRD_CODE").IsRequired().HasMaxLength(50);
            Property(c => c.Libelle).HasColumnName("PRD_LIBELLE").IsRequired().HasMaxLength(50);
            Property(c => c.Description).HasColumnName("PRD_DESCRIPTION").HasMaxLength(50);
            Property(c => c.Actif).HasColumnName("PRD_ACTIF");
            Property(c => c.Stock).HasColumnName("PRD_STOCK").IsRequired();
            Property(c => c.Prix).HasColumnName("PRD_PRIX");
            Property(c => c.CategorieID).HasColumnName("PRD_CATEGORIEID").HasForeignKey(cc => cc.CategorieID);

        }
    }
}
