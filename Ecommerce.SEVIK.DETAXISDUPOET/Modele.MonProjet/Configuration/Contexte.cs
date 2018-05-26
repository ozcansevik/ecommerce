using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet.Configuration
{
    public class Contexte : DbContext
    {

        public Contexte() : base("name=ECommerceDB") {
            Database.SetInitializer<ContextFluent>(new DropCreateDatabaseIfModelChanges<ContextFluent>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.Add(new ClientFluent());
            modelBuilder.Configurations.Add(new CompteClientFluent());
        }


        public DbSet<Categorie> Categories { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Commande> Commandes { get; set; }

        public DbSet<CommandeProduit> CommandesProduits { get; set; }

        public DbSet<Produit> Produits { get; set; }

        public DbSet<Statut> Status { get; set; }
    }
}
