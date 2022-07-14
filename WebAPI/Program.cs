using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using AutoMapper;
using WebAPI.Middlewares;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Core.Utilities.Jwt;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = true,
        ValidateIssuer = true,
        ValidateLifetime =true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Token:Issuer"],
        ValidAudience = builder.Configuration["Token:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Token:SecurityKey"])),
        ClockSkew = TimeSpan.Zero
    };
});


builder.Services.AddCors(options =>
     options.AddDefaultPolicy(builder =>
     builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

//builder.Host.UseSerilog((ctx, lc) => lc
//    .WriteTo.File("log.json"));

var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);


builder.Services.AddControllers().AddNewtonsoftJson(options =>
  options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddSingleton<IJwtUtils, JwtUtils>();
builder.Services.AddSingleton<IStudentService, StudentManager>();
builder.Services.AddSingleton<IStudentDal, StudentDal>();
builder.Services.AddSingleton<ILecturerService, LecturerManager>();
builder.Services.AddSingleton<ILecturerDal, LecturerDal>();
builder.Services.AddSingleton<ICourseService,CourseManager>();
builder.Services.AddSingleton<ICourseDal, CourseDal>();
builder.Services.AddSingleton<IExamService,ExamManager>();
builder.Services.AddSingleton<IExamDal, ExamDal>();
builder.Services.AddSingleton<IStudentCourseService, StudentCourseManager>();
builder.Services.AddSingleton<IStudentCourseDal, StudentCourseDal>();
builder.Services.AddSingleton<IUserDal, UserDal>();
builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IDepartmentDal, DepartmentDal>();
builder.Services.AddSingleton<IDepartmentService, DepartmentManager>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCustomExceptionMiddleware();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseCors();
app.UseAuthorization();
app.UseMiddleware<JwtMiddleware>();


app.MapControllers();

app.Run();
