/* helpfull API link below
 * https://www.kraken.com/features/api#example-api-code-cs
 * https://bitbucket.org/arrivets/krakenapi/src/master/README.txt
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using KrakenClient;
using Jayrock.Json;
using Jayrock.Json.Conversion;

namespace krakenAPI
{
    public class krakenUtils
	{
        public ethGetPrice()
		{
			var ticker = client.GetTicker(new List<string> { "ETHUSD" });
			Console.WriteLine("");
		}

	}

}
