using System;
using Nancy;
using System.Collections.Generic;
using Coins.Objects;


namespace Coins
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/coin_count"] = _ => {
        Change newChange = new Change(Request.Query["changeAmount"]);
        string result = newChange.ComputeChange();
        return View["index.cshtml", result];
      };
    }
  }
}
