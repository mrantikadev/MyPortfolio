using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Concrete;
using MyPortfolio.DataAccessLayer.Repositories;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(Context context) : base(context) { }
    }
}
