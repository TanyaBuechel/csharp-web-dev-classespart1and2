using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; }
    }
}
