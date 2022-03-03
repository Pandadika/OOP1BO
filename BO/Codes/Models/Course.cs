using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Codes.Models
{
    internal class Course : Schooling
    {
        public Course(SchoolingCategory schoolingCategory) : base(schoolingCategory)
        {
            SchoolingCategory = schoolingCategory;
            base.SetCourses();
            SetCourses();
        }

        public List<CourseCategory> SchoolingCourses { get; set; }

        public override void SetCourses()
        {
            SchoolingCourses = new List<CourseCategory>();
            if (this.SchoolingCategory == SchoolingCategory.Programmeringslinje)
            {
                foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
                {
                    if (item.GetEnumDescription().ToLower().Contains("programmering"))
                    {
                        SchoolingCourses.Add(item);
                    }
                }
            }
            else if (this.SchoolingCategory == SchoolingCategory.Supporterlinje)
            {
                foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
                {
                    if (item.ToString().ToLower().Contains("server"))
                    {
                        SchoolingCourses.Add(item);
                    }
                }
            }
            else
            {
                foreach (CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
                {
                    if (item.ToString().ToLower().Contains("netværk"))
                    {
                        SchoolingCourses.Add(item);
                    }
                }
            }
        }

        public override string? GetTeacher()
        {
            return Teachers.Where(Teacher => Teacher.schoolingCategory == this.SchoolingCategory).First().fullname;
        }

        public override string PrintCourses()
        {
            string result = "";
            SchoolingCourses.Sort();
            foreach (var item in SchoolingCourses)
            {
                result += $"{item.GetEnumDescription()}\n";
            }
            return result;
        }

        public override string ToString()
        {
            return "** OOP H1 Afleveringsopgave **";
        }
    }
}
