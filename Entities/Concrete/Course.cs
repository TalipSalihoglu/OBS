namespace Entities.Concrete
{
    public class Course
    {
        public Guid Id{ get; set; }
        public string Name{ get; set; }

        public Guid LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}