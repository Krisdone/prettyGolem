
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
            return new Random().Next(0, x + 1);
        }

        public void ChaosData()
        {
            int CTypeRand = Chaosify(Enum.GetValues(typeof(CryptoType)).Cast<int>().Max());
            int FTypeRando = -1; int Xtype = -1; int Etype = -1;
            int LTypeRando = 2; //Chaosify((int)Leverage.five);
            
            if (CTypeRand.Equals((int)CryptoType.XXBT)) {
                Xtype = Chaosify(Enum.GetValues(typeof(XBTPossiblePairs)).Cast<int>().Max());
            } else if (CTypeRand.Equals((int)CryptoType.XETH)) {
                Etype = Chaosify(Enum.GetValues(typeof(ETHPossiblePairs)).Cast<int>().Max());
            } else {
                FTypeRando = Chaosify(Enum.GetValues(typeof(FiatType)).Cast<int>().Max());
            }

            int TlRando = 2; // Hard coding 2 for now -> Chaosify(Enum.GetValues(typeof(TimeLine)).Cast<int>().Max());
            var TMModel = new PopulateTradingDetails().PopulateTM((CryptoType)CTypeRand, (FiatType)FTypeRando, (TimeLine)TlRando, (XBTPossiblePairs)Xtype, (ETHPossiblePairs) Etype);
            var percentAverage = (TMModel.CryptoCurrentPrice - TMModel.VWAPCurrentAveragePrice) / TMModel.VWAPCurrentAveragePrice;
            var percentShortTime = (TMModel.CryptoCurrentPrice - TMModel.VWAPCurrent24HRolling) / TMModel.VWAPCurrent24HRolling;
            var percentBigTime = (TMModel.CryptoCurrentPrice - TMModel.VWAPCurrentDaily) / TMModel.VWAPCurrentDaily;

            Console.Write(TMModel.TradePairName + ", percentAverage: " + (Math.Round(percentAverage, 6) * 100) + "%"
                                                + ", percentShortTime: " + (Math.Round(percentShortTime, 6) * 100) + "%"
                                                + ", percentBigTime: " + (Math.Round(percentBigTime, 6) * 100) + "%"
                                                + "%, price: " + TMModel.CryptoCurrentPrice + ".\n");

            if (TMModel.Trigger = percentAverage >= 0.05m || percentAverage <= -0.5m  ? true : false) 
            {
                Console.WriteLine("Criteria met -> Choas module is attempting to trade:" + TMModel.TradePairName +  ".\n");
                var x = new PopulateTradingDetails().PopluateTD(TMModel.TradePairName, (Leverage)LTypeRando, percentAverage, TMModel.CryptoCurrentPrice);
                var timer = 0; var thirtySeconds = 30000; var sixHours = 21600000;

                while (string.IsNullOrEmpty(x.TimeTradedClosed.ToString())) { 
                    Thread.Sleep(thirtySeconds);
                    timer += thirtySeconds;
                    var done = sixHours == timer ? 1 : 2 ; // TODO:goal to get here
                }
                ChaosData();
            }
        }
    }
}