using System.Globalization;

namespace PrtgSensors
{
    public class PrtgChannel
    {
        private string _value = ((float)0.0).ToString(CultureInfo.InvariantCulture);
        private string _speedTime = PrtgSpeedTime.Second;
        private string _mode = PrtgMode.Absolute;
        private string _float = "1";
        private string _decimalMode = PrtgDecimalMode.Two;
        private string _warning = "0";
        private string _showChart = "1";
        private string _showTable = "1";
        private string _limitMode = "0";
        private string _unit = PrtgUnit.Custom;
        private string _speedSize = PrtgSpeedOrVolumeSize.One;
        private string _volumeSize = PrtgSpeedOrVolumeSize.One;


        public string VolumeSize
        {
            get { return _volumeSize; }
            set { _volumeSize = value; }
        }
        public string SpeedSize
        {
            get { return _speedSize; }
            set { _speedSize = value; }
        }
        public string ValueLookup { get; set; }
        public string LimitMode
        {
            get { return _limitMode; }
            set { _limitMode = value; }
        }
        public string LimitWarningMessage { get; set; }
        public string LimitErrorMessage { get; set; }
        public string LimitMinError { get; set; }
        public string LimitMinWarning { get; set; }
        public string LimitMaxWarning { get; set; }
        public string LimitMaxError { get; set; }
        public string ShowTable
        {
            get { return _showTable; }
            set { _showTable = value; }
        }
        public string ShowChart
        {
            get { return _showChart; }
            set { _showChart = value; }
        }
        public string Warning
        {
            get { return _warning; }
            set { _warning = value; }
        }
        public string DecimalMode
        {
            get { return _decimalMode; }
            set { _decimalMode = value; }
        }
        public string Float
        {
            get { return _float; }
            set { _float = value; }
        }
        public string SpeedTime
        {
            get { return _speedTime; }
            set { _speedTime = value; }
        }
        public string Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        public string CustomUnit { get; set; }
        public string Channel { get; set; }
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
    }
}