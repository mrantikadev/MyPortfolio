using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Concrete;
using MyPortfolio.DataAccessLayer.Repositories;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public EfMessageDal(Context context) : base(context) { }
    }
}
