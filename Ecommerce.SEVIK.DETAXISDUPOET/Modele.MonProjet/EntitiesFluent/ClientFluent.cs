using Modele.MonProjet.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.MonProjet.EntitiesFluent
{
    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent()
        {
            ToTable("APP_Client");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("CLI_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nom).HasColumnName("CLI_NOM").IsRequired().HasMaxLength(50);
            Property(c => c.Prenom).HasColumnName("CLI_PRENOM").IsRequired().HasMaxLength(50);
            Property(c => c.Actif).HasColumnName("CLI_ACTIF");

        }
    }
}
