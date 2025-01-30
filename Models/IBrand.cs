using System.Collections.Generic;

namespace EzeCarVentures.Models
{
    public interface IBrand
    {
        IEnumerable<Brand> AllBrand { get; }
    }
}
