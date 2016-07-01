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
        List<Contact> allContacts = Contact.GetAll();
        return View ["index.cshtml", allContacts];
      };
      Get["/new"] = _ => {
        return View ["addnew.cshtml"];
      };
      Post["/contacts_deleted"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        Contact.ClearAll();
        return View["clear.cshtml", allContacts];
      };
      Post["/new_contact"] = _ => {
      	Contact newContact = new Contact(Request.Form["name"], Request.Form["phone"], Request.Form["address"]);
        return View ["newcontact.cshtml", newContact];
      };
    }
  }
}
