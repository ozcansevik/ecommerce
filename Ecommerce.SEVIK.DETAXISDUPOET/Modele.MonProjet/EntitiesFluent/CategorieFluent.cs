﻿using Modele.MonProjet.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modele.MonProjet.EntitiesFluent
{
    public class CategorieFluent : EntityTypeConfiguration<Categorie>
    {
        public CategorieFluent()
        {
            ToTable("APP_Categorie");
            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("CAT_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Libelle).HasColumnName("CAT_NOM").IsRequired().HasMaxLength(50);
            Property(c => c.Actif).HasColumnName("CAT_ACTIF");

            HasMany(c => c.Produits).WithRequired(cc => cc.Categorie).HasForeignKey(cc => cc.CategorieId);
        }
    }
}
