using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Cache;
using PrtgSensors.Properties;

namespace PrtgSensors
{
    class XHeaderCheck
    {
        private static void Main(string[] args)
        {
            string url = null;
            string[] headers = null;
            string proxy = null;

            if (args.Length < 2)
            {
                Console.WriteLine(Resources.usage +
                                  Process.GetCurrentProcess().ProcessName + Resources.XHeaderCheck_usage);
#if DEBUG
                Console.ReadKey();
#endif
                return;
            }

            foreach (var arg in args)
            {
                if (arg.ToUpper().StartsWith("-URL:"))
                {
                    url = arg.Substring(arg.IndexOf(':') + 1);
                }
                if (arg.ToUpper().StartsWith("-HEADERS:"))
                {
                    headers = arg.Split(':')[1].Split(',');
                }
                if (arg.ToUpper().StartsWith("-PROXY:"))
                {
                    proxy = arg.Substring(arg.IndexOf(':') + 1);
                }
            }
            var nvc = GetEndpoint(url, proxy, headers);
            if (nvc.AllKeys.Contains(Resources.PRTGError))
            {
                PrtgError.WriteOutput(nvc[Resources.PRTGError]);
            }
            else
            {
                var channels = new Collection<PrtgChannel>();
                foreach (var key in nvc.AllKeys)
                {
                    var channel = new PrtgChannel { Channel = key, Value = nvc[key], CustomUnit = "ms" };
                    channels.Add(channel);
                    //Console.WriteLine(key+"="+nvc[key]);
                }
                var result = new PrtgResult { Text = "OK" };
                foreach (var prtgChannel in channels)
                {
                    result.Channels.Add(prtgChannel);
                }
                result.WriteOutput();
            }
#if DEBUG
            Console.ReadKey();
#endif
        }

        private static NameValueCollection GetEndpoint(string url, string proxy, IEnumerable<string> headers)
        {
            var result = new NameValueCollection();
            result.Set(Resources.PRTGError, Resources.No_URL_specified_);
            if (url == null) return result;
            var request = (HttpWebRequest)WebRequest.Create(url);
            if (proxy != null) request.Proxy = new WebProxy(proxy);
            request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.AllowAutoRedirect = true;

            var response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                result.Clear();
                foreach (var header in headers)
                {
                    var value = response.Headers[header];
                    if (value != null) result.Set(header, value);
                    else
                    {
                        result.Clear();
                        result.Set(Resources.PRTGError, Resources.The_expected_header_ + header + Resources.could_not_be_found_);
                        break; //no more checking, one error kills the checking and send an error
                    }
                }
            }
            else
            {
                result.Clear();
                result.Set(Resources.PRTGError, response.StatusCode + " " + response.StatusDescription.ToString(CultureInfo.InvariantCulture));
            }
            return result;
        }
    }
}
