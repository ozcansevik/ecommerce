using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Modele.MonProjet.Entities;

namespace WCFService
{
    [ServiceContract]
    public interface IServiceECommerce
    {
        /*
         * GET : tous les produits
         */
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "produit_data")]
        ProduitData GetProduitData();

        /*
         * GET : toutes les commandes
         */
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "produit_data")]
        CommandeData GetCommandeData();

        /*
         * GET : stock d'un produit
         */
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "stocke?code={code}")]
        int GetStock(int code);

    }

    // Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
    [DataContract]
    public class ProduitData
    {
       
        [DataMember]
        public List<Produit> produits
        {
            get { return produits; }
            set { produits = value; }
        }

    }

    [DataContract]
    public class CommandeData
    {

        [DataMember]
        public List<Commande> commandes
        {
            get { return commandes; }
            set { commandes = value; }
        }

    }
}
