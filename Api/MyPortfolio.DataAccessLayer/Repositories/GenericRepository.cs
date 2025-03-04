using Microsoft.EntityFrameworkCore;
using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Concrete;

namespace MyPortfolio.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericDal<TEntity>
        where TEntity : class
    {
        private readonly Context _context;
        private readonly DbSet<TEntity> _table;

        public GenericRepository(Context context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
        }

        public void Insert(TEntity t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(TEntity t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }

        public void Delete(TEntity t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _table.ToList();
        }

        public TEntity GetById(int id)
        {
            return _table.Find(id);
        }        
    }
}
