using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace FizzBuzzWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GetFizzBuzz(int id)
        {
            var request = new FizzBuzzLib5.FizzBuzzRequest { StartCount = 1, EndCount = 100 };
            request.ValueTextPairs.Add(new FizzBuzzLib5.FizzBuzzValueTextPair("Foo", 3));
            request.ValueTextPairs.Add(new FizzBuzzLib5.FizzBuzzValueTextPair("Bar", 5));
            request.ValueTextPairs.Add(new FizzBuzzLib5.FizzBuzzValueTextPair("Bazz", 7));
            request.ValueTextPairs.Add(new FizzBuzzLib5.FizzBuzzValueTextPair("Banana", 11));

            ViewData["FizzBuzzLines"] = FizzBuzzLib5.FizzBuzz.GetFizzBuzzLines(request);

            return View();
        }
    }
}
