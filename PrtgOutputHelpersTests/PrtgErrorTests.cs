using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSensors;

namespace PrtgSensorTests
{
    [TestClass]
    public class PrtgErrorTests
    {
        [TestMethod]
        public void WriteOutputTest()
        {
            const string test = "<prtg><error>1</error><text>Errorwithoutexception.</text></prtg>";

            using (var consoleOutput = new CatchConsoleOutput())
            {
                PrtgError.WriteOutput("Error without exception.");
                var tmp = consoleOutput.GetOuput().Replace(" ", "").Replace("\r\n", "");
                Assert.AreEqual(test, tmp);
                //this is just needed for output
                Console.SetOut(consoleOutput.OriginalOutput);
                Console.WriteLine(tmp);
            }
        }

        [TestMethod]
        public void WriteOutputTest1()
        {
            const string test = "<prtg><error>1</error><text>ErrorwithNullReferenceException.Objectreferencenotsettoaninstanceofanobject.</text></prtg>";

            using (var consoleOutput = new CatchConsoleOutput())
            {
                PrtgError.WriteOutput("Error with NullReferenceException.", new NullReferenceException());
                var tmp = consoleOutput.GetOuput().Replace(" ", "").Replace("\r\n", "");
                Assert.AreEqual(test, tmp);
                //this is just needed for output
                Console.SetOut(consoleOutput.OriginalOutput);
                Console.WriteLine(tmp);
            }
        }
    }
}
