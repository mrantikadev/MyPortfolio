using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.Concrete;
using MyPortfolio.DataAccessLayer.UnitOfWork.Abstract;

namespace MyPortfolio.DataAccessLayer.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public IAboutDal Abouts { get; }

        public IContactDal Contacts { get; }

        public IExperienceDal Experiences { get; }

        public IFeatureDal Features { get; }

        public IMessageDal Messages { get; }

        public IProjectDal Projects { get; }

        public ISocialMediaDal SocialMedias { get; }

        public ITestimonialDal Testimonials { get; }

        public UnitOfWork(Context context, IAboutDal aboutDal, IContactDal contactDal, IExperienceDal experienceDal, IFeatureDal featureDal, IMessageDal messageDal, IProjectDal projectDal, ISocialMediaDal socialMediaDal, ITestimonialDal testimonialDal)
        {
            _context = context;
            Abouts = aboutDal;
            Contacts = contactDal;
            Experiences = experienceDal;
            Features = featureDal;
            Messages = messageDal;
            Projects = projectDal;
            SocialMedias = socialMediaDal;
            Testimonials = testimonialDal;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }
    }
}
