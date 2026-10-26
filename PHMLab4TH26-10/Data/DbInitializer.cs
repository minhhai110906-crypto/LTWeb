using Microsoft.EntityFrameworkCore;
using PHMLab4TH26_10.Models;

namespace PHMLab4TH26_10.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SchoolContext(
                serviceProvider.GetRequiredService<DbContextOptions<SchoolContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Majors.Any())
                {
                    return;
                }

                var majors = new Major[]
                {
                    new Major { MajorName = "CNTT" },
                    new Major { MajorName = "Kinh tế" },
                    new Major { MajorName = "Cơ điện tử" }
                };
                foreach (var major in majors)
                {
                    context.Majors.Add(major);
                }
                context.SaveChanges();

                var learners = new Learner[]
                {
                    new Learner { FirstMidName = "Carson", LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01"), MajorID = 1 },
                    new Learner { FirstMidName = "Meredith", LastName = "Alonso", EnrollmentDate = DateTime.Parse("2002-09-01"), MajorID = 2 }
                };
                foreach (var l in learners)
                {
                    context.Learners.Add(l);
                }
                context.SaveChanges();

                var courses = new Course[]
                {
                    new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
                    new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3 },
                    new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3 }
                };
                foreach (var c in courses)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();

                var enrollments = new Enrollment[]
                {
                    new Enrollment { LearnerID = 1, CourseID = 1050, Grade = 5.5f },
                    new Enrollment { LearnerID = 1, CourseID = 4022, Grade = 7.5f },
                    new Enrollment { LearnerID = 2, CourseID = 1050, Grade = 3.5f },
                    new Enrollment { LearnerID = 2, CourseID = 4041, Grade = 7f }
                };
                foreach (var e in enrollments)
                {
                    context.Enrollments.Add(e);
                }
                context.SaveChanges();
            }
        }
    }
}