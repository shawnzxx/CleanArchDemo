using CleanArch.Application.Interfaces;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Services.Commands;
using CleanArch.Domain.Services.Commands.Dtos;
using MediatR;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediator _mediator;

        public CourseService(ICourseRepository courseRepository, IMediator mediator)
        {
            _courseRepository = courseRepository;
            _mediator = mediator;
        }

        public void PostCourse(CreateCourseDto createCourseDto)
        {
            var createCourseCommand = new CreateCourseCommand();
            createCourseCommand.CreateCourseDto = createCourseDto;
            _mediator.Send(createCourseCommand);
        }

        //public CourseViewModel GetCourses()
        //{
        //    var courses = _courseRepository.GetCourses();
        //    return new CourseViewModel()
        //    {
        //        Courses = courses
        //    };
        //}
    }
}
