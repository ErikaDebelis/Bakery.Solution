using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Tests
{
    [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void SetProperties_BreadConstructorSetsPropertiesAccurately_IntDouble()
    {
      //Arrange
      int quantityOrdered = 5;
      double totalCost = 20;

      //Act
      Bread newBread = new Bread(quantityOrdered, totalCost);
      int resultQuantityOrdered = newBread.QuantityOrdered;
      double resultTotalCost = newBread.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, newBread.TotalCost);
    }

    [TestMethod]
    public void SetBreadDiscount_CalculatesTotalCostWithoutAccountingForDiscounts_Double()
    {
      //Arrange
      int quantityOrdered = 5;
      double totalCost = 20;

      //Act
      Bread newBread = new Bread(quantityOrdered, totalCost);
      int resultQuantityOrdered = newBread.QuantityOrdered;
      double resultTotalCost = newBread.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, 20);
    }
    [TestMethod]
    public void SetBreadDiscount_CalculatesTotalCostWithDiscounts_Double()
    {
      //Arrange
      int quantityOrdered = 6;
      double totalCost = 20;

      //Act
      Bread newBread = new Bread(quantityOrdered, totalCost);
      int resultQuantityOrdered = newBread.QuantityOrdered;
      double resultTotalCost = newBread.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, 20);
    }
    [TestMethod]
    public void SetBreadDiscount_CalculatesTotalCostifordersLesThan3Loaves_Double()
    {
      //Arrange
      int quantityOrdered = 1;
      double totalCost = 5;

      //Act
      Bread newBread = new Bread(quantityOrdered, totalCost);
      int resultQuantityOrdered = newBread.QuantityOrdered;
      double resultTotalCost = newBread.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, 5);
    }
  }
}


//TEST CLASS CONSTRUCTOR + all properties
//TEST FOR QUANTITYORDERED
//TEST FOR TOTAL COST - discounts 2 different returns- then 2 tests