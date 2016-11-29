using System.Collections.Generic;
using System;

namespace Coins.Objects
{
  public class Change
  {
    int[] _coinValues = new int[] {25, 10, 5, 1};
    private int _inputAmount;
    private int _total;

    public Change(int inputAmount)
    {
      _inputAmount = inputAmount;
    }

    //Getters setters
    public string ComputeChange()
    {
      int numberOfQuarters = 0;
      int numberOfDimes = 0;
      int numberOfNickles = 0;
      int numberOfPennies = 0;
      for (int i = 0; i < _coinValues.Length; i ++)
      {
        while (_inputAmount >= _coinValues[i])
        {
          _inputAmount -= _coinValues[i];
          if(i == 0)
          {
            numberOfQuarters++;
          }
          if(i == 1)
          {
            numberOfDimes++;
          }
          if(i == 2)
          {
            numberOfNickles++;
          }
          if(i == 3)
          {
            numberOfPennies++;
          }
        }
      }
      string result = ("Quarters: " + numberOfQuarters + " Dimes: " + numberOfDimes + " Nickles: " + numberOfNickles + " Pennies: " + numberOfPennies + ".");
      return result;
    }
  }
}
