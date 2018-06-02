using Modele.MonProjet.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Modele.MonProjet.EntitiesFluent
{
    public class ProduitFluent : EntityTypeConfiguration<Produit>
    {
        public ProduitFluent()
        {
            ToTable("APP_Produit");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("PRD_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Code).HasColumnName("PRD_CODE").IsRequired();
            Property(c => c.Libelle).HasColumnName("PRD_LIBELLE").IsRequired().HasMaxLength(50);
            Property(c => c.Description).HasColumnName("PRD_DESCRIPTION").HasMaxLength(50);
            Property(c => c.Actif).HasColumnName("PRD_ACTIF");
            Property(c => c.Stock).HasColumnName("PRD_STOCK").IsRequired();
            Property(c => c.Prix).HasColumnName("PRD_PRIX").IsRequired();
            Property(c => c.CategorieId).HasColumnName("PRD_CATID").IsRequired();

            HasRequired(cc => cc.Categorie).WithMany(c => c.Produits).HasForeignKey(c => c.CategorieId);

        }
    }
}
