using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureService(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TInsert(Feature entity)
        {
            _featureDal.Insert(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }

        public IEnumerable<Feature> TGetAll()
        {
            return _featureDal.GetAll();
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }
    }
}
