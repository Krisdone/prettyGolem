/* helpfull API links below
 * https://www.kraken.com/features/api#example-api-code-cs
 * https://github.com/JKorf/Kraken.Net/blob/master/Kraken.Net/Kraken.Net.csproj
 * https://bitbucket.org/arrivets/krakenapi/src/master/README.txt
 * https://docs.microsoft.com/en-us/dotnet/standard/net-standard <-- helpfull chart of which .net frameworks support the other ones. 
 */

using System;
using Kraken.Net;
using crytpoEnums;
using System.Configuration;
using System.Web.Configuration;

namespace krakenAPI
{
    public class KrakenUtils
	{
        private readonly KrakenClient x = new KrakenClient();
        private readonly string key = WebConfigurationManager.GetSection("KrakenKey") as string;
        private readonly string secret = WebConfigurationManager.GetSection("KrakenSecret") as string;

        public string PingKraken()
        {
            var y = x.Ping();
            SetAPICredentials();
            return String.IsNullOrEmpty(y.Error.ToString()) && y.Success.Equals("true") ?  "": y.Error.ToString();
        }

        private void SetAPICredentials()
        {
            x.SetApiCredentials(key, secret);
        }

        public int GetFiateBalance(FiatType Ftype)
        {
            return 0;
        }

        public int GetCyrptoPrice(CrytoType Ctype)
        {
            return 0;
        }

        public int GetCurrentVWAP(CrytoType Ctype, FiatType Ftype, TimeLine Tl)
        {
            return 0;
        }

        public int GetTradeID()
        {
            return 0;
        }

        public DateTime GetTradeDetails()
        {
            return DateTime.Now;
        }
    }
}