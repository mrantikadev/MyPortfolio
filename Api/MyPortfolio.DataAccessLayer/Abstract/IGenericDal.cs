namespace MyPortfolio.DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        public void Insert(TEntity entity);
        public void Delete(TEntity entity);
        public void Update(TEntity entity);
        public IEnumerable<TEntity> GetAll();
        public TEntity GetById(int id);
    }
}
