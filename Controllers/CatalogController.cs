using System;
using Microsoft.AspNetCore.Mvc;
using Rental.Models;
using System.Collections.Generic;
using System.Linq;

namespace Rental.Controllers
{
    public class CatalogController : Controller
    {
        private DataContext dbContext;
        public CatalogController(DataContext context){
            this.dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveCar([FromBody] Car theCar){
            Console.WriteLine("User is saving a car");
            Console.WriteLine(theCar.Make);

            // logic to save theCar into Database
            dbContext.Cars.Add(theCar);
            dbContext.SaveChanges(); // Commit changes to DB

            //theCar.Id = 1;
            return Json(theCar);
        }

        [HttpGet]
        public IActionResult GetCatalog(){
            // return Content("Hello Get!");
            // Car c1 = new Car();
            //     c1.Make = "Ford";
            //     c1.Model = "Focus";
            //     c1.Year = "2015";
            //     c1.Description = "This is a fuel efficient car that you can get at a very good price.";
            //     c1.DailyPrice = "12.99m";
            //     c1.ImageUrl = "https://picolio.auto123.com/15photo/ford/2015-ford-focus-se_1.png";
            //     c1.Cyls = "4";
            //     c1.Passengers = "4";
            //     c1.Type = "Economy";

            // Car c2 = new Car();
            //     c2.Make = "Ford";
            //     c2.Model = "Mustang";
            //     c2.Year = "2019";
            //     c2.Description = "Super Duper Fast";
            //     c2.DailyPrice = "33.99m";
            //     c2.ImageUrl = "https://digital.pixelmotion.com/assets/theme/seo-page-builder/images/2019/Ford/Mustang%20GT%20Premium/2019%20Ford%20Mustang%20GT%20Premium%20Orange%20Exterior%20Front%20View.png";
            //     c2.Cyls = "8";
            //     c2.Passengers = "4";
            //     c2.Type = "Super Sport";

            //     List<Car> list = new List<Car>();
            //     list.Add(c1);
            //     list.Add(c2);

            var list = dbContext.Cars.ToList(); // retrieve all records from Car Table
            // var name = Whats in the DB. Cars is from DataContext.cs as a table. the list from the table
            return Json(list);
        }
    }
}