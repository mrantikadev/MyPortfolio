namespace MyPortfolio.DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        public void Insert(TEntity t);
        public void Delete(TEntity t);
        public void Update(TEntity t);
        public IEnumerable<TEntity> GetAll();
        public TEntity GetById(int id);
    }
}
