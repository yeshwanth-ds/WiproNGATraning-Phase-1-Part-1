using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    internal class Student
    {
        public string Name { get; set; }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }

    internal class EngineeringStudent : Student
    {
        public string Specialization { get; set; }

        public void DisplaySpecialization()
        {
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }

    internal class MedicalStudent : Student
    {
        public string Hospital { get; set; }

        public void DisplayHospitalInfo()
        {
            Console.WriteLine($"Intern at: {Hospital}");
        }
    }
}
