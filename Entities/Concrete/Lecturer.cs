﻿using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Lecturer:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}