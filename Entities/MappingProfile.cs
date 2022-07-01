using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.CourseDtos;
using Entities.Dtos.ExamDtos;
using Entities.Dtos.LecturerDtos;
using Entities.Dtos.StudentCourseDtos;
using Entities.Dtos.StudentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateStudentDto, Student>();  
            CreateMap<UpdateStudentDto, Student>();

            CreateMap<CreateLecturerDto, Lecturer>();
            CreateMap<UpdateLecturerDto, Lecturer>();

            CreateMap<CreateCourseDto, Course>();

            CreateMap<UpdateExamDto, Exam>();
            CreateMap<CreateExamDto, Exam>();

            CreateMap<CreateStudentCourseDto,StudentCourse>(); 

        }
    }
}
