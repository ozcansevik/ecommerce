using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.MonProjet.EntitiesFluent
{
    public class CommandeFluent : EntityTypeConfiguration<Commande>
    {
        public CommandeFluent()
        {
            ToTable("APP_Commande");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("CAT_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.DateCommand).HasColumnName("CAT_DATE_COMMANDE").IsRequired();
            Property(c => c.Observation).HasColumnName("CAT_OBSERVATION").IsRequired().HasMaxLength(50);
            Property(c => c.StatusID).HasColumnName("CAT_STATUS_ID").IsRequired().HasForeignKey(cc => cc.StatusID);
            Property(c => c.ClientID).HasColumnName("CAT_CLIENT_ID").IsRequired().HasForeignKey(ss => ss.ClientID);

        }
    }
}
