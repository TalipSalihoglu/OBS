﻿using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Lecturer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string FullAddress { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}