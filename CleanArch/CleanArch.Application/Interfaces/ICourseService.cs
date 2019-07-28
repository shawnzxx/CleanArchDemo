using CleanArch.Domain.Services.Commands.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        //CourseViewModel GetCourses();

        void PostCourse(CreateCourseDto createCourseDto);
    }
}
