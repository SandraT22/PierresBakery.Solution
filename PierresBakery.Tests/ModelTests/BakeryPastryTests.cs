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
 }
}