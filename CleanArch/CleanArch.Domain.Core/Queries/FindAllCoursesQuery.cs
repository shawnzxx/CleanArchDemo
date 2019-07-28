using CleanArch.Domain.Services.Queries.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Services.Queries
{
    public class FindAllCoursesQuery : IRequest<IEnumerable<CourseDto>>
    {

    }
}
