using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private string _Type;
        private string _ActuatorSerialNumber;
        private string _PCBASerialNumber;
        private string _MotorSerialNumber;
        private string _FlexSerialNumber;
        #endregion Fields

        #region Constructors
        public BladeViewModel()
        {
            _Name = "Blade1";
            _Status = "Open";
            _SerialNum = "C2247";
            _MemsSN = "File not found";
            _MemsCount = 2065;
            _DiskSN = "A0XK94S";
            _Type = "AR8 DN";
            _ActuatorSerialNumber = "File not found";
            _PCBASerialNumber = "File not found";
            _MotorSerialNumber = "File not found";
            _FlexSerialNumber = "PA527004LXD1";
        }
        #endregion Constructors

        #region Properties
        [Category("Base")]
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
        [Category("Base")]
        public string Status
        {
            get
            {
                return _Status;
            }
        }
        [Category("SerialNumber")]
        public string BladeSN
        {
            get
            {
                return _SerialNum;
            }
        }
        [Category("SerialNumber")]
        public string MemsSN
        {
            get
            {
                return _MemsSN;
            }
        }
        [Category("Base")]
        public int MemsCount
        {
            get
            {
                return _MemsCount;
            }
        }
        [Category("SerialNumber")]
        public string DiskSN
        {
            get
            {
                return _DiskSN;
            }
        }
        [Category("Base")]
        public string Type
        {
            get
            {
                return _Type;
            }
        }
        [Category("SerialNumber")]
        public string ActuatorSN
        {
            get
            {
                return _ActuatorSerialNumber;
            }
        }
        [Category("SerialNumber")]
        public string PCBASN
        {
            get
            {
                return _PCBASerialNumber;
            }
        }
        [Category("SerialNumber")]
        public string MotorSN
        {
            get
            {
                return _MotorSerialNumber;
            }
        }
        [Category("SerialNumber")]
        public string FlexSN
        {
            get
            {
                return _FlexSerialNumber;
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
