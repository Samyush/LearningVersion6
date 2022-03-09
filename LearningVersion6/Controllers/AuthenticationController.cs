using Microsoft.AspNetCore.Mvc;

namespace LearningVersion6.Controllers;

public class AuthenticationController : Controller
{
    // GET
    //Login in Page
    public IActionResult Index()
    {
        return View();
    }
    
    /*public ActionResult AfterLogin() {  
        if (Session["log"] != null) {  
            return View();  
        } else {  
            return RedirectToAction("Index");  
        }  
    } */
}