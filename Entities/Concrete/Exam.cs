using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Exam:IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public decimal Midterm { get; set; } 
        public decimal Final { get; set; } 
    }
}