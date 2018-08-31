using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{
    public class PageEnableControl
    {
        #region Fields
        private bool _TestControl;
        private bool _TeachControl;
        private bool _DeviceControl;
        private bool _StatisticsControl;
        #endregion Fields

        #region Constructors
        public PageEnableControl()
        {
            _TestControl = true;
            _TeachControl = true;
            _DeviceControl = true;
            _StatisticsControl = true;
        }
        #endregion Constructors

        #region Properties
        public bool TestControl
        {
            get
            {
                return _TestControl;
            }
        }
        public bool TeachControl
        {
            get
            {
                return _TeachControl;
            }
        }
        public bool DeviceControl
        {
            get
            {
                return _DeviceControl;
            }
        }
        public bool StatisticsControl
        {
            get
            {
                return _StatisticsControl;
            }
        }


        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
