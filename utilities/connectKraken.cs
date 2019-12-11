/* helpfull links below 
 * https://www.kraken.com/features/api#ws-auth
 * https://github.com/m4cx/kraken-wsapi-dotnet <-- TODO: buy him coffee :)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;


namespace krakenAPI
{
    public class connect
    {
		var client = KrakenApi.ClientFactory.Create("wss://ws-beta.kraken.com");
        
	}
}
