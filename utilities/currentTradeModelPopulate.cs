
using System;
using System.Collections.Generic;
using krakenAPI;
using currentTradeModel;
using crytpoEnums;

namespace populateTradingDetails
{
    public class PopulateTradingDetails
    {

        public TradeModel PopulateTM()
        {
            TradeModel x = new TradeModel
            {
                TimeLoaded = DateTime.Now,
                USDBalance = ,
                EthCurrentPrice = ,
                VWAPCurrentPrice = ,
                Trigger = false
                // trade details array gets populated when trade has been decided
            };

            return x;
        }

        public TradeDetails PopluateTD()
        {
            TradeDetails y = new TradeDetails()
            {
                TradeNumber = , // starts from 1
                TimeTradedOpened = ,
                TimeTradedClosed = ,
                Direction = ,
                CType =
                // leverage logic TBC
            };
            
            return y;

        }

    }

}
