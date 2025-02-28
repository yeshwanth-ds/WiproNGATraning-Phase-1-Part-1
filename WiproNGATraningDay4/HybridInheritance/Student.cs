using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridInheritance
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

    internal interface IResearcher
    {
        void DisplayResearchTopic();
    }

    // Hybrid: Inherits from CollegeStudent and Implements IResearcher
    internal class PhDStudent : CollegeStudent, IResearcher
    {
        public string ResearchTopic { get; set; }

        public void DisplayResearchTopic()
        {
            Console.WriteLine($"Research Topic: {ResearchTopic}");
        }
    }

}
