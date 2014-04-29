namespace PrtgSensors
{
    public struct PrtgSpeedOrVolumeSize
    {
        public const string One = "One";
        public const string Kilo = "Kilo";
        public const string Mega = "Mega";
        public const string Giga = "Giga";
        public const string Tera = "Tera";
        public const string Byte = "Byte";
        public const string Kilobyte = "Kilobyte";
        public const string Megabyte = "Megabyte";
        public const string Gigabyte = "Gigabyte";
        public const string Terabyte = "Terabyte";
        public const string Bit = "Bit";
        public const string Kilobit = "Kilobit";
        public const string Megabit = "Megabit";
        public const string Gigabit = "Gigabit";
        public const string Terabit = "Terabit";

        public override int GetHashCode()
        {
            return One.GetHashCode() ^ Kilo.GetHashCode() ^ Mega.GetHashCode() ^
                   Giga.GetHashCode() ^ Tera.GetHashCode() ^ Byte.GetHashCode() ^
                   Kilobyte.GetHashCode() ^ Megabyte.GetHashCode() ^ Gigabyte.GetHashCode() ^
                   Terabyte.GetHashCode() ^ Bit.GetHashCode() ^ Kilobit.GetHashCode() ^ 
                   Megabit.GetHashCode() ^ Gigabit.GetHashCode() ^ Terabit.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is PrtgSpeedOrVolumeSize))
                return false;

            return Equals((PrtgSpeedOrVolumeSize)obj);
        }
        public static bool operator ==(PrtgSpeedOrVolumeSize size1, PrtgSpeedOrVolumeSize size2)
        {
            return (size1.Equals(size2));
        }
        public static bool operator !=(PrtgSpeedOrVolumeSize size1, PrtgSpeedOrVolumeSize size2)
        {
            return !(size1.Equals(size2));
        }
    }
}