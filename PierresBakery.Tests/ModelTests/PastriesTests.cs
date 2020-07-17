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
      Pastries testPastry = new Pastries();
      Assert.AreEqual(typeof(Pastries), testPastry.GetType());
    }
  }
}