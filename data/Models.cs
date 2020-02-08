
using System;
using crytpoEnums;

namespace currentTradeModel
{
    public class PotentialTradeModel
	{
        public DateTime TimeLoaded { get; set; }
        public FiatType Fiate { get; set; }
        public decimal FiateBalance { get; set; }
        public string TradePairName { get; set; }
        public decimal CryptoCurrentPrice { get; set; }
        public decimal VWAPCurrentAveragePrice { get; set; }
        public decimal VWAPCurrent24HRolling { get; set; }
        public decimal VWAPCurrentDaily { get; set; }
        public bool Trigger { get; set; }
        public TradeDetails[] TradeDetails { get; set; }
    }
    
    public class TradeDetails
    {
        public string TradePairName { get; set; }
        public DateTime TimeTradedOpened { get; set; }
        public DateTime TimeTradedClosed { get; set; }
        public OrderSide Direction { get; set; }
        public FiatType FType { get; set; }
        public CryptoType CType { get; set; }
        public Leverage Leverage { get; set; }
    }
}
