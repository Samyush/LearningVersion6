using LearningVersion6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningVersion6.Controllers;

public class AuthenticationController : Controller
{
    private readonly Year3DbContext _year3DbContext;

    public AuthenticationController(Year3DbContext db)
    {
        _year3DbContext = db;
    }
    // GET
    //Login in Page
    public IActionResult Index()
    {
        
        return View();
    }

    [HttpPost]
    public ActionResult Index(User user)
    {
        if (ModelState.IsValid)
        {
            var loginResult = _year3DbContext.Users.Where(x => x.Email.Equals(user.Email) && x.PhoneNumber.Equals(user.PhoneNumber)).FirstOrDefault();
            if (loginResult != null)
            {
               // Session["log"] = loginResult.Email.ToString();
                return RedirectToAction("AfterLogin");
            }
        }

        return View();
    }
    
    public ActionResult AfterLogin() {  
        //if (Session["log"] != null) {  
            return View();  
        //} else {  
          //  return RedirectToAction("Index");  
        //}  
    } 
}