namespace Quiz7.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Student
    {
        public  int ID { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        
    }

    public class StudentCourse
    {
        public int ID { get; set; }
        public int StdID { get; set; }
        public virtual Student Std { get; set; }
        public int CrsID { get; set; }
        public virtual Course Crs { get; set; }
    }
}