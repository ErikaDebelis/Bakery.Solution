using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_InitializesBread_Bread()
    {
      // Breads newBread = new Breads();
      // Assert.AreEqual(typeof(breads), newBread.GetType());
    }

    [TestMethod]
    public void GetNumberOfLoavesOrdered_ReturnTheCorrectAmountOfLoaves()
    {
      //Arrange
      var bread = new Bread(); // Model
      var bakery = new Bakery(); // Class with our functions
      
      var expectedOutput = 4;
      var input = "4";
      
      //Act
      int ouput = bakery.GetNumberOfLoavesOrdered(input);

      //Assert
      Assert.AreEqual(expectedOutput, ouput);

    }

    [TestMethod]
    public void GetCostOfOneLoaf_InitializesBread_Bread()
    {
      //Arrange

      //Act

      //Assert
    }

    [TestMethod]
    public void SetTotalBreadCartCost_InitializesBread_Bread()
    {
      //Arrange

      //Act

      //Assert
    }

    [TestMethod]
    public void SetBreadDeal_InitializesBread_Bread()
    {
      //Arrange

      //Act

      //Assert
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