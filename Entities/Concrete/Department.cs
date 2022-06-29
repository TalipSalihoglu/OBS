using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Department :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        ICollection<Student> Students { get; set; }
        ICollection<Lecturer> Lecturers{ get; set; }

    }
}
