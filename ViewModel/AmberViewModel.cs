using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ViewModel
{
    public class AmberViewModel
    {
        #region Fields
        public PageEnableControl PageEnableControl;
        public TestMachineViewModel CommonInfo;
        public BladeViewModel[] Blades;
        public TrayViewModel[] Trays;
        public PickerViewModel[] Pickers;
        public DatumViewModel[] Datums;
        #endregion Fields

        #region Constructors
        public AmberViewModel()
        {
            PageEnableControl = new PageEnableControl();
            CommonInfo = new TestMachineViewModel();
            Blades = new BladeViewModel[5];
            Trays = new TrayViewModel[14];
            Pickers = new PickerViewModel[2];
            Datums = new DatumViewModel[2];
        }
        #endregion Constructors

        #region Properties

        #endregion Properties

        #region Methods
        private void RefreshUI()
        {

        }
        #endregion Methods
    }
}
