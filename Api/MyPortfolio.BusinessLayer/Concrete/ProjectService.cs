using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectService(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void TInsert(Project entity)
        {
            _projectDal.Insert(entity);
        }

        public void TDelete(Project entity)
        {
            _projectDal.Delete(entity);
        }

        public void TUpdate(Project entity)
        {
            _projectDal.Update(entity);
        }

        public IEnumerable<Project> TGetAll()
        {
            return _projectDal.GetAll();
        }

        public Project TGetById(int id)
        {
            return _projectDal.GetById(id);
        }        
    }
}
