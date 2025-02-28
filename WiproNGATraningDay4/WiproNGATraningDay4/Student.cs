using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproNGATraningDay4
{
    internal class Student
    {
        
        
            public string Name { get; set; }

            public void DisplayStudentInfo()
            {
                Console.WriteLine($"Student Name: {Name}");
            }
        }

        // Derived class inheriting from Student (Single Inheritance)
        internal class CollegeStudent : Student
        {
            public string CollegeName { get; set; }

            public void DisplayCollegeInfo()
            {
                Console.WriteLine($"College: {CollegeName}");
            }
        }
}
