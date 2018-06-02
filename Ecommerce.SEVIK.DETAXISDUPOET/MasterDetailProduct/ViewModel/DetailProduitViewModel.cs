using MasterDetailProduct.Commands;
using MasterDetailProduct.ViewModels.Common;
using Modele.MonProjet.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MasterDetailProduct.ViewModel
{
    class DetailProduitViewModel : BaseViewModel
    {
        {
        #region Variables

        private int _code;
        private string _libelle;
        private string _description;
        private bool _actif;
        private int _stock;
        private int _prix;
        private int _categorieID;
        private Categorie _categorie;

        private RelayCommand _addOperation;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// <param name="p">Produit à transformer en DetailProduitViewModel</param>
        /// </summary>
        public DetailProduitViewModel(Produit p)
        {
            _code = p.Code;
            _libelle = p.Libelle;
            _description = p.Description;
            _actif = p.Actif;
            _stock = p.Stock;
            _prix = p.Prix;
            _categorieID = p.CategorieId;
            _categorie = p.Categorie
            
        }

        #endregion

        #region Data Bindings


        /// <summary>
        /// Code du produit
        /// </summary>
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// Libellé du produit
        /// </summary>
        public string Libellé
        {
            get { return _libelle; }
            set { _libelle = value; }
        }

        /// <summary>
        /// Description du produit
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        /// <summary>
        /// Actif du produit
        /// </summary>
        public bool Actif
        {
            get { return _actif; }
            set { _actif = value; }
        }

        /// <summary>
        /// Stock du produit
        /// </summary>
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        /// <summary>
        /// Prix du produit
        /// </summary>
        public int Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        /// <summary>
        /// CatégorieID du produit
        /// </summary>
        public int CatégorieID
        {
            get { return _categorieID; }
            set { _categorieID = value; }
        }

        /// <summary>
        /// Catégorie du produit
        /// </summary>
        public Categorie Catégorie
        {
            get { return _categorie; }
            set { _categorie = value; }
        }

        #endregion

        #region Commandes

        /// <summary>
        /// Commande pour ouvrir la fenêtre pour ajouter une opération
        /// </summary>
        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }

        /// <summary>
        /// Permet l'ouverture de la fenêtre
        /// </summary>
        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }

        #endregion
    }
}
}
