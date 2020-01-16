
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

        public TradeModel PopulateTM(CryptoType Ctype, FiatType Ftype, TimeLine Tl, XBTPossiblePairs Xtype, ETHPossiblePairs Etype)
        {
            TradeModel x = new TradeModel
            {
                TimeLoaded = timestamp,
                Fiate = Ftype,
                FiateBalance = _KrakenUtils.GetFiateBalance(FiatType.ZUSD), 
                Crypto = Ctype,
                CryptoCurrentPrice = _KrakenUtils.GetPossibleCyrptoTradeDetails(Ctype, Ftype, Xtype, Etype),
                VWAPCurrentPrice = _KrakenUtils.GetCurrentVWAP(Ctype, Ftype, Tl),
                Trigger = false
                // trade details array gets populated when trade has been decided
            };

            return x;
        }

        public TradeDetails PopluateTD(CryptoType Ctype, FiatType Ftype, Leverage Ltype)
        {
            TradeDetails y = new TradeDetails()
            {
                TradeNumber = _KrakenUtils.GetTradeID(), // starts from 1
                TimeTradedOpened = _KrakenUtils.GetTradeDetails(),
                TimeTradedClosed = _KrakenUtils.GetTradeDetails(),
                Direction = OrderType.buy,
                CType = Ctype,
                Leverage = Ltype
            };
            
            return y;
        }

    }

}
