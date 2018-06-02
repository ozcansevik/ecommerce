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
        List<ProduitContract> GetProduitData();

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

    [DataContract]
    public class ProduitContract
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Libelle { get; set; }
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Stock { get; set; }

        [DataMember]
        public int Prix { get; set; }

        [DataMember]
        public int CategorieId { get; set; }

        [DataMember]
        public bool Actif { get; set; }

        public ProduitContract(int id, int code, string libelle, string description, int stock, int prix, int categorieId, bool actif)
        {
            Id = id;
            Code = code;
            Libelle = libelle;
            Description = description;
            Stock = stock;
            Prix = prix;
            CategorieId = categorieId;
            Actif = actif;
        }
    }
}