using System;
using System.IO;
using PrtgSensors.Properties;

namespace PrtgSensors
{
        public static class Logger
        {
            public static void Log(Exception exception)
            {
                if (exception != null)
                {
                    using (
                        var file =
                            new StreamWriter(Settings.Default.string_logfilepath + Settings.Default.string_logfilename,
                                true))
                    {
                        try
                        {
                            file.WriteLine(DateTime.Now.ToShortDateString() + "-" +
                                           DateTime.Now.ToLongTimeString());
                            file.WriteLine(exception.Message);
                            file.WriteLine(exception.StackTrace);
                        }
                        catch (Exception ex)
                        {
                            Console.Error.WriteLine(ex.StackTrace);
                            Console.Error.WriteLine(ex.Message);
                            throw;
                        }
                    } //using file
                }
            }
        }
}
