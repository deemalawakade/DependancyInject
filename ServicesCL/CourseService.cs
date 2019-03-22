using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesCL;

namespace ServicesCL
{
   public class CourseService : ICourseService
    {
        public Course GetCourseById(long courseId)
        {
            return new Course
            {
                CourseId = courseId,
                Description = "Demo Course Description",
                InstitutionId = 1,
                Title = "Demo Course Title"

            };
        }
    }
}
