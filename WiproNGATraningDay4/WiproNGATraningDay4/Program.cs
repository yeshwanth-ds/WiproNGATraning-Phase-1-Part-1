using WiproNGATraningDay4;

internal class Program
{
    private static void Main(string[] args)
    {
        CollegeStudent student = new CollegeStudent();
        student.Name = "Yeshwanth D S";
        student.CollegeName = "ABC University";

        student.DisplayStudentInfo();
        student.DisplayCollegeInfo();
    }
}