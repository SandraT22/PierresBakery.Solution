using System;

namespace PierresBakery
{
  public class Pastry
  {
    public static int PastryPrice(int pastryNum)
    {
      int pastryPrice = 0;
      decimal pNum = Math.Floor((decimal) (pastryNum/3));
      int pDecDealPrice = Decimal.ToInt32(pNum) * 5;
      int pDealPrice = (pastryNum/3) * 5; //(use method to round down)
      int pAddPrice = (pastryNum % 3) * 2;
      if (pastryNum <= 2) {
      pastryPrice = pastryNum * 2;
        return pastryPrice;
      } else if (pastryNum % 3 == 0) {
      pastryPrice = pDealPrice;
        return pastryPrice;
      } else if (pastryNum % 3 > 0) {
      pastryPrice = pDecDealPrice + pAddPrice; 
        return pastryPrice;
      } else {
        return pastryPrice;
      }
    }
  }
}