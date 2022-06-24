using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Course:IEntity
    {
        public Guid Id{ get; set; }
        public string Name{ get; set; }

        public Guid LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}