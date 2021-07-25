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
      double resultTotalCost = newPastry.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newPastry.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, newPastry.TotalCost);
    }
    [TestMethod]
    public void SetPastryDiscount_CalculatesTotalCostWhileAccountingForDiscounts_Int()
    {
      //Arrange
      int quantityOrdered = 9;
      int totalCost = 15;

      //Act
      Pastry newPastry = new Pastry(quantityOrdered, totalCost);
      int resultQuantityOrdered = newPastry.QuantityOrdered;
      double resultTotalCost = newPastry.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newPastry.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, 15);
    }
  }
}


//TEST CLASS CONSTRUCTOR + all properties
//TEST FOR QUANTITYORDERED
//TEST FOR TOTAL COST - discounts 2 different returns- then 2 tests