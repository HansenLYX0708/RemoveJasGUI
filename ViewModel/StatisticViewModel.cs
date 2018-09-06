using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ViewModel
{
    public class StatisticViewModel
    {
        #region Fields
        private string _DowntimeStart;
        private string _DowntimeEnd;
        private string _UptimeStart;
        private string _UptimeEnd;

        public List<DowntimeInfo> downtimeInfos;
        public List<HourlyYield> hourlyYields1;
        public List<HourlyYield> hourlyYields2;
        public List<ParetoOfDefect> paretoOfDefects;
        public List<TotalECPerBlade> totalECPerBlades;
        #endregion Fields

        #region Constructors
        public StatisticViewModel()
        {
            _DowntimeStart = "";
            _DowntimeEnd = "";
            _UptimeStart = "";
            _UptimeEnd = "";

            downtimeInfos = new List<DowntimeInfo>();
            hourlyYields1 = new List<HourlyYield>();
            hourlyYields2 = new List<HourlyYield>();
            paretoOfDefects = new List<ParetoOfDefect>();
            totalECPerBlades = new List<TotalECPerBlade>();

            for (int i = 0; i < 5; i++)
            {
                DowntimeInfo tmpInfo = new DowntimeInfo();
                tmpInfo.ErrorCode = String.Format("Error{0}", i + 1);
                downtimeInfos.Add(tmpInfo);
            }

            for (int i = 0; i < 5; i++)
            {
                HourlyYield tmpHourlyYield = new HourlyYield();
                hourlyYields1.Add(tmpHourlyYield);
            }
            for (int i = 0; i < 5; i++)
            {
                HourlyYield tmpHourlyYield = new HourlyYield();
                hourlyYields2.Add(tmpHourlyYield);
            }

            hourlyYields1[0].Time = "7:01-8:00";
            hourlyYields1[1].Time = "8:01-9:00";
            hourlyYields1[2].Time = "9:01-10:00";
            hourlyYields1[3].Time = "10:01-11:00";
            hourlyYields1[4].Time = "11:01-12:00";
            hourlyYields2[0].Time = "12:01-1:00";
            hourlyYields2[1].Time = "1:01-2:00";
            hourlyYields2[2].Time = "2:01-3:00";
            hourlyYields2[3].Time = "3:01-4:00";
            hourlyYields2[4].Time = "4:01-5:00";

            for (int i = 0; i < 5; i++)
            {
                ParetoOfDefect tmpParetoOfDefect = new ParetoOfDefect();
                tmpParetoOfDefect.BladeNum = i + 1;
                paretoOfDefects.Add(tmpParetoOfDefect);
            }
            for (int i = 0, j = 1000; i < 10; i++, j++)
            {
                TotalECPerBlade tmpTotalECPerBlade = new TotalECPerBlade();
                tmpTotalECPerBlade.ErrorCode = j;
                totalECPerBlades.Add(tmpTotalECPerBlade);
            }
        }
        #endregion Constructors

        #region Properties
        public string DowntimeStart
        {
            get
            {
                return _DowntimeStart;
            }
            set
            {
                _DowntimeStart = value;
            }
        }
        public string DowntimeEnd
        {
            get
            {
                return _DowntimeEnd;
            }
            set
            {
                _DowntimeEnd = value;
            }
        }
        public string UptimeStart
        {
            get
            {
                return _UptimeStart;
            }
            set
            {
                _UptimeStart = value;
            }
        }
        public string UptimeEnd
        {
            get
            {
                return _UptimeEnd;
            }
            set
            {
                _UptimeEnd = value;
            }
        }

        #endregion Properties

        #region Methods

        #endregion Methods
    }

    public class DowntimeInfo : INotifyPropertyChanged
    {
        #region Fields
        private string _errorCode;
        private string _errorCATEGORY;
        private string _startTime;
        private string _endTime;
        #endregion Fields

        #region Constructors
        public DowntimeInfo()
        {
            _errorCode = "";
            _errorCATEGORY = "";
            _startTime = "";
            _endTime = "";
        }
        #endregion Constructors

        #region Properties
        public string ErrorCode
        {
            get
            {
                return _errorCode;
            }
            set
            {
                _errorCode = value;
            }
        }
        public string ErrorCATEGORY
        {
            get
            {
                return _errorCATEGORY;
            }
            set
            {
                _errorCATEGORY = value;
            }
        }
        public string StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }
        public string EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
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

    public class HourlyYield : INotifyPropertyChanged
    {
        #region Fields
        private string _time;
        private int _inCount;
        private int _outCount;
        private string _yield;
        #endregion Fields

        #region Constructors
        public HourlyYield()
        {
            _time = "";
            _inCount = 0;
            _outCount = 0;
            _yield = "";
        }
        #endregion Constructors

        #region Properties
        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
        public int InCount
        {
            get
            {
                return _inCount;
            }
            set
            {
                _inCount = value;
            }
        }
        public int OutCount
        {
            get
            {
                return _outCount;
            }
            set
            {
                _outCount = value;
            }
        }
        public string Yield
        {
            get
            {
                return _yield;
            }
            set
            {
                _yield = value;
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

    public class ParetoOfDefect : INotifyPropertyChanged
    {
        #region Fields
        private int _bladeNum;
        private string _mistest;
        private string _contact;
        private string _PES;
        private string _DSC;
        private string _last50;
        private string _total;
        #endregion Fields

        #region Constructors
        public ParetoOfDefect()
        {
            _bladeNum = 1;
            _mistest = "";
            _contact = "";
            _PES = "";
            _DSC = "";
            _last50 = "";
            _total = "";
        }
        #endregion Constructors

        #region Properties
        public int BladeNum
        {
            get
            {
                return _bladeNum;
            }
            set
            {
                _bladeNum = value;
            }
        }
        public string MisTest
        {
            get
            {
                return _mistest;
            }
            set
            {
                _mistest = value;
            }
        }
        public string Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
            }
        }
        public string PES
        {
            get
            {
                return _PES;
            }
            set
            {
                _PES = value;
            }
        }
        public string DSC
        {
            get
            {
                return _DSC;
            }
            set
            {
                _DSC = value;
            }
        }
        public string Last50
        {
            get
            {
                return _last50;
            }
            set
            {
                _last50 = value;
            }
        }
        public string Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
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

    public class TotalECPerBlade : INotifyPropertyChanged
    {
        #region Fields
        private int _errorCode;
        private int _blade1Count;
        private int _blade2Count;
        private int _blade3Count;
        private int _blade4Count;
        private int _blade5Count;
        #endregion Fields

        #region Constructors
        public TotalECPerBlade()
        {
            _errorCode = 1000;
            _blade1Count = 0;
            _blade2Count = 0;
            _blade3Count = 0;
            _blade4Count = 0;
            _blade5Count = 0;
        }
        #endregion Constructors

        #region Properties
        public int ErrorCode
        {
            get
            {
                return _errorCode;
            }
            set
            {
                _errorCode = value;
            }
        }
        public int Blade1Count
        {
            get
            {
                return _blade1Count;
            }
            set
            {
                _blade1Count = value;
            }
        }
        public int Blade2Count
        {
            get
            {
                return _blade2Count;
            }
            set
            {
                _blade2Count = value;
            }
        }
        public int Blade3Count
        {
            get
            {
                return _blade3Count;
            }
            set
            {
                _blade3Count = value;
            }
        }
        public int Blade4Count
        {
            get
            {
                return _blade4Count;
            }
            set
            {
                _blade4Count = value;
            }
        }
        public int Blade5Count
        {
            get
            {
                return _blade5Count;
            }
            set
            {
                _blade5Count = value;
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
