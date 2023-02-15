using Sevices.Interfaces;
using Sevices.ServiceClasses;
using Sevices;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sevices.DTOs;
using Repository.Entities;
using FluentAssertions.Common;
using IdentityServer3.Core.Services;
//using static UI.App_Start.WebApiConfig;

namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IChildServices, ChildService>();
            builder.Services.AddScoped<IUserServices, UserService>();
            builder.Services.AddAutoMapper(typeof(MappingProfile));
            builder.Services.AddServices();
            //builder.Services.AddAutoMapper(typeof(Mapper));

           

            var app = builder.Build();
            app.UseCors("corsPolicy");
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