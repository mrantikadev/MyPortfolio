using MyPortfolio.DataAccessLayer.Abstract;

namespace MyPortfolio.DataAccessLayer.UnitOfWork.Abstract
{
    public interface IUnitOfWork
    {
        IAboutDal Abouts { get; }
        IContactDal Contacts { get; }
        IExperienceDal Experiences { get; }
        IFeatureDal Features { get; }
        IMessageDal Messages { get; }
        IProjectDal Projects { get; }
        ISocialMediaDal SocialMedias { get; }
        ITestimonialDal Testimonials { get; }
        int Commit();
    }
}
