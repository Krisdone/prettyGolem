/* helpfull API links below
 * https://www.kraken.com/features/api#example-api-code-cs
 * https://github.com/JKorf/Kraken.Net/blob/master/Kraken.Net/Kraken.Net.csproj
 * https://bitbucket.org/arrivets//src/master/README.txt
 * https://docs.microsoft.com/en-us/dotnet/standard/net-standard <-- helpfull chart of which .net frameworks support the other ones *mind will explode*.
 * https://stackoverflow.com/questions/48744124/getting-the-latest-pair-value-with-kraken-api
*/

using System;
using System.Data;
using Kraken.Net;
using crytpoEnums;
using System.Configuration;
using System.Web.Configuration;
using System.Collections.Generic;
using System.IO;

namespace krakenAPI
{
    public class KrakenUtils
	{
        private readonly KrakenClient x = new KrakenClient();
        private string _key;
        private string _secret;
        private string _path = "/Users/Kris/Projects/prettyGolem/utilities";
        private readonly string key = "yourKeyHere";
        private readonly string secret = "yourSecretHere";

        public void SetCredentials()
        {
            var webConfigurationFileMap = new WebConfigurationFileMap();           
            webConfigurationFileMap.VirtualDirectories.Add(_path, new VirtualDirectoryMapping(_path, isAppRoot: true));           
            var webConfig = WebConfigurationManager.OpenMappedWebConfiguration(webConfigurationFileMap, string.Empty);

            var map = new ExeConfigurationFileMap { ExeConfigFilename = @_path};
            var configfile = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            var test = WebConfigurationManager.AppSettings[""];
            var a = webConfig.GetSection("appSettings");
            //TODO: get this working so I dont have to hardcode the key and secret...
            //_secret = ConfigurationManager.AppSettings["KrakenSecret"];      
        }
            
        public string PingKraken()
        {
            SetCredentials();
            var y = x.Ping();
            return !y.Success.Equals("true") ? "": y.Error.ToString();
        }

        public decimal GetFiateBalance(FiatType Ftype)
        {
            //SetCredentials(); // var a = x.GetSymbols(); // Gets available trading pairs.
            x.SetApiCredentials(key, secret);
            return x.GetBalances().Data[Ftype.ToString()];
        }

        public decimal GetTradedPairPrice(string symbol)
        {
            return x.GetTickers(new System.Threading.CancellationToken(), symbol).Data[symbol].Open;
        }

        public decimal GetCurrentVWAPAverage(string symbol)
        {
            var a = x.GetTickers(new System.Threading.CancellationToken(), symbol).Data[symbol].VolumeWeightedAveragePrice.ValueToday;
            var b = x.GetTickers(new System.Threading.CancellationToken(), symbol).Data[symbol].VolumeWeightedAveragePrice.Value24H;
            return (a + b) / 2;
        }

        public decimal GetCurrentVWAP24Hrolling(string symbol)
        {
            return x.GetTickers(new System.Threading.CancellationToken(), symbol).Data[symbol].VolumeWeightedAveragePrice.Value24H; ;
        }
 
        public decimal GetCurrentVWAPAverageValueToday(string symbol)
        {
            return x.GetTickers(new System.Threading.CancellationToken(), symbol).Data[symbol].VolumeWeightedAveragePrice.ValueToday;
        }

        public string MakeTrade(string TradedPairName, OrderSide Otype, decimal TradedPairPrice, decimal avilableFunds,
            Leverage Ltype)
        {
            int volume = Convert.ToInt32(Math.Floor(avilableFunds / TradedPairPrice));
            //x.PlaceOrder(TradedPairName, Otype, "limit", TradedPairPrice, volume, Ltype);
            return "";
        }

        public DateTime GetTradeDetails()
        {
            return DateTime.Now;
        }
    }
}