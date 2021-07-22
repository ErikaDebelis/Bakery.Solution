using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
    [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void SetProperties_PastryConstructorSetsPropertiesAccurately_Int()
    {
      //Arrange
      int quantityOrdered = 5;
      int totalCost = 9;

      //Act
      Pastry newPastry = new Pastry(quantityOrdered, totalCost);
      int resultQuantityOrdered = newPastry.QuantityOrdered;
      int resultTotalCost = newPastry.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newPastry.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, newPastry.TotalCost);
    }
  }
}


//TEST CLASS CONSTRUCTOR + all properties
//TEST FOR QUANTITYORDERED
//TEST FOR TOTAL COST - discounts 2 different returns- then 2 tests