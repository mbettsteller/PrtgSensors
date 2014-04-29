namespace PrtgSensors
{
    public struct PrtgSpeedTime
    {
        public const string Second = "Second";
        public const string Minute = "Minute";
        public const string Hour = "Hour";
        public const string Day = "Day";

        public override int GetHashCode()
        {
            return Second.GetHashCode() ^ Minute.GetHashCode() ^ Hour.GetHashCode() ^ Day.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is PrtgSpeedTime))
                return false;

            return Equals((PrtgSpeedTime)obj);
        }
        public static bool operator ==(PrtgSpeedTime speedTime1, PrtgSpeedTime speedTime2)
        {
            return (speedTime1.Equals(speedTime2));
        }
        public static bool operator !=(PrtgSpeedTime speedTime1, PrtgSpeedTime speedTime2)
        {
            return !(speedTime1.Equals(speedTime2));
        }
    }
}