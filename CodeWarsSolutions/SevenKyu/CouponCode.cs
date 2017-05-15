using System;

namespace CodeWarsSolutions.SevenKyu
{
    public class CouponCode
    {
          public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate) =>
            (enteredCode != correctCode) ? false : Convert.ToDateTime(currentDate) <= Convert.ToDateTime(expirationDate);
    }
}
