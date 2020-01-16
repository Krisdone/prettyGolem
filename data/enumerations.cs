
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

    public enum CryptoType
    {
        XXBT = 0,
        XETH = 1
        //XXRP = 2,
        //XXMR = 3,
        //XETC = 4
    }

    public enum OrderType
    {
        buy = 0,
        sell = 1,
    }
    
    public enum FiatType
    {
        ZUSD = 0
    }

    public enum TimeLine
    {
        fifteenMin = 0,
        thirtyMin = 1,
        oneHour = 2,
        twoHour = 3,
        fourHour = 4
    }

    public enum XBTPossiblePairs
    {
        ZUSD = 0,
        XETH = 1,
        XXRP = 2,
        XETC = 3,
        XXMR = 4
    }

    public enum ETHPossiblePairs
    {
        ZUSD = 0,
        XETC = 1,
    }
}
