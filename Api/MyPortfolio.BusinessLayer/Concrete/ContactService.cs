using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TInsert(Contact entity)
        {
            _unitOfWork.Contacts.Insert(entity);
        }

        public void TDelete(Contact entity)
        {
            _unitOfWork.Contacts.Delete(entity);
        }

        public void TUpdate(Contact entity)
        {
            _unitOfWork.Contacts.Update(entity);
        }

        public IEnumerable<Contact> TGetAll()
        {
            return _unitOfWork.Contacts.GetAll();
        }

        public Contact TGetById(int id)
        {
            return _unitOfWork.Contacts.GetById(id);
        }
    }
}
