
using System;
using System.Linq;
using System.Threading;
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
            //TODO: Dynamically populate off what Kraken returns but for now I be hardcoding meh...
            // ^ Could potentially have problems with request allowance but wont know for sure unless I try...
            // The data I get back in my output is honestly too much and I need to clean it up coherently.

            int CTypeRand = Chaosify(Enum.GetValues(typeof(CryptoType)).Cast<int>().Max());

            //if (CTypeRand.Equals((int)CryptoType.XXMR) || CTypeRand.Equals((int)CryptoType.XETC) && FTypeRando.Equals((int)FiatType.ZUSD)) {
            //   LTypeRando = Chaosify((int)Leverage.two);
            //}
            //else if (CTypeRand.Equals((int)CryptoType.XXBT)) {
            //    if (FTypeRando.Equals((int)CryptoType.XXMR)) {
            //        LTypeRando = Chaosify((int)Leverage.three); // double check value
            //    } else if (FTypeRando.Equals((int)CryptoType.XETC) {
            //        LTypeRando = Chaosify((int)Leverage.three); // double check value
            //    } else {
            //        
            //    }
            //} else if (CTypeRand.Equals((int)CryptoType.XETH)) {
            //    LTypeRando =
            //} else {
            //    LTypeRando = Chaosify((int)Leverage.five);
            //}

            // Completely eraticate bias (almost) for loading your choice crypto enumerations, also my english is getting worse the more I learn German.
            int FTypeRando = -1;
            int Xtype = -1;
            int Etype = -1;
            int LTypeRando = Chaosify((int)Leverage.five);
            
            if (CTypeRand.Equals((int)CryptoType.XXBT)) {
                Xtype = Chaosify(Enum.GetValues(typeof(XBTPossiblePairs)).Cast<int>().Max());
            } else if (CTypeRand.Equals((int)CryptoType.XETH)) {
                Etype = Chaosify(Enum.GetValues(typeof(ETHPossiblePairs)).Cast<int>().Max());
            } else {
                FTypeRando = Chaosify(Enum.GetValues(typeof(FiatType)).Cast<int>().Max());
            }

            int TlRando = Chaosify(Enum.GetValues(typeof(TimeLine)).Cast<int>().Max());

            Console.WriteLine("Chaos module is attempting to populate the trading model.");

            var TMModel = new PopulateTradingDetails().PopulateTM((CryptoType)CTypeRand, (FiatType)FTypeRando, (TimeLine)TlRando, (XBTPossiblePairs)Xtype, (ETHPossiblePairs) Etype);

            // This is where we say, "Get the data and set trigger for making a trade based on your criteria".
            // Below I just use VWAP.
            var percent = (TMModel.CryptoCurrentPrice - TMModel.VWAPCurrentPrice) / TMModel.VWAPCurrentPrice;

            if (TMModel.Trigger = percent >= .04 ? true : false) 
            {
                // make the kraken trade with variables declared in chaos from utilities and populate model below
                // set sell or buy order
                // set sell or buy order
                var x = new PopulateTradingDetails().PopluateTD((CryptoType)CTypeRand, (FiatType)FTypeRando, (Leverage)LTypeRando);

                while (string.IsNullOrEmpty(x.TimeTradedClosed.ToString())) { //TODO: Goal is to get breakpoint getting here hit essentially.
                    Thread.Sleep(30000);
                    // if it is closed populate TD model
                    // null out all TM values and call ChaosData()
                }
            }
        }
    }
}