using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class FeatureService : IFeatureService
    {
        private readonly IUnitOfWork _unitOfWork;

        public FeatureService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TInsert(Feature entity)
        {
            _unitOfWork.Features.Insert(entity);
        }

        public void TDelete(Feature entity)
        {
            _unitOfWork.Features.Delete(entity);
        }

        public void TUpdate(Feature entity)
        {
            _unitOfWork.Features.Update(entity);
        }

        public IEnumerable<Feature> TGetAll()
        {
            return _unitOfWork.Features.GetAll();
        }

        public Feature TGetById(int id)
        {
            return _unitOfWork.Features.GetById(id);
        }
    }
}
