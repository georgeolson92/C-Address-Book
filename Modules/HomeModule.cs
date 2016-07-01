using Nancy;
using CdList.Objects;
using System.Collections.Generic;

namespace CdList.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View ["index.cshtml"];
      };
    }
  }
}
