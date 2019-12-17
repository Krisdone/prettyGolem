
using System;
using System.Collections.Generic;
using krakenAPI;
using currentTradeModel;
using crytpoEnums;

namespace populateTradingDetails
{
    public class PopulateTradingDetails
    {
        readonly KrakenUtils _KrakenUtils = new KrakenUtils();

        public TradeModel PopulateTM(CrytoType Ctype, FiatType Ftype)
        {
            TradeModel x = new TradeModel
            {
                TimeLoaded = DateTime.Now,
                Fiate = Ftype.ToString(),
                FiateBalance = _KrakenUtils.GetFiateBalance(Ftype),
                Crypto = Ctype.ToString(),
                CryptoCurrentPrice = _KrakenUtils.GetCyrptoPrice(Ctype),
                VWAPCurrentPrice = _KrakenUtils.GetCurrentVWAP(Ctype, Ftype),
                Trigger = false
                // trade details array gets populated when trade has been decided
            };

            return x;
        }

        public TradeDetails PopluateTD(CrytoType Ctype, FiatType Ftype, Leverage Ltype)
        {
            TradeDetails y = new TradeDetails()
            {
                TradeNumber = , // starts from 1
                TimeTradedOpened = ,
                TimeTradedClosed = ,
                Direction = Ftype,
                CType = Ctype,
                Leverage = Ltype
            };
            
            return y;

        }

    }

}
