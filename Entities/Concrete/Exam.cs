using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Exam : IEntity
    {
        public int Id { get; set; }
        public decimal Midterm { get; set; }
        public decimal Final { get; set; }

        public int? StudentId{ get; set; }
        public Student Student{ get; set; }

        public int CourseId { get; set; }
        public Course Courses { get; set; }
    }
}
