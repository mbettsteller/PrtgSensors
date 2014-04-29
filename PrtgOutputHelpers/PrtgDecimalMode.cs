using System.Globalization;

namespace PrtgSensors
{
    public struct PrtgDecimalMode
    {
        public const string Auto = "Auto";
        public const string All = "All";
        public static readonly string Two = 2.ToString(CultureInfo.InvariantCulture);

        public override int GetHashCode()
        {
            return Auto.GetHashCode() ^ All.GetHashCode() ^ Two.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is PrtgDecimalMode))
                return false;

            return Equals((PrtgDecimalMode)obj);
        }         
        public static bool operator ==(PrtgDecimalMode mode1, PrtgDecimalMode mode2)
        {
            return (mode1.Equals(mode2));
        }
        public static bool operator !=(PrtgDecimalMode mode1, PrtgDecimalMode mode2)
        {
            return !(mode1.Equals(mode2));
        }
    }
}