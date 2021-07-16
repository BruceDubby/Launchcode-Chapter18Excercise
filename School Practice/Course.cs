using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Practice
{
    public class Course
    {

        public string CourseDes { get; set; }
        public List<string> Title { get; set; }
        public double Credits { get; set; }

        
        public Course(string courseDes, List <string> title, double credits)
        {
            this.CourseDes = courseDes;
            this.Title = title;
            this.Credits = credits;
        }

        public Course()
        {
            this.CourseDes = "PRMG 1001";
            this.Title = new List<string> { "Java", "Python", "Javascript", "C#", "Agile", "Reach" };
            this.Credits = 3.0;
        }
    }
}
