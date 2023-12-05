using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop.Data.interfaces
{
    public interface IWatchesCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
