using log4net;
using MarlinCart.Common;
using MarlinCartDAL;
using System;
using System.Collections.Generic;

namespace MarlinCartWebApi.Controllers
{
    public class CreditCardController : SITApiBaseController
    {
        #region [ CLASS FIELDS ]

        #endregion

        #region [ CONSTRUCTOR ]

        public CreditCardController(ILog logger, IMarlinCartDAL dataAccessLayer) : base(logger, dataAccessLayer)
        {
            this._logger.Info("In CreditCardController ctor()...");
        }
        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]

        public IEnumerable<CreditCardVO> Get()
        {
            List<CreditCardVO> ccards = null;
            try
            {
                ccards = this._dataAccessLayer.GetCreditCards();
            }
            catch (Exception ex)
            {
                this._logger.Error(ex);
            }

            return ccards;
        }
        #endregion

    }
}
