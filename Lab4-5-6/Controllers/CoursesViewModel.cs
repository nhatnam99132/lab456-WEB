using System.Linq;
using Lab4_5_6.Models;

namespace Lab4_5_6.Controllers
{
    internal class CoursesViewModel
    {
        public IQueryable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}