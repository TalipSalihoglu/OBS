using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options =>
  options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddSingleton<IStudentService, StudentManager>();
builder.Services.AddSingleton<IStudentDal, StudentDal>();
builder.Services.AddSingleton<ILecturerService, LecturerManager>();
builder.Services.AddSingleton<ILecturerDal, LecturerDal>();
builder.Services.AddSingleton<ICourseService,CourseManager>();
builder.Services.AddSingleton<ICourseDal, CourseDal>();
builder.Services.AddSingleton<IExamService,ExamManager>();
builder.Services.AddSingleton<IExamDal, ExamDal>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
