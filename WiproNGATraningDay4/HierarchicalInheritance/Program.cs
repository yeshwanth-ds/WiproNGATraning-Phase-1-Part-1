using HierarchicalInheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        EngineeringStudent engStudent = new EngineeringStudent();
        engStudent.Name = "Raj";
        engStudent.Specialization = "Artificial Intelligence";
        engStudent.DisplayStudentInfo();
        engStudent.DisplaySpecialization();

        MedicalStudent medStudent = new MedicalStudent();
        medStudent.Name = "Ananya";
        medStudent.Hospital = "ABC Hospital";
        medStudent.DisplayStudentInfo();
        medStudent.DisplayHospitalInfo();
    }
}