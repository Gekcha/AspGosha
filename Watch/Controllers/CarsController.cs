using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCaterories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCaterories = iCarsCat;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";

            if(string.IsNullOrEmpty(_category))
            {
                cars = _allCars.Cars.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Электромобили"));
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = _allCars.Cars.Where(i => i.Category.categoryName.Equals("Классические автомобили"));
                    currCategory = "Классические автомобили";
                }
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                currCategory = currCategory
            };

        ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }

    }
}
