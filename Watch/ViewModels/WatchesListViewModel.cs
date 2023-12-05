using Shop.Data.Models;
using System.Collections.Generic;


namespace Shop.ViewModels
{
    public class WatchesListViewModel
    {

        public IEnumerable<Watch> allWatches { get; set;}

        public string currCategory { get; set;}

    }
}
