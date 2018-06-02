using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BusinessLayer.MonProjet;
using Modele.MonProjet.Entities;

namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceECommerce : IServiceECommerce
    {
        private BusinessLayerManager blm;

        public ServiceECommerce()
        {
            this.blm = BusinessLayerManager.Instance;
        }

        public int GetStock(int code)
        {
            Produit p = blm.GetProduit(code);
            return p.Stock;
        }

        public List<Commande> GetCommandeData()
        {
            List<Commande> commandes = blm.GetAllCommande();
            return commandes;
        }

        public List<ProduitContract> GetProduitData()
        {
            List<Produit> produits = blm.GetAllProduit();
            List<ProduitContract> produitsC = new List<ProduitContract>();

            foreach(Produit p in produits)
            {
                ProduitContract pC = new ProduitContract(p.Id, p.Code, p.Libelle, p.Description, p.Stock, p.Prix, p.CategorieId, p.Actif);
                produitsC.Add(pC);
            }

            return produitsC;
        }
    }
}
