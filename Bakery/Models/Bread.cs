﻿using System;
using System.Collections.Generic;
namespace Bakery.Breads
{
  public class Bread
  {
    public void BreadTotal()
    {
      Console.WriteLine("will this work?");
    }
  }
}




    // public int NumOfLoaves { get; set; }
    // public int CostOfLoaf {get; set; }
    // public int BreadDiscount {get; set; }

    // public static int BreadTotal(int inputtedBreadOrder) //method
    // {
    //   NumOfLoaves = inputtedBreadOrder;
    //   int breadOrderCost = 0; //starting value is 0- will add to this to get bread total cost
    //   int singleLoafCost = 5;
    //   int BreadDiscount = 0// starting value is 0- will add to this to get bread total discount amount
    // }
    // public int CalculateBreadTotalCost()
    // {
    //   breadOrderCost = singleLoafCost * NumOfLoaves;
    //   return breadOrderCost;
    // }
      // public int LoavesDiscounted()
    // {
      //int freeLoaf = NumOfLoaves / 3;
      //LoavesDiscounted = (NumOfLoaves - freeLoaf) * singleLoafCost;
    // }

  //buy 2 get 1 free:
  //Total cost =2x
  //Discount =3x−2x=x
  //Discount percentage =x/(3x)=0.333= 33 1/3%