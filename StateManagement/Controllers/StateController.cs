 using Microsoft.AspNetCore.Mvc;
 using Microsoft.AspNetCore.Http;
 public class StateController:Controller
 {
     public ActionResult First()
     {
         //StateManagement
         //1.Client Side
         //1.1 Cookies
         var name = "Paras Tiwari";
         // CookieOptions (class for cookies)
         Response.Cookies.Append("user",name);
         //1.2 Query Strings (Parameters)

         //2. serverside
         //2.1 session

         HttpContext.Session.SetString("UserAddress","Paras Tiwari");
        //2.2 temp
        TempData["CollegeName"]="MBM College";
         return View();
     }

    public ViewResult Second(string  name, int age)//1.2 queryparameters
    {
        var UserAddress = HttpContext.Session.GetString("UserAddress");
        return View();

    }
    [HttpPost]
     public string Second(string CollegeName)//1.3hidden field
    {
        return CollegeName;

    }
    public ViewResult Third()
{
    var CollegeName=TempData["CollegeName"];
    ViewData["Name"]= "Third View";
    ViewBag.Detail="This is Content of detial";
      return View(CollegeName);
}
 }