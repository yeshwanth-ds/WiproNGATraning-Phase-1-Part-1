using MultipleInheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        ScholarStudent scholar = new ScholarStudent();
        scholar.Name = "Rohan";

        scholar.DisplayStudentInfo();
        scholar.DisplayScholarshipInfo();
        scholar.DisplayPlacementInfo();
    }
}