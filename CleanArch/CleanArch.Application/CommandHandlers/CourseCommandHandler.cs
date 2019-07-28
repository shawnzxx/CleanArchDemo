using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Domain.Services.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Application.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, CreateCourseResult>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        Task<CreateCourseResult> IRequestHandler<CreateCourseCommand, CreateCourseResult>.Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.CreateCourseDto.Name,
                Description = request.CreateCourseDto.Description,
                ImageUrl = request.CreateCourseDto.ImageUrl
            };

            //business logic in here, send email, add to database
            _courseRepository.Add(course);

            return Task.FromResult(
                new CreateCourseResult{
                    Id = course.Id
                });
        }
    }
}
