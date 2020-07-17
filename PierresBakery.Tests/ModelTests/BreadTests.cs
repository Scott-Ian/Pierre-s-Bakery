using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadCOnstructor_CreatesInstanceOfBread_BreadObject()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), testBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadWithBreadCout_Int()
    {
      Bread testBread = new Bread(3);
      Assert.AreEqual(3, testBread.BreadCount);
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfOrder_Int()
    {
      Bread testBread = new Bread(1);
      Assert.AreEqual(5, testBread.Cost());
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfOrderWithDiscount_Int()
    {
      Bread testBread = new Bread(6);
      Assert.AreEqual(20, testBread.Cost());
    }
  }
}