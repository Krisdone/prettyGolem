
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crytpoEnums
{
    public enum Leverage
    {
        zero = 0,
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
    }

    public enum CrytoType
    {
        Bitcoin = 0,
        Ethereum = 1,
        Ripple = 2,
        Monero = 3,
    }
    
    public enum OrderType
    {
        buy = 0,
        sell = 1,
    }
    
    public enum FiatType
    {
        USD = 0,
        EUR = 1,
    }
 }
