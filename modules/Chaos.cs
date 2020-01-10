
using System;
using System.Linq;
using crytpoEnums;
using populateTradingDetails;

namespace Chaos
{
    public class Chaost {

        public int Chaosify(int x)
        {
            return new Random().Next(0, x);
        }

        public void ChaosData()
        {           
            int CTypeRand = Chaosify(Enum.GetValues(typeof(CrytoType)).Cast<int>().Max());
            int FTypeRando = Chaosify(Enum.GetValues(typeof(FiatType)).Cast<int>().Max());
            int LTypeRando = CTypeRand.Equals((int) CrytoType.Monero) ? Chaosify((int) Leverage.three) : Chaosify((int) Leverage.five);
            int Tl  = Chaosify(Enum.GetValues(typeof(TimeLine)).Cast<int>().Max());

            Console.WriteLine("Attempting to Populate Trading Module.");

            var TMModel = new PopulateTradingDetails().PopulateTM((CrytoType)CTypeRand, (FiatType)FTypeRando, (TimeLine) Tl);
            var percent = (TMModel.CryptoCurrentPrice - TMModel.VWAPCurrentPrice) / TMModel.VWAPCurrentPrice;

            TMModel.Trigger = percent >= .04 ? true : false; //TODO: calculate margin fees and add to value for trigger

            if (TMModel.Trigger == true)
            {
                // make the kraken trade with variables declared in chaos from utilities and populate model below
                // set sell or buy order
                // set sell or buy order
                var x = new PopulateTradingDetails().PopluateTD((CrytoType)CTypeRand, (FiatType)FTypeRando, (Leverage)LTypeRando);

                while (string.IsNullOrEmpty(x.TimeTradedClosed.ToString())) {
                    // check trade status every 30 seconds
                    // if it is closed populate TD model
                    //null out all TM values and call ChaosData()
                }
            }
        }
    }
}