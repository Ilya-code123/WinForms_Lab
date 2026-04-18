namespace StudentApp.Models
{
    public class Student
    {
        public string FullName { get; set; } = "";
        public string Group { get; set; } = "";
        public decimal AvgGrade { get; set; }
        public bool HasScholarship { get; set; }

        public override string ToString() => $"{FullName} ({Group})";
    }
}
