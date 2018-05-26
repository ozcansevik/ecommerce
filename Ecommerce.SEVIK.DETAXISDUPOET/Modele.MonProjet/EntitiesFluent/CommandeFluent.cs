using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

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

            HasRequired(cc => cc.Statut).WithMany(c => c.Commandes).HasForeignKey(c => c.StatusId);
            HasRequired(cc => cc.Client).WithMany(c => c.Commandes).HasForeignKey(c => c.ClientId);

        }
    }
}
