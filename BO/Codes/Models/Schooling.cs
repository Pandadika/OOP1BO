using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Codes.Models
{
    internal abstract class Schooling 
    {
        public SchoolingCategory SchoolingCategory { get; set; }
        public List<TECPerson> Teachers { get; set; }
        private List<CourseCategory>? Courses { get; set; }

        public Schooling(SchoolingCategory schoolingCategory)
        {
            SchoolingCategory = schoolingCategory;
            Teachers = new List<TECPerson>();
            Teachers.Add(new TECPerson() { schoolingCategory = SchoolingCategory.Programmeringslinje, fullname = "Niels Olesen" });
            Teachers.Add(new TECPerson() { schoolingCategory = SchoolingCategory.Supporterlinje, fullname = "Bo Hansen" });
            Teachers.Add(new TECPerson() { schoolingCategory = SchoolingCategory.Infrastrukturlinje, fullname = "Ole Nielsen" });
            SetCourses();
        }

        public virtual void SetCourses()
        {
            Courses = new List<CourseCategory>();
            foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
            {
                Courses.Add(item);
            }
        }

        public abstract string? GetTeacher();
        public string PrintTeachers()
        {
            string result = "";
            Teachers.Sort();
            foreach (var item in Teachers)
            {
                result += $"{item.fullname}\n";
            }
            return result;
        }
        public virtual string PrintCourses()
        {
            string result = "";
            Courses.Sort();
            foreach (var item in Courses)
            {
                result += $"{item}\n";
            }
            return result;
        }


    }

}
