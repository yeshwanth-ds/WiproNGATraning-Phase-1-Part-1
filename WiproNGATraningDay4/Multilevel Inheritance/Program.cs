using Multilevel_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        GraduateStudent gradStudent = new GraduateStudent();
        gradStudent.Name = "Yeshwanth D S";
        gradStudent.CollegeName = "XYZ University";
        gradStudent.Degree = "M.Sc. Quantum Computing";

        gradStudent.DisplayStudentInfo();
        gradStudent.DisplayCollegeInfo();
        gradStudent.DisplayDegreeInfo();
    }
}