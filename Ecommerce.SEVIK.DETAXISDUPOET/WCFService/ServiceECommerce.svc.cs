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

        List<Commande> IServiceECommerce.GetCommandeData()
        {
            List<Commande> commandes = blm.GetAllCommande();
            return commandes;
        }

        List<Produit> IServiceECommerce.GetProduitData()
        {
            List<Produit> produits = blm.GetAllProduit();
            return produits;
        }
    }
}
