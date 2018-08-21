using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{
    class AmberViewModel
    {

        #region Fields
        private string _MachineStatus;
        private string _MonitorMode;
        #endregion Fields

        #region Constructors
        public AmberViewModel()
        {

        }
        #endregion Constructors

        #region Properties
        string MachineNum { get; set; }
        string MachineStatus
        {
            get
            {
                return _MachineStatus;
            }
            set
            {
                _MachineStatus = value;
            }
        }
        string MonitorMode
        {
            get
            {
                return _MonitorMode;
            }
            set
            {
                _MonitorMode = value;
            }
        }
        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
