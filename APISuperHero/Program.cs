using APISuperHero.Interfaces;
using APISuperHero.Mappings;
using APISuperHero.Rest;
using APISuperHero.Services;

namespace APISuperHero
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddSingleton<IHeroService, HeroService>();
            builder.Services.AddSingleton<IImageService, ImageService>();
            builder.Services.AddSingleton<ISuperHeroAPI, SuperHeroAPIRest>();

            builder.Services.AddAutoMapper(typeof(HeroMapping));
            builder.Services.AddAutoMapper(typeof(ImageMapping));

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
        }
    }
}