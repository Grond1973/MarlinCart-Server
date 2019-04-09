using log4net;
using MarlinCart.Common;
using MarlinCartDAL;
using System;
using System.Collections.Generic;

namespace MarlinCartWebApi.Controllers
{
    public class StateController : SITApiBaseController
    {
        #region [ CLASS FIELDS ]

        #endregion

        #region [ CONSTRUCTOR ]

        public StateController(ILog logger, IMarlinCartDAL dataAccessLayer) : base(logger, dataAccessLayer)
        {
            this._logger.Info("In StateController ctor()...");
        }

        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]

        public IEnumerable<StateVO> Get()
        {
            List<StateVO> states = null;
            try
            {
                states = this._dataAccessLayer.GetStates();
            }
            catch (Exception ex)
            {
                this._logger.Error(ex);
            }

            return states;
        }

        #endregion
    }
}
