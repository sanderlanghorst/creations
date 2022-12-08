
using Microsoft.AspNetCore.Identity;
using Creations.DummyInfra;
using Microsoft.AspNetCore.Authentication;
using Creations.Api.Auth;

namespace Creations.Api
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

            builder.Services.AddScoped<Creations.Core.Abstractions.IUserStore, DummyUserStore>();
            builder.Services.AddScoped<Creations.Core.Abstractions.ICreationStore, DummyCreationsStore>();
            builder.Services.AddScoped<Creations.Core.Abstractions.IFileStore, DummyFileStore>();
            builder.Services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

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