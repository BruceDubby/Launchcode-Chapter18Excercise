using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Practice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }


        public Student(string name, int numberOfCredits, double gpa)
        {
            this.Name = name;
            this.NumberOfCredits = numberOfCredits;
            this.Gpa = gpa;

        }

        public Student()
        {

        }
    }

}