using EzeCarVentures.Models;
using System.Collections.Generic;

namespace EzeCarVentures.ViewModel
{
    public class CarViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
        public string CurrentBrand { get; set; }
    }
}
