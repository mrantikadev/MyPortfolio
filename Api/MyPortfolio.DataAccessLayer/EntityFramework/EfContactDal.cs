using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Concrete;
using MyPortfolio.DataAccessLayer.Repositories;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(Context context) : base(context) { }
    }
}
