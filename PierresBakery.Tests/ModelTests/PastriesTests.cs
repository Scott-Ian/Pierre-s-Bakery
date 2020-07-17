using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastriesTests
  {
    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastries_PastriesObject()
    {
      Pastries testPastry = new Pastries(3);
      Assert.AreEqual(typeof(Pastries), testPastry.GetType());
    }

    [TestMethod]
    public void PastriesConstructor_CreatesInstanceOfPastriesWithPastryCount_Int()
    {
      Pastries testPastry = new Pastries(3);
      Assert.AreEqual(3, testPastry.PastryCount);
    }

    [TestMethod]
    public void Cost_ReturnsPriceOfOrder_Int()
    {
      Pastries testPastry = new Pastries(3);
      Assert.AreEqual(6, testPastry.Cost());
    }

  }
}