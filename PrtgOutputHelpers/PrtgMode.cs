namespace PrtgSensors
{
    public struct PrtgMode
    {
        public const string Absolute = "Absolute";
        public const string Difference = "Difference";

        public override int GetHashCode()
        {
            return Absolute.GetHashCode() ^ Difference.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is PrtgMode))
                return false;

            return Equals((PrtgMode)obj);
        }
        public static bool operator ==(PrtgMode mode1, PrtgMode mode2)
        {
            return (mode1.Equals(mode2));
        }
        public static bool operator !=(PrtgMode mode1, PrtgMode mode2)
        {
            return !(mode1.Equals(mode2));
        }
    }
}