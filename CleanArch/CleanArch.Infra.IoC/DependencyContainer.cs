using CleanArch.Application.CommandHandlers;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Services.Commands;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Command Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, CreateCourseResult>, CourseCommandHandler>();

            //Application layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();

            services.AddScoped<UniversityDBContext>();
        }
    }
}
