
using System;
using krakenAPI;
using currentTradeModel;
using crytpoEnums;

namespace populateTradingDetails
{
    public class PopulateTradingDetails
    {
        readonly KrakenUtils _KrakenUtils = new KrakenUtils();

        public TradeModel PopulateTM(CrytoType Ctype, FiatType Ftype, TimeLine Tl)
        {
            TradeModel x = new TradeModel
            {
                TimeLoaded = DateTime.Now, 
                Fiate = Ftype.ToString(),
                FiateBalance = _KrakenUtils.GetFiateBalance(Ftype),
                Crypto = Ctype.ToString(),
                CryptoCurrentPrice = _KrakenUtils.GetCyrptoPrice(Ctype),
                VWAPCurrentPrice = _KrakenUtils.GetCurrentVWAP(Ctype, Ftype, Tl),
                Trigger = false
                // trade details array gets populated when trade has been decided
            };

            return x;
        }

        public TradeDetails PopluateTD(CrytoType Ctype, FiatType Ftype, Leverage Ltype)
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
