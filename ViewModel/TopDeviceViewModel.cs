using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ViewModel
{
    public class TopDeviceViewModel : INotifyPropertyChanged
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
                this.OnPropertyChanged("Name");
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
            set
            {
                _State = value;
                this.OnPropertyChanged("State");
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
    }
}
