using Microsoft.AspNetCore.Identity;
using MyPortfolio.DataAccessLayer.Abstract;
using MyPortfolio.DataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<Context>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<IExperienceDal, EfExperienceDal>();

builder.Services.AddScoped<IFeatureDal, EfFeatureDal>();

builder.Services.AddScoped<IMessageDal, EfMessageDal>();

builder.Services.AddScoped<IProjectDal, EfProjectDal>();

builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
