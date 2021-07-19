using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetNumberOfLoavesOrdered_ReturnTheCorrectAmountOfLoaves()
    {
      //Arrange
      Bread newBread = new Bread(); // Model
      Bakery newBakery = new Bakery(); // Class with our functions
      
      int expectedOutput = 4;
      string input = "4";
      
      //Act
      int output = newBakery.GetNumberOfLoavesOrdered(input);

      //Assert
      Assert.AreEqual(expectedOutput, output);

    }

//     [TestMethod]
//     public void GetCostOfOneLoaf_InitializesBread_Bread()
//     {
//       //Arrange

//       //Act

//       //Assert
//     }

//     [TestMethod]
//     public void SetTotalBreadCartCost_InitializesBread_Bread()
//     {
//       //Arrange

//       //Act

//       //Assert
//     }

//     [TestMethod]
//     public void SetBreadDeal_InitializesBread_Bread()
//     {
//       //Arrange

//       //Act

//       //Assert
//     }


  }

}