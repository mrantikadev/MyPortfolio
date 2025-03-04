using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class AboutService : IAboutService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AboutService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TInsert(About entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Title))
                throw new Exception("Başlık boş olamaz!");

            _unitOfWork.Abouts.Insert(entity);
        }

        public void TDelete(About entity)
        {
            _unitOfWork.Abouts.Delete(entity);
        }

        public void TUpdate(About entity)
        {
            _unitOfWork.Abouts.Update(entity);
        }

        public IEnumerable<About> TGetAll()
        {
            return _unitOfWork.Abouts.GetAll();
        }

        public About TGetById(int id)
        {
            return _unitOfWork.Abouts.GetById(id);
        }
    }
}
