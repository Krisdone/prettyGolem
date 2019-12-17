using System.Web;
using System;
using krakenAPI;

namespace start
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {

            Console.WriteLine("Attempting to connect to https://api.kraken.com");

            var c = new KrakenUtils().ConnectKraken();

            if (c.Equals(""))
            {
                Console.WriteLine(c);
                // TODO add text functionality (or iMessage preferably) with why it errored.
            }
            else
            {
                Console.WriteLine("Connected");
                
            }

        }
    }
}