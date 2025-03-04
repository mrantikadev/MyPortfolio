using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;

        public ExperienceService(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TInsert(Experience entity)
        {
            _experienceDal.Insert(entity);
        }

        public void TDelete(Experience entity)
        {
            _experienceDal.Delete(entity);
        }

        public void TUpdate(Experience entity)
        {
            _experienceDal.Update(entity);
        }

        public IEnumerable<Experience> TGetAll()
        {
            return _experienceDal.GetAll();
        }

        public Experience TGetById(int id)
        {
            return _experienceDal.GetById(id);
        }        
    }
}
