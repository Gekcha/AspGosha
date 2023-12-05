using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop.Data.interfaces
{
    public interface IAllWatches
    {
        IEnumerable<Watch> Watches { get; }
        IEnumerable<Watch> getFavWatches { get; }
        Watch getObjectWatch(int watchId);

    }
}
