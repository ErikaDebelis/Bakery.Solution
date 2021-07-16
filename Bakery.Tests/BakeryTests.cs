using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Bread;
using Bakery.Pastries;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_InitializesBread_Bread()
    {
      Breads newBreadOrder = new Breads();
      Assert.AreEqual(typeof(breads), newBreadOrder.GetType());
    }
  }
}