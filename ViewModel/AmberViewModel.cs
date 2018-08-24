using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace ViewModel
{
    public class AmberViewModel : INotifyPropertyChanged
    {
        #region Fields
        private string _MachineNum;
        private string _MachineStatus;
        private MoniMode _MonitorMode;
        #endregion Fields

        #region Constructors
        public AmberViewModel()
        {
            _MachineNum = "test machine number";
            _MachineStatus = "test machine status";
            _MonitorMode = MoniMode.NOMARL;
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
        public MoniMode MonitorMode
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

        public enum MoniMode
        {
            [Description("Nomarl")]
            NOMARL,
            [Description("Jorter")]
            JORTER,
            [Description("Bcf")]
            BCF,
            [Description("Amber")]
            AMBER,
            [Description("Ruby")]
            RUBY,
            [Description("Ast")]
            AST,
        }
    }
}
