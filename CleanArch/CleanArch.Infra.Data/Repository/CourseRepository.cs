using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _universityDBContext;

        public CourseRepository(UniversityDBContext universityDBContext)
        {
            _universityDBContext = universityDBContext;
        }

        public void Add(Course course)
        {
            _universityDBContext.Add(course);
            _universityDBContext.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _universityDBContext.Courses;
        }
    }
}
