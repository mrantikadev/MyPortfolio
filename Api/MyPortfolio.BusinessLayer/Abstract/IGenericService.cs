namespace MyPortfolio.BusinessLayer.Abstract
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        public void TInsert(TEntity entity);
        public void TDelete(TEntity entity);
        public void TUpdate(TEntity entity);
        public IEnumerable<TEntity> TGetAll();
        public TEntity TGetById(int id);
    }
}
