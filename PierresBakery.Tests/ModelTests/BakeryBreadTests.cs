using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BakeryBreadTests
  {
    [TestMethod]
    public void BreadPrice_IndividualPrice_Int()
    {
      int breadNum = 2;
      Assert.AreEqual(10, Bread.BreadPrice(breadNum)); 
    }

    [TestMethod]
    public void BreadPrice_DealPrice_Int()
    {
      int breadNum = 3;
      Assert.AreEqual(10, Bread.BreadPrice(breadNum));
    }

    [TestMethod]
    public void BreadPrice_AddPrice_Int()
    {
      int breadNum = 4;
      Assert.AreEqual(15, Bread.BreadPrice(breadNum));
    }
  }
}