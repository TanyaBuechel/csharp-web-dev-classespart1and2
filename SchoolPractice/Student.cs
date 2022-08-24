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

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate fields: NumberOfCredits, Gpa
            //Reference fields with PropertyNames
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (credits <= 29)
            {
                return "Freshman";
            }
            else if (credits <= 59)
            {
                return "Sophomore";
            }
            else if (credits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Name == student.Name &&
                   StudentId == student.StudentId &&
                   NumberOfCredits == student.NumberOfCredits &&
                   Gpa == student.Gpa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId, NumberOfCredits, Gpa);
        }
    }

}
