using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Bread;
using Bakery.Pastry;
namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_InitializesBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(bread), newBread.GetType());
    }
  }
}