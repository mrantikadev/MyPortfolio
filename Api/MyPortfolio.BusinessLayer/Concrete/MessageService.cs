using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class MessageService : IMessageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MessageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TInsert(Message entity)
        {
            _unitOfWork.Messages.Insert(entity);
        }

        public void TDelete(Message entity)
        {
            _unitOfWork.Messages.Delete(entity);
        }

        public void TUpdate(Message entity)
        {
            _unitOfWork.Messages.Update(entity);
        }

        public IEnumerable<Message> TGetAll()
        {
            return _unitOfWork.Messages.GetAll();
        }

        public Message TGetById(int id)
        {
            return _unitOfWork.Messages.GetById(id);
        }        
    }
}
