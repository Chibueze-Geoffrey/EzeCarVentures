using System.Collections.Generic;

namespace EzeCarVentures.Models
{
    public interface ICar
    {
        IEnumerable<Car> AllCars { get; }
        Car GetCarById(int carId);
    }
}
