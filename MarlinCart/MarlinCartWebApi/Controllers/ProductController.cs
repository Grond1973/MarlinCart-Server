using log4net;
using MarlinCart.Common;
using MarlinCartDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarlinCartWebApi.Controllers
{
    public class ProductController : SITApiBaseController
    {
        #region [ CLASS FIELDS ]

        #endregion

        #region [ CONSTRUCTOR ]
        public ProductController(ILog logger, IMarlinCartDAL dataAccessLayer) : base(logger, dataAccessLayer)
        {
            this._logger.Info("In ProductController ctor()...");
        }
        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]

        public IEnumerable<Product> Get ()
        {
            List<Product> products = null;
            try
            {
                products = this._dataAccessLayer.GetCartProducts();
            }
            catch(Exception ex)
            {
                this._logger.Error(ex);
            }

            return products;
        }
        #endregion
    }
}
