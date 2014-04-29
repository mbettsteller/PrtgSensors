using System;
using System.IO;

namespace PrtgSensorTests
{
    public class CatchConsoleOutput : IDisposable
    {
        internal readonly StringWriter StringWriterOutput;
        internal readonly TextWriter OriginalOutput;

        public CatchConsoleOutput()
        {
            StringWriterOutput = new StringWriter();
            OriginalOutput = Console.Out;
            Console.SetOut(StringWriterOutput);
        }

        public string GetOuput()
        {
            return StringWriterOutput.ToString();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (StringWriterOutput != null)
                {
                    Console.SetOut(OriginalOutput);
                    StringWriterOutput.Dispose();
                }
            }
        }
    }
}
