using CleanArch.Domain.Services.Commands.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Services.Commands
{
    public class CreateCourseCommand : IRequest<CreateCourseResult>
    {
        public CreateCourseDto CreateCourseDto { get; set; }

    }
}
