using Modele.MonProjet.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.MonProjet.EntitiesFluent
{
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_Statut");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(50);

        }
    }
}
