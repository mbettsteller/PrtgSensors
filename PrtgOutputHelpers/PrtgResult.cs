using System;
using System.Collections.ObjectModel;
using System.Xml.Linq;
using PrtgSensors.Properties;

namespace PrtgSensors
{
    public class PrtgResult
    {
        private Collection<PrtgChannel> channels = new Collection<PrtgChannel>();
        public Collection<PrtgChannel> Channels
        {
            get { return channels; }
            //set { channels = value; }
        }
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public void WriteOutput()
        {
            var prtg =
                new XElement("prtg",
                             new XElement("text", Text)
                    );

            foreach (var channel in Channels)
            {
                var nodelist = new Collection<XElement>();

                if (channel.Channel == null)
                {
                    PrtgError.WriteOutput(Resources.No_channel_name_was_defined);
                    return;
                }
                nodelist.Add(new XElement("channel", channel.Channel));
                nodelist.Add(new XElement("value", channel.Value));
                nodelist.Add(new XElement("unit", channel.Unit));
                if (channel.CustomUnit != null) nodelist.Add(new XElement("customunit", channel.CustomUnit));
                nodelist.Add(new XElement("speedsize", channel.SpeedSize));
                nodelist.Add(new XElement("volumesize", channel.VolumeSize));
                nodelist.Add(new XElement("speedtime", channel.SpeedTime));
                nodelist.Add(new XElement("mode", channel.Mode));
                nodelist.Add(new XElement("float", channel.Float));
                nodelist.Add(new XElement("decimalmode", channel.DecimalMode));
                nodelist.Add(new XElement("warning", channel.Warning));
                nodelist.Add(new XElement("showchart", channel.ShowChart));
                nodelist.Add(new XElement("showtable", channel.ShowTable));
                if (channel.LimitMaxError != null) nodelist.Add(new XElement("limitmaxerror", channel.LimitMaxError));
                if (channel.LimitMaxWarning != null) nodelist.Add(new XElement("limitmaxwarning", channel.LimitMaxWarning));
                if (channel.LimitMinWarning != null) nodelist.Add(new XElement("limitminwarning", channel.LimitMinWarning));
                if (channel.LimitMinError != null) nodelist.Add(new XElement("limitminerror", channel.LimitMinError));
                if (channel.LimitErrorMessage != null) nodelist.Add(new XElement("limiterrormsg", channel.LimitErrorMessage));
                if (channel.LimitWarningMessage != null) nodelist.Add(new XElement("limitwarningmsg", channel.LimitWarningMessage));
                nodelist.Add(new XElement("limitmode", channel.LimitMode));
                if (channel.ValueLookup != null) nodelist.Add(new XElement("valuelookup", channel.ValueLookup));


                var result = new XElement("result");
                foreach (var node in nodelist)
                {
                    result.AddFirst(node);
                }
                prtg.AddFirst(result);

            }//foreach
            Console.WriteLine(prtg);
        }//WriteOutput
    }
}