using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet2.Controllers
{
    [Route("/hello")]
    public class HelloController : Controller
    {
        //GET: // <constructor>
        [HttpGet]

        public IActionResult Index()
        {
             return View();
        }

        // Get: /hello/welcome
        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
        }
    }
}
