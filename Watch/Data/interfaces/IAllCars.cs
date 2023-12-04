using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carId);

    }
}
