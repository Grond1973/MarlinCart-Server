using log4net;
using MarlinCart.Common;
using MarlinDataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarlinCartDAL
{
    public class MarlinCartDAO : IMarlinCartDAL
    {
        #region [ CLASS FIELDS ]

        private ILog _logger;
        private CartEntities _dbEntities;

        #endregion

        #region [ CONSTRUCTOR ]

        public MarlinCartDAO(ILog log)
        {
            this._logger = log;
            this._dbEntities = new CartEntities();
        }
        #endregion

        #region [ PROPERTIES ]

        #endregion

        #region [ METHODS ]
        public List<Product> GetCartProducts()
        {
            List<Product> products = null;

            try
            {
                var results = this._dbEntities.GetMarlinProduct().ToList();
                if(results != null && results.Count() > 0)
                {
                    products = new List<Product>();
                    results.ForEach(itm =>
                    {
                        products.Add(new Product(itm.Id, itm.Name, itm.Description, itm.Price));
                    });
                }
                else
                { throw new Exception("Products list cannot be null or empty."); }
            }
            catch(Exception ex)
            {
                this._logger.Error(ex);
                throw;
            }

            return products;
        }

        public List<CreditCardVO> GetCreditCards()
        {
            List<CreditCardVO> ccards = null;

            try
            {
                var results = this._dbEntities.GetCreditCard().ToList();
                if(results != null && results.Count > 0)
                {
                    ccards = new List<CreditCardVO>();

                    results.ForEach(itm =>
                    {
                        ccards.Add(new CreditCardVO(itm.Id, itm.Name));
                    });
                }
                else
                { throw new Exception("Credit cards list cannot be null or empty."); }
            }
            catch(Exception ex)
            {
                this._logger.Error(ex);
                throw;
            }

            return ccards;
        }

        public List<StateVO> GetStates()
        {
            List<StateVO> states = null;

            try
            {
                var result = this._dbEntities.GetStateData().ToList();
                if(result != null && result.Count > 0)
                {
                    result.ForEach(itm =>
                    {
                        states.Add(new StateVO(itm.StateId, itm.Name, itm.Abbreviation));
                    });
                }
                else
                { throw new Exception("States list cannot be null or empty."); }
            }
            catch(Exception ex)
            {
                this._logger.Error(ex);
                throw;
            }

            return states;
        }
        #endregion

    }
}
