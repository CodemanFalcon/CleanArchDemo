using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
