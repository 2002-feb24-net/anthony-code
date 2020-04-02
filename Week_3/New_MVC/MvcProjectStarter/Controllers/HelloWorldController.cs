using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcProjectStarter.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            //return View();
            return "This is some text for testing";
        }

        public string Welcome(string name = "anthony", int numTimes = 1)
        {
            return $"Neme = {name} and NumTimes = {numTimes}";
        }
    }
}