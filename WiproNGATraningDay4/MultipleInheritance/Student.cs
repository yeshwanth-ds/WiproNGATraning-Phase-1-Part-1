using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Student
    {
        public string Name { get; set; }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
        }
    }

    // First interface
    internal interface IScholarship
    {
        void DisplayScholarshipInfo();
    }

    // Second interface
    internal interface IPlacement
    {
        void DisplayPlacementInfo();
    }

    // Derived class implementing multiple interfaces
    internal class ScholarStudent : Student, IScholarship, IPlacement
    {
        public void DisplayScholarshipInfo()
        {
            Console.WriteLine("Received Full Scholarship");
        }

        public void DisplayPlacementInfo()
        {
            Console.WriteLine("Placed in Google");
        }
    }
}
