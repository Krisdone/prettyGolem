/* helpfull API links below
 * https://www.kraken.com/features/api#example-api-code-cs
 * https://github.com/JKorf/Kraken.Net/blob/master/Kraken.Net/Kraken.Net.csproj
 * https://bitbucket.org/arrivets/krakenapi/src/master/README.txt
 * https://docs.microsoft.com/en-us/dotnet/standard/net-standard <-- helpfull chart of which .net frameworks support the other ones. 
 */

using System;
using Kraken.Net;
using crytpoEnums;
using System.Web.Configuration;

namespace krakenAPI
{
    public class KrakenUtils
	{
        private readonly KrakenClient x = new KrakenClient();
        private readonly WebConfigurationManager key = WebConfigurationManager.GetSection("KrakenKey") as WebConfigurationManager;
        private readonly WebConfigurationManager secret = WebConfigurationManager.GetSection("KrakenSecret") as WebConfigurationManager;

        public string PingKraken()
        {
            var y = x.Ping();
            return String.IsNullOrEmpty(y.Error.ToString()) && y.Success.Equals("true") ?  "": y.Error.ToString();

        }

        public int GetFiatBalance(FiatType Ftype)

        {
            x.SetApiCredentials(key, secret);
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