
using System;
using krakenAPI;
using currentTradeModel;
using crytpoEnums;

namespace populateTradingDetails
{
    public class PopulateTradingDetails
    {
        private readonly KrakenUtils _KrakenUtils = new KrakenUtils();
        private readonly DateTime timestamp = DateTime.Now;

        public PotentialTradeModel PopulateTM(CryptoType Ctype, FiatType Ftype, TimeLine Tl, XBTPossiblePairs Xtype, ETHPossiblePairs Etype)
        {
            var symbol = GetTradedPairName(Ctype, Ftype, Xtype, Etype);

            PotentialTradeModel x = new PotentialTradeModel
            {
                TimeLoaded = timestamp,
                Fiate = Ftype,
                FiateBalance = _KrakenUtils.GetFiateBalance(FiatType.ZUSD),
                TradePairName = symbol,
                CryptoCurrentPrice = _KrakenUtils.GetTradedPairPrice(symbol),
                VWAPCurrentAveragePrice = _KrakenUtils.GetCurrentVWAPAverage(symbol),
                VWAPCurrent24HRolling = _KrakenUtils.GetCurrentVWAP24Hrolling(symbol),
                VWAPCurrentDaily = _KrakenUtils.GetCurrentVWAPAverageValueToday(symbol),
                Trigger = false
            };

            return x;
        }

        public TradeDetails PopluateTD(string TradedPairName, Leverage Ltype, decimal percent, decimal price)
        {
            TradeDetails y = new TradeDetails()
            {
                TradePairName = TradedPairName,
                //TimeTradeOpened = _KrakenUtils.MakeTrade(TradedPairName),
                //FailureLimitTimeSet = _KrakenUtils.MakeTrade(TradedPairName),
                //SuccessLimitTimeSet = _KrakenUtils.GetTradeDetails(),
                Direction = percent > 0 ? OrderSide.buy : OrderSide.sell,
                Leverage = Ltype
            };
            
            return y;
        }

        public string GetTradedPairName(CryptoType Ctype, FiatType Ftype, XBTPossiblePairs Xtype, ETHPossiblePairs Etype)
        {
            if (Etype.ToString() != "-1")
            {
                return !Etype.ToString().Equals("ZUSD") ? Etype.ToString() + Ctype.ToString() : Ctype.ToString() + Etype.ToString();

            }
            else if (Xtype.ToString() != "-1" && !Xtype.ToString().Equals("BCH"))
            {
                return !Xtype.ToString().Equals("ZUSD") ? Xtype.ToString() + Ctype.ToString() : Ctype.ToString() + Xtype.ToString();
            }
            else
            {
                return "BCHXBT";
            }
        }
    }
}
