using System;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrtgSensors;

namespace PrtgSensorTests
{
    [TestClass]
    public class PrtgResultTests
    {
        [TestMethod]
        public void WriteOutputTest()
        {
            string test = 
@"<prtg>
  <result>
    <limitmode>0</limitmode>
    <showtable>1</showtable>
    <showchart>1</showchart>
    <warning>0</warning>
    <decimalmode>2</decimalmode>
    <float>1</float>
    <mode>Absolute</mode>
    <speedtime>Second</speedtime>
    <volumesize>One</volumesize>
    <speedsize>One</speedsize>
    <unit>Custom</unit>
    <value>2.0</value>
    <channel>channel2</channel>
  </result>
  <result>
    <limitmode>0</limitmode>
    <showtable>1</showtable>
    <showchart>1</showchart>
    <warning>0</warning>
    <decimalmode>2</decimalmode>
    <float>1</float>
    <mode>Absolute</mode>
    <speedtime>Second</speedtime>
    <volumesize>One</volumesize>
    <speedsize>One</speedsize>
    <unit>Custom</unit>
    <value>1.0</value>
    <channel>channel1</channel>
  </result>
  <text>Yo, working!</text>
</prtg>".Replace(" ", "").Replace("\r\n", "");

            var channel1 = new PrtgChannel();
            var channel2 = new PrtgChannel();
            channel1.Channel = "channel1";
            channel2.Channel = "channel2";
            channel1.Value = "1.0";
            channel2.Value = "2.0";
            var channels = new Collection<PrtgChannel> {channel1, channel2};

            var result = new PrtgResult { Text = "Yo, working!"};
            foreach (var c in channels)
            {
                result.Channels.Add(c);
            }

            using (var consoleOutput = new CatchConsoleOutput())
            {
                result.WriteOutput();
                var tmp = consoleOutput.GetOuput().Replace(" ", "").Replace("\r\n", "");
                Assert.AreEqual(test, tmp);
                //this is just needed for output
                Console.SetOut(consoleOutput.OriginalOutput);
                Console.WriteLine(tmp);
            }
        }
    }
}
