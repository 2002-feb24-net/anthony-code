using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace MvcProjectStarter.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();;
        }

        public string Welcome(string name, int ID = 2)
        {
            //return "Welcome to the jungle";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}