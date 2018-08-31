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
        {
            _Name = "Blade Test";
            _Status = "Open";
            _SerialNum = "woei3e89fuw";
            _MemsSN = "SASIDU7869";
            _MemsCount = 2345;
            _DiskSN = "sfdg344";
        }
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

        public string Status
        {
            get
            {
                return _Status;
            }
        }
        public string SerialNum
        {
            get
            {
                return _SerialNum;
            }
        }
        public string MemsSN
        {
            get
            {
                return _MemsSN;
            }
        }
        public int MemsCount
        {
            get
            {
                return _MemsCount;
            }
        }

        public string DiskSN
        {
            get
            {
                return _DiskSN;
            }
        }

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
