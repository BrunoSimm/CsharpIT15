using Lab11.Models;
using Microsoft.EntityFrameworkCore;
using Lab11.Repositories;
using Lab11.Repositories.Implementations;
using System.Text.Json.Serialization;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        // builder.Services.AddControllers();
        builder.Services.AddControllers()
            .AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<BibliotecaContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


        builder.Services.AddScoped<IRepositoryAutores, RepositoryAutores>();
        builder.Services.AddScoped<IRepositoryEmprestimos, RepositoryEmprestimos>();
        builder.Services.AddScoped<IRepositoryLivros, RepositoryLivros>();

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