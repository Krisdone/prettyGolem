using System;
using System.Web;
using krakenAPI;
using System.Threading;
using Chaos;

namespace start
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            try
            {
                var timestamp = DateTime.Now;
                Console.WriteLine("Attempting to connect to https://api.kraken.com @: " + timestamp + ".");
                var c = new KrakenUtils().PingKraken();

                if (!c.Equals(""))
                {
                    Console.WriteLine(c);
                    Thread.Sleep(5050); // Since they only allow 5 (or do they?) sec we give ourself a 50 milli-sec buffer :/
                    Application_Start();
                }
                else
                {
                    Console.WriteLine("Kraken is online.");
                    Console.WriteLine("Calling Chaos Module.");
                    new Chaost().ChaosData();
                }

            } catch(Exception e) // TODO: add text functionality (or iMessage preferably) with why it errored ...
            {
                Console.WriteLine(e);
                Application_Start();
            }
        }
    }
}