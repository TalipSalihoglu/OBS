﻿using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public int StudentNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FullAddress { get; set; }
        public DateTime CreatedDate { get; set; }

        public int DepartmentId { get; set; }
        public Department Department{ get; set; }

        public int CityId { get; set; }
        public City City{ get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Exam> ExamList { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
