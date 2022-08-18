using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        //Private variable to hold nextStudentId - static means it can be called out of scope
        private static int nextStudentId = 1;

        //Auto-implemented properties
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        //Student property with name, studentId, numberOfCredits, gpa constructors
        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        //Student property with default constructors for credits and gpa
        public Student(string name, int studentId) : this(name, studentId, 0, 0) { }

        // :this - invokes another constructor within the same class; adds to student ID
        public Student(string name) : this(name, nextStudentId)
        {
            nextStudentId++;
        }
    }
}
