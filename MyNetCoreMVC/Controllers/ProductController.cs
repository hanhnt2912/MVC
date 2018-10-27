using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyNetCoreMVC.Models;

namespace MyNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetList()
        {
            return View();
        }

        public IActionResult Create(string name, string price)
        {
            ViewData["Name"] = "Hello " + name;
            ViewData["price"] = price;

            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
//            [Route("Hung/Index/{id:int}")]
            return new JsonResult( new Product()
            {
                Id = id 
            });
        }

    }
}