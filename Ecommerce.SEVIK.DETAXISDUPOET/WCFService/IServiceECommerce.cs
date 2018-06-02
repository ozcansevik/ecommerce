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
            UriTemplate = "produits")]
        List<Produit> GetProduitData();

        /*
         * GET : toutes les commandes
         */
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "commandes")]
        List<Commande> GetCommandeData();

        /*
         * GET : stock d'un produit
         */
        [OperationContract]
        [WebInvoke(Method = "GET",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "stock?code={code}")]
        int GetStock(int code);

    }
}