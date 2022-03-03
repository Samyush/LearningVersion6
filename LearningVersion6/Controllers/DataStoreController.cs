using LearningVersion6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningVersion6.Controllers
{
    public class DataStoreController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = DataStore();
            return View("AdditionalMethod", users);
        }

        public static List<User> DataStore()
        {
            List<User> dataStores = new List<User>()
            {
                new User{ID = 1, Name = "Hero"},
                new User{ID = 2, Name = "Hero"},
                new User{ID = 3, Name = "Hero"},
                new User{ID = 4, Name = "Hero"},
            };
            return dataStores;
        }
    }
}
