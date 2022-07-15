using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryPastryTests
  {
    [TestMethod]
    public void PastryPrice_IndividualPrice_Int()
    {
      int pastryNum = 2;
      Assert.AreEqual(4, Pastry.PastryPrice(pastryNum));
    }

    [TestMethod]
    public void PastryPrice_DealPrice_Int()
    {
      int pastryNum = 3;
      Assert.AreEqual(5, Pastry.PastryPrice(pastryNum));
    }

    [TestMethod]
    public void PastryPrice_AddPrice_Int()
    {
      int pastryNum = 4;
      Assert.AreEqual(7, Pastry.PastryPrice(pastryNum));
    }
 }
}