using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Controllers
{
    public class WatchesController : Controller
    {

        private readonly IAllWatches _allWatches;
        private readonly IWatchesCategory _allCaterories;

        public WatchesController(IAllWatches iAllWatches, IWatchesCategory iWatchesCat)
        {
            _allWatches = iAllWatches;
            _allCaterories = iWatchesCat;
        }
        [Route("Watches/List")]
        [Route("Watches/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Watch> watches = null;
            string currCategory = "";

            if(string.IsNullOrEmpty(_category))
            {
                watches = _allWatches.Watches.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    watches = _allWatches.Watches.Where(i => i.Category.categoryName.Equals("Электромобили"));
                    currCategory = "Электромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    watches = _allWatches.Watches.Where(i => i.Category.categoryName.Equals("Классические автомобили"));
                    currCategory = "Классические автомобили";
                }
            }

            var watchObj = new WatchesListViewModel
            {
                allWatches = watches,
                currCategory = currCategory
            };

        ViewBag.Title = "Страница с автомобилями";

            return View(watchObj);
        }

    }
}
