
using System;
using crytpoEnums;

namespace currentTradeModel
{
    public class TradeModel
	{
        public DateTime TimeLoaded { get; set; }
        public FiatType Fiate { get; set; }
        public decimal FiateBalance { get; set; }
        public CryptoType Crypto { get; set; }
        public int CryptoCurrentPrice { get; set; }
        public int VWAPCurrentPrice { get; set; }
        public bool Trigger { get; set; }
        public TradeDetails[] TradeDetails { get; set; }

    }
    
    public class TradeDetails
    {
        public int TradeNumber { get; set; }
        public DateTime TimeTradedOpened { get; set; }
        public DateTime TimeTradedClosed { get; set; }
        public OrderType Direction { get; set; }
        public FiatType FType { get; set; }
        public CryptoType CType { get; set; }
        public Leverage Leverage { get; set; }
    }
}
