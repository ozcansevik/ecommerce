using Modele.MonProjet.Entities;
using Modele.MonProjet.Initialisation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modele.MonProjet
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("name=ECommerceDB")
        {
            Database.SetInitializer<EcommerceContext>(new EcommerceContextInitializer());
        }

        /// <summary>
        /// Surcharge du OnModelCreating pour ajouter ma configuration Fluent
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// Mes Catégories
        /// </summary>
        public DbSet<Categorie> Categories { get; set; }

        /// <summary>
        /// Mes Catégories
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// Mes Commandes
        /// </summary>
        public DbSet<Commande> Commandes { get; set; }

        /// <summary>
        /// Mes CommandesProduits
        /// </summary>
        public DbSet<CommandeProduit> CommandeProduits { get; set; }

        /// <summary>
        /// Mes Produits
        /// </summary>
        public DbSet<Produit> Produits { get; set; }

        /// <summary>
        /// Mes Statuts
        /// </summary>
        public DbSet<Statut> Statuts { get; set; }

    }
}
