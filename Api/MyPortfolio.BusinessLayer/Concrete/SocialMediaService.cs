using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class SocialMediaService : ISocialMediaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SocialMediaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TDelete(SocialMedia entity)
        {
            _unitOfWork.SocialMedias.Delete(entity);
        }

        public IEnumerable<SocialMedia> TGetAll()
        {
            return _unitOfWork.SocialMedias.GetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return _unitOfWork.SocialMedias.GetById(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _unitOfWork.SocialMedias.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _unitOfWork.SocialMedias.Update(entity);
        }
    }
}
