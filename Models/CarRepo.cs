using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;

namespace EzeCarVentures.Models
{
    public class CarRepo : ICar
    {
        private readonly AppDbContext _appDbContext;
        public CarRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Car> AllCars
        {
            get
            {      
                    return _appDbContext.Cars.Include(c => c.Brand);                
            }
        }

        public Car GetCarById(int carId)
        {
            return _appDbContext.Cars.FirstOrDefault(p => p.CarId == carId);
        }
    }
}
