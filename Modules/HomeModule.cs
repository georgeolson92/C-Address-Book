using Nancy;
using ContactList.Objects;
using System.Collections.Generic;

namespace ContactList.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View ["index.cshtml"];
      };
      Get["/new"] = _ => {
        return View ["addnew.cshtml"];
      };
      Post["/contact-list"] = _ => {
      	Contact newContact = new Contact(Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
        return View ["list.cshtml", newContact];
      };
    }
  }
}
