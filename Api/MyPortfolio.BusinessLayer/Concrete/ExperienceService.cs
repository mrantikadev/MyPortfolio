using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class ExperienceService : IExperienceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperienceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TInsert(Experience entity)
        {
            _unitOfWork.Experiences.Insert(entity);
        }

        public void TDelete(Experience entity)
        {
            _unitOfWork.Experiences.Delete(entity);
        }

        public void TUpdate(Experience entity)
        {
            _unitOfWork.Experiences.Update(entity);
        }

        public IEnumerable<Experience> TGetAll()
        {
            return _unitOfWork.Experiences.GetAll();
        }

        public Experience TGetById(int id)
        {
            return _unitOfWork.Experiences.GetById(id);
        }        
    }
}
