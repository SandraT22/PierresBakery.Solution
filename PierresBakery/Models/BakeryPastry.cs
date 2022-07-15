using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Pastry
  {
    public int pastryPrice { get; set; }
    public Pastry(int price) {
      pastryPrice = price;
    }
    public void SetPastryPrice(int pastryNum)
    {
      decimal pNum = Math.Floor((decimal) (pastryNum/3));
      int pDecDealPrice = Decimal.ToInt32(pNum) * 5;
      int pDealPrice = (pastryNum/3) * 5; 
      int pAddPrice = (pastryNum % 3) * 2;
      if (pastryNum <= 2) {
      pastryPrice = pastryNum * 2;
      } else if (pastryNum % 3 == 0) {
      pastryPrice = pDealPrice;
      } else if (pastryNum % 3 > 0) {
      pastryPrice = pDecDealPrice + pAddPrice; 
      } 
    }
  }
}