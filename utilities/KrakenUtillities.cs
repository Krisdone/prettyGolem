/* helpfull API links below
 * https://www.kraken.com/features/api#example-api-code-cs
 * https://github.com/JKorf/Kraken.Net/blob/master/Kraken.Net/Kraken.Net.csproj
 * https://bitbucket.org/arrivets/krakenapi/src/master/README.txt
 * https://docs.microsoft.com/en-us/dotnet/standard/net-standard <-- helpfull chart of which .net frameworks support the other one *mind will explode*.
 */

using System;
using System.Data;
using Kraken.Net;
using crytpoEnums;
using System.Configuration;
using System.Web.Configuration;

namespace krakenAPI
{
    public class KrakenUtils
	{
        private readonly KrakenClient x = new KrakenClient();
        private readonly key = "";
        private readonly secret = "";

        public string PingKraken()
        {
            var y = x.Ping();
            return !y.Success.Equals("true") ? "": y.Error.ToString(); // TODO: It works but like wtf is happening here (sorry).
        }

        public decimal GetFiateBalance(FiatType Ftype)
        {
            x.SetApiCredentials(key, secret);
            return x.GetBalances().Data[Ftype.ToString()];
        }

        public int GetPossibleCyrptoTradeDetails(CryptoType Ctype, FiatType Ftype, XBTPossiblePairs Xtype, ETHPossiblePairs Etype)
        {
            if (Etype.ToString() != "-1")
            {
                var a = x.GetSymbols().Data[Etype.ToString() + Ctype.ToString()];
            } else if (Xtype.ToString() != "-1")
            {
                var b = x.GetSymbols().Data[Xtype.ToString() + Ctype.ToString()];
            } else
            {
                var a = x.GetSymbols().Data[Ctype.ToString() + Ftype.ToString()];
            }
            return 0;
        }

        public int GetCurrentVWAP(CryptoType Ctype, FiatType Ftype, TimeLine Tl)
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