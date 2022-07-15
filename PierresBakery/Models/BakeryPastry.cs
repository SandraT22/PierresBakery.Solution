using System;

namespace PierresBakery
{
  public class Pastry
  {
    public static int PastryPrice(int pastryNum)
    {
      int pastryPrice = 0;
      int pDealPrice = (pastryNum/3) * 5; //(use method to round down)
      if (pastryNum <= 2) {
      pastryPrice = pastryNum * 2;
        return pastryPrice;
      } else if (pastryNum % 3 == 0) {
      pastryPrice = pDealPrice;
        return 0;
      } else {
        return pastryPrice;
      }
    }
  }
}