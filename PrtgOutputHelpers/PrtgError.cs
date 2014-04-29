using System;
using System.Globalization;
using System.Xml.Linq;

namespace PrtgSensors
{
    public static class PrtgError
    {
        public static void WriteOutput(string text)
        {
            WriteOutput(text,null);
        }
        public static void WriteOutput(string text, Exception exception)
        {
            if (exception != null)
            {
                text = text + " " + exception.Message + " " + exception.StackTrace;
                Logger.Log(exception);
            }
            var prtg =
                new XElement("prtg",
                    new XElement("error", 1.ToString(CultureInfo.InvariantCulture)),
                    new XElement("text", text));
            Console.WriteLine(prtg);
        }
    }

}