
using Microsoft.EntityFrameworkCore;
using MoviesProject.RepoPattern.CategoryRepo;
using MoviesProject.RepoPattern.DirictorRepo;
using MoviesProject.RepoPattern.MovieRepo;
using MoviesProject.RepoPattern.NationalityRepo;

namespace MoviesProject
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
            var connection = builder.Configuration.GetConnectionString("DefultConnection");
            builder.Services.AddDbContext<appDbContext>(options => options.UseSqlServer(connection));
            builder.Services.AddScoped<IRepoMovie, RepoMovie>();
            builder.Services.AddScoped<IRepoDirictor, RepoDirictor>();
            builder.Services.AddScoped<IRepoNationality, RepoNationality>();
            builder.Services.AddScoped<IRepoCategory, RepoCategory>();

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
