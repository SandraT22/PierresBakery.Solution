using System;

namespace PierresBakery
{
  public class Bread
  {
    public static int BreadPrice(int breadNum)
    {
      int breadPrice = 0;
      decimal num = Math.Floor((decimal) (breadNum/3));
      int decDealPrice = Decimal.ToInt32(num) *10;
      int dealPrice = (breadNum/3) * 10;
      int addPrice = (breadNum % 3) * 5;
        if (breadNum <= 2) {
        breadPrice = breadNum * 5;
        return breadPrice;
        } else if (breadNum % 3 == 0) {
        breadPrice = dealPrice;
          return breadPrice;
        } else if (breadNum % 3 > 0) {
        breadPrice = decDealPrice + addPrice; 
          return breadPrice;
        } else {
          return breadPrice;
        }
    }
  }
}