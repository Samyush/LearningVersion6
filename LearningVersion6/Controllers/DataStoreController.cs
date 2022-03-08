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

        private static List<User> DataStore()
        {
            var dataStores = new List<User>()
            {
                new User{Id = 1, Name = "Hero"},
                new User{Id = 2, Name = "Hero"},
                new User{Id = 3, Name = "Hero"},
                new User{Id = 4, Name = "Hero"},
            };
            return dataStores;
        }
    }
}
