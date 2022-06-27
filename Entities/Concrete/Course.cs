using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Course:IEntity
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Description{ get; set; }
        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}