using System;
using System.Collections.Generic;


namespace School_Practice
{
    
    public class Program
    { 
        public static void Main(string[] args)
        {
            Student breon = new Student("Breon", 1, 4.0);// TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Course course1 = new Course();

            //course1.Title = new List<string> ();

            
            Teacher teach = new Teacher("Allister", "Thomas","Chemistry", 20);

            string titleString = "";
            foreach(var title in course1.Title)
            {
                titleString +=" " + title;
            }
            Console.WriteLine($"Student name: {breon.Name}\nCredits: {breon.NumberOfCredits}\nGPA: {breon.Gpa}");
            Console.WriteLine($"\nTeacher name: {teach.FirstName}\nSubject: {teach.Subject}\nYears teaching: {teach.yearsTeaching}");

            Console.WriteLine($"\nCourse Designator: {course1.CourseDes}\nTitles: {titleString.Trim()}\nCredit: {course1.Credits}");
        }
    
    }

    
}