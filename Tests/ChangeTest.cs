using Xunit;
using System;
using System.Collections.Generic;
using Coins.Objects;

namespace CoinsTest
{
  public class ChangeTest
  {
    [Fact]
    public void Coins_InputAmountTwentyFiveGetQuarterBack_True()
    {
      Change testChange = new Change(163);
      string resultCoins = testChange.ComputeChange();
      Console.WriteLine(resultCoins);
      Assert.Equal("Quarters: 2 Dimes:  Nickles:  Pennies:  .", resultCoins);
    }
  }
}
