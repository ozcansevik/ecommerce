﻿using MasterDetailProduct.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailProduct.ViewModel
{
    class HomeViewModel : BaseViewModel
    {

        #region Variables

        private ListeProduitViewModel _listeProduitViewModel = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listeProduitViewModel = new ListeProduitViewModel();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListeProduitViewModel
        /// </summary>
        public ListeProduitViewModel ListeProduitViewModel
        {
            get { return _listeProduitViewModel; }
            set { _listeProduitViewModel = value; }
        }

        #endregion
    }
}
