﻿using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class City :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Lecturer> Lecturers { get; set; }
    }
}
