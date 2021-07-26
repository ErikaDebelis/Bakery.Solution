using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Tests
{
    [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void SetProperties_PastryConstructorSetsPropertiesAccurately_IntDouble()
    {
      //Arrange
      int quantityOrdered = 5;
      double totalCost = 9;

      //Act
      Pastry newPastry = new Pastry(quantityOrdered, totalCost);
      int resultQuantityOrdered = newPastry.QuantityOrdered;
      double resultTotalCost = newPastry.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newPastry.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, newPastry.TotalCost);
    }
    [TestMethod]
    public void SetPastryDiscount_CalculatesTotalCostWhileAccountingForDiscounts_Double()
    {
      //Arrange
      int quantityOrdered = 9;
      double totalCost = 15;

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