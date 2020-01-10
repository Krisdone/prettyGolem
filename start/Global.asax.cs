using System;
using System.Web;
using krakenAPI;
using Chaos;

namespace start
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {

            Console.WriteLine("Attempting to connect to https://api.kraken.com");

            var c = new KrakenUtils().PingKraken();           

            if (!c.Equals(""))
            {
                Console.WriteLine(c);
                // TODO add text functionality (or iMessage preferably) with why it errored.
            }
            else
            {
                Console.WriteLine("Kraken is online, calling chaos module.");
                new Chaost().ChaosData();
            }

        }
    }
}