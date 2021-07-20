using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierresBakery;

namespace PierresBakery.Tests
{
    [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void SetBreadTotal_SetValuesToPropertiesOfBread_Bread()
    {
      Bread newBread = new Bread(); // Model

      int QuantityOrdered = 4;
      int expectedOutput = 4;
      //Act
      int output = Bread.Bread(QuantityOrdered);
      //Assert
      Assert.AreEqual(expectedOutput, output);
    }

    [TestMethod]
    public void SetBreadDeal_InitializesBread_Bread()
    {
      //Arrange

      //Act

      //Assert
    }


  }

}