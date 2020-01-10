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
                Console.WriteLine("Attempting to connect to https://api.kraken.com @: " + DateTime.Now + ".");
                var c = new KrakenUtils().PingKraken();

                if (!c.Equals(""))
                {
                    Console.WriteLine(c);
                    Thread.Sleep(5005); // Since they only allow 5 sec we give ourself a 5 milisecond buffer.
                    Application_Start();
                }
                else
                {
                    //Console.WriteLine("Kraken is online, calling chaos module.");
                    //new Chaost().ChaosData();
                    Console.WriteLine("Kraken is online and credentials are set.");
                }

            } catch(Exception e) // TODO: add text functionality (or iMessage preferably) with why it errored.
            {
                Console.WriteLine(e);
                Application_Start();
            }
        }
    }
}