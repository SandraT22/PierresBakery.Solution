using System;
using System.Collections.Generic;

namespace PierresBakery
{
  public class Bread
  {
    public int breadPrice { get; set; }
    public string breadName { get; set; }
    public Bread( int price, string name) {
      breadPrice = price;
      breadName = name;
    }
    public void SetBreadPrice(int breadNum)
    {
      decimal num = Math.Floor((decimal) (breadNum/3));
      int decDealPrice = Decimal.ToInt32(num) *10;
      int dealPrice = (breadNum/3) * 10;
      int addPrice = (breadNum % 3) * 5;
        if (breadNum <= 2) {
        breadPrice = breadNum * 5;
        } else if (breadNum % 3 == 0) {
        breadPrice = dealPrice;
        } else if (breadNum % 3 > 0) {
        breadPrice = decDealPrice + addPrice; 
        } 
    }
  }
}