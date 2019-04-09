using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarlinCart.Common
{
    public class CreditCardVO
    {
        #region [ CLASS FIELDS ]

        private int _id;
        private string _name;

        public CreditCardVO()
        {
            this._id = 0;
            this._name = String.Empty;
        }
        public CreditCardVO(int id, string name)
        {
            _id = id;
            _name = name;
        }

        
        #endregion

        #region [ CONSTRUCTOR ]

        #endregion

        #region [ PROPERTIES ]

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        #endregion

        #region [ METHODS ]

        public override string ToString()
        {
            return "CC Name: " + this._name + " ID: " + this._id.ToString();
        }
        #endregion
    }
}