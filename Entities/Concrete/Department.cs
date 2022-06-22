namespace Entities.Concrete
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Lecturer> Lecturers{get;set;}
        public virtual ICollection<Student> Students{get;set;}
    }
}