using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ViewModel
{
    public class TestMachineViewModel : INotifyPropertyChanged
    {
        #region Fields
        private string _MachineNum;
        private string _MachineStatus;
        private string _MonitorMode;
        #endregion Fields

        #region Constructors
        public TestMachineViewModel()
        {
            _MachineNum = "MFG567A";
            _MachineStatus = "MACHINE DOWN";
            _MonitorMode = "Normal";
        }
        #endregion Constructors

        #region Properties
        public string MachineNum
        {
            get
            {
                return _MachineNum;
            }
            set
            {
                _MachineNum = value;
                this.OnPropertyChanged("MachineNum");
            }
        }
        public string MachineStatus
        {
            get
            {
                return _MachineStatus;
            }
            set
            {
                _MachineStatus = value;
                this.OnPropertyChanged("MachineStatus");
            }
        }
        public string MonitorMode
        {
            get
            {
                return _MonitorMode;
            }
            set
            {
                _MonitorMode = value;
                this.OnPropertyChanged("MonitorMode");
            }
        }
        #endregion Properties

        #region Methods
        public void Connect()
        { }

        public void Disconnect()
        { }

        public void Configuration()
        { }
        #endregion Methods

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        #endregion INotifyPropertyChanged Members
    }
}
