using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarlinCart.Common
{
    public class StateVO
    {
        #region [ CLASS FIELDS ]

        private int _id;
        private string _name;
        private string _abbreviation;

        #endregion

        #region [ CONSTRUCTOR ]
        public StateVO()
        {
            _id = 0;
            _name = String.Empty;
            _abbreviation = String.Empty;
        }

        public StateVO(int id, string name, string abbreviation)
        {
            _id = id;
            _name = name;
            _abbreviation = abbreviation;
        }


        #endregion

        #region [ PROPERTIES ]

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Abbreviation { get => _abbreviation; set => _abbreviation = value; }
        #endregion

        #region [ METHODS ]

        public override string ToString()
        {
            return "Id: " + this._id.ToString() + " Name: " + this._name + " Abbreviation: " + this._abbreviation;
        }

        #endregion
    }
}