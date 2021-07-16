using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
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
      Breads newBread = new Breads();
      Assert.AreEqual(typeof(breads), newBread.GetType());
    }
  }
//     [TestClass]
//   public class PastryTests
//   {
//     [TestMethod]
//     public void PastryConstructor_InitializesPastry_Bread()
//     {
//       Pastries newPastry = new Pastries();
//       Assert.AreEqual(typeof(Pastries), newPastry.GetType());
//     }
//   }
}