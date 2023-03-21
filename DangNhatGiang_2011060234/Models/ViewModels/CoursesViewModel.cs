using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DangNhatGiang_2011060234.Models.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}