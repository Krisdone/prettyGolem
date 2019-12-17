
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crytpoEnums;

namespace currentTradeModel
{
    public class TradeModel
	{
        public DateTime TimeLoaded { get; set; }
        public string Fiate { get; set; }
        public int FiateBalance { get; set; }
        public string Crypto { get; set; }
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
        public CrytoType CType { get; set; }
        public Leverage Leverage { get; set; }
    }
}
