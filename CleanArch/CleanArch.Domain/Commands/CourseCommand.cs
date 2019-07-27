using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Commands
{
    public abstract class CourseCommand : Command
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        

    }
}
