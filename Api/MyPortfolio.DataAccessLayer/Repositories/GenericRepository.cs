using Microsoft.EntityFrameworkCore;
using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Concrete;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;

namespace MyPortfolio.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
    {
        private readonly Context _context;
        private readonly DbSet<TEntity> _table;
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(Context context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _table = _context.Set<TEntity>();
            _unitOfWork = unitOfWork;
        }

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Insert(TEntity entity)
        {
            _context.Add(entity);
            _unitOfWork.Commit();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _unitOfWork.Commit();
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
            _unitOfWork.Commit();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _table.AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return _table.AsNoTracking().FirstOrDefault(e => EF.Property<int>(e, "Id") == id);
        }        
    }
}
