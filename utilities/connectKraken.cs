/* helpfull API link below
 * https://www.kraken.com/features/api#example-api-code-cs
 * https://github.com/JKorf/Kraken.Net/blob/master/Kraken.Net/Kraken.Net.csproj
 * https://bitbucket.org/arrivets/krakenapi/src/master/README.txt
 * https://docs.microsoft.com/en-us/dotnet/standard/net-standard <-- helpfull chart of which .net frameworks support the other ones. 
 */

using System;
using System.Collections.Generic;
using Kraken.Net;
using crytpoEnums;

namespace krakenAPI
{
    public class KrakenUtils
	{
        public string ConnectKraken()
        { 
            return "";
        }

        public string CloseKraken()
        {
            return "";
        }

        public int GetFiateBalance(FiatType Ftype)

        {
            //var ticker = client.GetTicker(new List<string> { "ETHUSD" });
            //Console.WriteLine("");
            //_ = new KrakenClient();
            return 0;
        }

        public int GetCyrptoPrice(CrytoType Ctype)
        {
            return 0;
        }

        public int GetCurrentVWAP(CrytoType Ctype, FiatType Ftype)
        {
            return 0;
        }

    }

}
