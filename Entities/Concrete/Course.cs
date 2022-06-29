using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public ICollection<Student> Students { get; set; }


        public int LecturerId { get; set; }
        public Lecturer Lecturer { get; set; }

        //ICollection<Course> Courses { get; set; }
    }
}
