using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ViewModel
{
    public class BladeViewModel
    {
        #region Fields
        private string _Name;
        private string _Status;
        private string _SerialNum;
        private string _MemsSN;
        private int _MemsCount;
        private string _DiskSN;

        #endregion Fields

        #region Constructors
        public BladeViewModel()
        { }
        #endregion Constructors

        #region Properties

        #endregion Properties

        #region Methods
        public void Load()
        { }
        public void Eject()
        { }
        public void MovetoPosition()
        { }
        public void MovetoMems()
        { }
        public void PickSlider()
        { }
        public void PlaceSlider()
        { }
        public void OpenTestInstance()
        { }
        #endregion Methods
    }
}
