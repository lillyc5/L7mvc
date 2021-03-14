namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-lillyc5-dykstra1] - added the grades that will be implemented
    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2021-03-13-lillyc5-dykstra1] - created the variables used throughout program
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}