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
      Get["/clear"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        Contact.ClearAll();
        return View["clear.cshtml", allContacts];
      };
      Get["/contact_list"] = _ => {
      	List<Contact> allContacts = Contact.GetAll();
        return View ["list.cshtml", allContacts];
      };
      Post["/new_contact"] = _ => {
      	Contact newContact = new Contact(Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
        return View ["newcontact.cshtml", newContact];
      };
    }
  }
}
