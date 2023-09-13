using System.Collections.Generic;

namespace EzeCarVentures.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public List<Car> Cars { get; set; }
    }
}
