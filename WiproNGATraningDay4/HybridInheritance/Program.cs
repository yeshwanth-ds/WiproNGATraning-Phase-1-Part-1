using HybridInheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        PhDStudent phdStudent = new PhDStudent();
        phdStudent.Name = "Sneha";
        phdStudent.CollegeName = "IIT Bombay";
        phdStudent.ResearchTopic = "Quantum Computing Algorithms";

        phdStudent.DisplayStudentInfo();
        phdStudent.DisplayCollegeInfo();
        phdStudent.DisplayResearchTopic();
    }
}