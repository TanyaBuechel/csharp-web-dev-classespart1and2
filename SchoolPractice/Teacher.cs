using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeacher { get; set; }

        public Teacher(string firstName, string lastName, string subject, int yearsTeacher)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeacher = yearsTeacher;
        }
    }
}
