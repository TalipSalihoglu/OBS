using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Exam:IEntity
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid StudentId { get; set; }
        public decimal Midterm { get; set; } 
        public decimal Final { get; set; } 
    }
}