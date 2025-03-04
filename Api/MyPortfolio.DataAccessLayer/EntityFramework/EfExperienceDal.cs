using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Concrete;
using MyPortfolio.DataAccessLayer.Repositories;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.DataAccessLayer.EntityFramework
{
    public class EfExperienceDal : GenericRepository<Experience>, IExperienceDal
    {
        public EfExperienceDal(Context context) : base(context) { }
    }
}
