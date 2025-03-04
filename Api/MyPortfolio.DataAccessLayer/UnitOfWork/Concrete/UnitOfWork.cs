using MyPortfolio.DataAccessLayer.Concrete;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;

namespace MyPortfolio.DataAccessLayer.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;

        public UnitOfWork(Context context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
