using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace BakeryBread.Tests
{
  [TestClass]
  public class BakeryBreadTests
  {
    [TestMethod]
    public void BreadPrice_IndividualPrice_Int()
    {
      int breadNum = 2;
      Assert.AreEqual(10, bread.BreadPrice(breadNum)); 
    }
  }
}