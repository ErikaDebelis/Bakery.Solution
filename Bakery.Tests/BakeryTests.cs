using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Breads;
using Bakery.Pastries;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_InitializesBread_Bread()
    {
      Bread newBreadOrder = new Bread();
      Assert.AreEqual(typeof(bread), newBreadOrder.GetType());
    }
  }
}