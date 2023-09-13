using System.Collections.Generic;

namespace EzeCarVentures.Models
{
    public class BrandRepo : IBrand
    {
        private readonly AppDbContext _appDbContext;
        public BrandRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Brand> AllBrand => _appDbContext.Brand;
    }
}
