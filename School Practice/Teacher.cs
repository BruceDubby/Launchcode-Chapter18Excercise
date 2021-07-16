using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Practice
{
    public class Teacher
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int yearsTeaching { get; set; }

        public Teacher(string fName, string lName, string subject, int yearsTeaching)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Subject = subject;
            this.yearsTeaching = yearsTeaching;
        }

        public Teacher()
        {

        }
    }
}