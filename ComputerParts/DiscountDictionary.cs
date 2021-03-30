using System.Collections.Generic;

namespace ComputerPartsLibrary
{
    internal static class DiscountDictionary
    {
        // string: discount code, int: discount percentage
        private static Dictionary<string, int> Discounts = new Dictionary<string, int>()
        {
            { "JyWM0pkwnI", 5 },
            { "YX8U3ZEryP", 5 },
            { "2jdRLAli2m", 10 },
            { "dEHv3aPVuU", 10 },
            { "uMpCPXzexG", 15 },
            { "nVzlGnaTuu", 15 },
            { "HVWQrEf1jU", 20 },
            { "MbBT2m9Lvb", 20 },
            { "h7xSGOAo93", 25 },
            { "RvG3zAeJdm", 25 },
            { "BKUMpdOrH5", 30 }
        };

        internal static bool CouponCheck(string coupon, out int discount) => Discounts.TryGetValue(coupon, out discount);

    }
}
