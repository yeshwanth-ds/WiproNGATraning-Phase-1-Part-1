using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_Inheritance
{
    internal class Student
    {
        public string Name { get; set; }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }

    internal class CollegeStudent : Student
    {
        public string CollegeName { get; set; }

        public void DisplayCollegeInfo()
        {
            Console.WriteLine($"College: {CollegeName}");
        }
    }

    // Another derived class from CollegeStudent (Multilevel Inheritance)
    internal class GraduateStudent : CollegeStudent
    {
        public string Degree { get; set; }

        public void DisplayDegreeInfo()
        {
            Console.WriteLine($"Degree: {Degree}");
        }
    }
    }
