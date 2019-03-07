using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEnum
{
    public class StudentClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _grade;
        private double _gpa;

        public int Grade
        {
            get { return _grade; }

            set
            {
                if ((value < 1) || (value > 12))
                {
                    _grade = 0;
                }
                else
                {
                    _grade = value;
                };
            }
        }

        public double GPA
        {
            get { return _gpa; }

            set
            {
                if ((value < 1) || (value > 4))
                {
                    _gpa = 0;
                }
                else
                {
                    _gpa = value;
                }
            }
        }

        public Student StudentFirstNamesEnum { get; set; }

    }
    public enum Student
    {
        NoName = 0,
        Abby,
        Alex,
        Lauren,
        Drew,
        Sara,
        Cameron,
        Lindsey,
        Ashley,
        Jaden,
        Danielle,
        Donald,
        Mickey
    }
}
