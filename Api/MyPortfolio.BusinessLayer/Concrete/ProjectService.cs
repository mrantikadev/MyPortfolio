using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TInsert(Project entity)
        {
            _unitOfWork.Projects.Insert(entity);
        }

        public void TDelete(Project entity)
        {
            _unitOfWork.Projects.Delete(entity);
        }

        public void TUpdate(Project entity)
        {
            _unitOfWork.Projects.Update(entity);
        }

        public IEnumerable<Project> TGetAll()
        {
            return _unitOfWork.Projects.GetAll();
        }

        public Project TGetById(int id)
        {
            return _unitOfWork.Projects.GetById(id);
        }        
    }
}
