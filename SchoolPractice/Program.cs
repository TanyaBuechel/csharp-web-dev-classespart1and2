using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student tanya = new Student("Tanya", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + tanya.Name + " is a student!");

            Teacher scott = new Teacher("Scott", "Kuhl", "C#", 5);
            Console.WriteLine("The Teacher class works! " + scott.FirstName + " is a teacher!");

        }
    }
}
