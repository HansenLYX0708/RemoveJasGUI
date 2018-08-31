using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{
    public class TopDeviceViewModel
    {
        #region Fields
        private string _Name;
        private bool _Type;
        private string _State;
        #endregion Fields

        #region Constructors

        #endregion Constructors

        #region Properties
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public bool Type
        {
            get
            {
                return _Type;
            }
        }

        public string State
        {
            get
            {
                return _State;
            }
        }
        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
