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
        public List<BladeViewModel> m_Blades;
        public List<TrayViewModel> m_Trays;
        public List<PickerViewModel> m_Pickers;
        public List<DatumViewModel> m_Datums;
        public List<TopDeviceViewModel> m_TopDevices;
        public StatisticViewModel m_StatisticViewModel;
        #endregion Fields

        #region Constructors
        public AmberViewModel()
        {
            PageEnableControl = new PageEnableControl();
            CommonInfo = new TestMachineViewModel();

            m_Blades = new List<BladeViewModel>();
            m_Trays = new List<TrayViewModel>();
            m_Pickers = new List<PickerViewModel>();
            m_Datums = new List<DatumViewModel>();
            m_TopDevices = new List<TopDeviceViewModel>();

            m_StatisticViewModel = new StatisticViewModel();
            // Init all device Data
            for (int i = 0; i < 5; i++)
            {
                BladeViewModel tmpBlade = new BladeViewModel();
                tmpBlade.Name = String.Format("Blade{0}", i + 1);
                m_Blades.Add(tmpBlade);
            }

            for (int i = 0; i < 14; i++)
            {
                TrayViewModel tmpTray = new TrayViewModel();
                tmpTray.Name = String.Format("Tray{0}", i + 1);
                m_Trays.Add(tmpTray);
            }

            for (int i = 0; i < 2; i++)
            {
                PickerViewModel tmpPicker = new PickerViewModel();
                tmpPicker.Name = String.Format("Picker{0}", i + 1);
                m_Pickers.Add(tmpPicker);
            }

            for (int i = 0; i < 2; i++)
            {
                DatumViewModel tmpDatum = new DatumViewModel();
                tmpDatum.Name = String.Format("Datum{0}", i + 1);
                m_Datums.Add(tmpDatum);
            }

            for (int i = 0; i < 20; i++)
            {
                TopDeviceViewModel tmpTopDevice = new TopDeviceViewModel();
                tmpTopDevice.Name = String.Format("Device{0}", i + 1);
                tmpTopDevice.State = "On";
                m_TopDevices.Add(tmpTopDevice);
            }
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
