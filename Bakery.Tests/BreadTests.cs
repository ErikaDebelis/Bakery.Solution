using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery;

namespace PierresBakery.Tests
{
    [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void SetProperties_BreadConstructorSetsPropertiesAccurately_Int()
    {
      //Arrange
      int quantityOrdered = 5;
      int totalCost = 20;

      //Act
      Bread newBread = new Bread(quantityOrdered, totalCost);
      int resultQuantityOrdered = newBread.QuantityOrdered;
      int resultTotalCost = newBread.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, newBread.TotalCost);
    }

        [TestMethod]
    public void SetBreadDiscount_SetBreadDiscountMethodAccuratelyCalculatestotalCostWithoutAccountingForDiscounts_Int()
    {
      //Arrange
      int quantityOrdered = 5;
      int totalCost = 20;

      //Act
      Bread newBread = new Bread(quantityOrdered, totalCost);
      int resultQuantityOrdered = newBread.QuantityOrdered;
      int resultTotalCost = newBread.TotalCost;

      //AsserttotalCost
      Assert.AreEqual(resultQuantityOrdered, newBread.QuantityOrdered);
      Assert.AreEqual(resultTotalCost, 20);
    }
  }
}


//TEST CLASS CONSTRUCTOR + all properties
//TEST FOR QUANTITYORDERED
//TEST FOR TOTAL COST - discounts 2 different returns- then 2 tests