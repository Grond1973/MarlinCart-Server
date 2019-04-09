using log4net;
using MarlinCartDAL;
using System.Web.Http;

namespace MarlinCartWebApi.Controllers
{
    public abstract class SITApiBaseController : ApiController
    {
        #region [ CLASS FIELDS ]

        protected ILog _logger;
        protected IMarlinCartDAL _dataAccessLayer;

        #endregion

        #region [ CONSTRUCTOR ]

        public SITApiBaseController(ILog logger, IMarlinCartDAL dataAccessLayer) : base()
        {
            this._logger = logger;
            this._dataAccessLayer = dataAccessLayer;
            this._logger.Info("In SITApiBaseController ctor()...");
        }
        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]

        #endregion
    }
}