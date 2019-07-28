using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Services.Commands.Dtos
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
