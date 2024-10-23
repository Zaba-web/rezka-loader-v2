using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace rezka_loader_v2
{
    internal class CheckResult
    {
        public string country_iso { get; set; }
        public string asn_org { get; set;}
    }

    internal class IPService
    {
        private const String SERVICE_URL = "https://ifconfig.net/";

        private const String CLOUDFLARE = "CLOUDFLARENET";

        private static readonly String[] BLOCKED_IN = { "UA" };

        public static bool IsAvailable()
        {
            var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = System.Net.DecompressionMethods.GZip });
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var json = client.GetStringAsync(SERVICE_URL).Result;

            CheckResult res = JsonConvert.DeserializeObject<CheckResult>(json);

            if (BLOCKED_IN.Contains(res.country_iso) && res.asn_org != CLOUDFLARE)
            {
                return false;
            }

            return true;
        }
    }
}
