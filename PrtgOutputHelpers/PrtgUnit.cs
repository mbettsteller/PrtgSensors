namespace PrtgSensors
{
    public struct PrtgUnit
    {
        public const string BytesBandwidth = "BytesBandwidth";
        public const string BytesMemory = "BytesMemory";
        public const string BytesDisk = "BytesDisk";
        public const string Temperature = "Temperature";
        public const string Percent = "Percent";
        public const string TimeResponse = "TimeResponse";
        public const string TimeSeconds = "TimeSeconds";
        public const string Custom = "Custom";
        public const string Count = "Count";
        public const string Cpu = "Cpu (*)";
        public const string BytesFile = "BytesFile";
        public const string SpeedDisk = "SpeedDisk";
        public const string SpeedNet = "SpeedNet";
        public const string TimeHours = "TimeHours";

        public override int GetHashCode()
        {
            return BytesBandwidth.GetHashCode() ^ BytesMemory.GetHashCode() ^ BytesDisk.GetHashCode() ^
                   Temperature.GetHashCode() ^ Percent.GetHashCode() ^ TimeResponse.GetHashCode() ^
                   TimeSeconds.GetHashCode() ^ Custom.GetHashCode() ^
                   Count.GetHashCode() ^ Cpu.GetHashCode() ^ BytesFile.GetHashCode() ^
                   SpeedDisk.GetHashCode() ^ SpeedNet.GetHashCode() ^ TimeHours.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is PrtgUnit))
                return false;

            return Equals((PrtgUnit)obj);
        }
        public static bool operator ==(PrtgUnit unit1, PrtgUnit unit2)
        {
            return (unit1.Equals(unit2));
        }
        public static bool operator !=(PrtgUnit unit1, PrtgUnit unit2)
        {
            return !(unit1.Equals(unit2));
        }
    }
}