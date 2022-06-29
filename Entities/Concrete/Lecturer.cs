using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Lecturer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullAddress { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}
