using MyPortfolio.BusinessLayer.Abstract;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;
using MyPortfolio.EntityLayer.Concrete;

namespace MyPortfolio.BusinessLayer.Concrete
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestimonialService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void TInsert(Testimonial entity)
        {
            _unitOfWork.Testimonials.Insert(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _unitOfWork.Testimonials.Delete(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _unitOfWork.Testimonials.Update(entity);
        }

        public IEnumerable<Testimonial> TGetAll()
        {
            return _unitOfWork.Testimonials.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _unitOfWork.Testimonials.GetById(id);
        }
    }
}
