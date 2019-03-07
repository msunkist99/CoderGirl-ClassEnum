using System;
using System.Collections.Generic;

namespace ClassEnum
{
    public static class Program
    {
        public static void Main()
        {
            List<StudentClass> students = new List<StudentClass>()
            {
                {new StudentClass() {LastName = "Smith", FirstName = "Abby", Grade = 1, GPA = 3.25, StudentFirstNamesEnum = Student.Abby } },
                {new StudentClass() {LastName = "Wallen", FirstName = "Alex", Grade = 2, GPA = 2.5, StudentFirstNamesEnum = Student.Alex} },
                {new StudentClass() {LastName = "Jones", FirstName = "Lauren", Grade = 8, GPA = 2, StudentFirstNamesEnum = Student.Lauren } },
                {new StudentClass() {LastName = "Star", FirstName = "Drew", Grade = 9, GPA = 3.75, StudentFirstNamesEnum = Student.Drew } },
                {new StudentClass() {LastName = "Jordan", FirstName = "Sara", Grade = 10, GPA = 4, StudentFirstNamesEnum = Student.Sara } },
                {new StudentClass() {LastName = "Barnes", FirstName = "Cameron", Grade = 11, GPA = 3.5, StudentFirstNamesEnum= Student.Cameron} },
                {new StudentClass() {LastName = "Pointer", FirstName = "Linsey", Grade = 10, GPA = 3, StudentFirstNamesEnum = Student.Lindsey } },
                {new StudentClass() {LastName = "Fletcher", FirstName = "Ashley", Grade = 9, GPA = 3.25, StudentFirstNamesEnum = Student.Ashley } },
                {new StudentClass() {LastName = "Williams", FirstName = "Jaden", Grade = 11, GPA = 2.75, StudentFirstNamesEnum = Student.Jaden } },
                {new StudentClass() {LastName = "Duck", FirstName = "Donald", Grade = 11, GPA = 2.75, StudentFirstNamesEnum = Student.Donald } },
                {new StudentClass() {LastName = "Mouse", FirstName = "Mickey", Grade = 11, GPA = 2.75, StudentFirstNamesEnum = Student.Mickey } },
                {new StudentClass() {LastName = "Powers", FirstName = "Danielle", Grade = 10, GPA = 2.25, StudentFirstNamesEnum = Student.Danielle } }
            };

            Console.WriteLine(GetFirstName(Student.Abby));
            Console.WriteLine();

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(GetFirstName(students[i].StudentFirstNamesEnum));
            }
            Console.ReadLine();
        }

        public static string GetFirstName(Student studentFirstName)
        {
            switch (studentFirstName)
            {
                case Student.NoName:
                    return "No Name";
                case Student.Abby:
                    return "Smith";
                case Student.Alex:
                    return "Wallen";
                case Student.Lauren:
                    return "Jones";
                case Student.Drew:
                    return "Star";
                case Student.Sara:
                    return "Jordan";
                case Student.Cameron:
                    return "Barnes";
                case Student.Lindsey:
                    return "Pointer";
                case Student.Ashley:
                    return "Fletcher";
                case Student.Jaden:
                    return "Williams";
                case Student.Danielle:
                    return "Powers";
                case Student.Donald:
                    return "Duck";
                case Student.Mickey:
                    return "Mouse";
                default:
                    return "You entered bad input";
            }
        }
    }

}
