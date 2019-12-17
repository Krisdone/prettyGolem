
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crytpoEnums;
using populateTradingDetails;

namespace Chaos 
{
    public class Chaos {

        public int Chaosify(int x)
        {
            return new Random().Next(0, x);
        }

        public void ChaosData()
        {           
            int CTypeRand = Chaosify(Enum.GetValues(typeof(CrytoType)).Cast<int>().Max());
            int FTypeRando = Chaosify(Enum.GetValues(typeof(FiatType)).Cast<int>().Max());
            int LTypeRando = CTypeRand.Equals((int) CrytoType.Monero) ? Chaosify((int) Leverage.three) : Chaosify((int) Leverage.five);

            var TMModel = new PopulateTradingDetails().PopulateTM((CrytoType)CTypeRand, (FiatType)FTypeRando);
            var percent = (TMModel.CryptoCurrentPrice - TMModel.VWAPCurrentPrice) / TMModel.VWAPCurrentPrice;
            TMModel.Trigger = percent >= .03 ? true : false; //TODO: calculate margin fees and add to value for trigger

            if (TMModel.Trigger == true)
            {
                new PopulateTradingDetails().PopluateTD((CrytoType)CTypeRand, (FiatType)FTypeRando, (Leverage)LTypeRando);
            }
        }
    }
}