using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EntityFrameworkExample.Data
{
    public class SchoolInit : CreateDatabaseIfNotExists<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student {
                    FirstName = "Carson",
                    LastName = "Alexander",
                    Birthday = DateTime.Parse("2005-09-01")
                },
                new Student {
                    FirstName = "Meredith",
                    LastName = "Alonso",
                    Birthday = DateTime.Parse("2002-09-01")
                }
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();


            var courses = new List<Course>
            {
                new Course {
                    CourseId = 1050,
                    Title = "Chemistry",
                    Credits = 3
                },
                new Course {
                    CourseId = 1045,
                    Title = "Calculus",
                    Credits =4,
                },
                new Course {
                    CourseId = 2042,
                    Title = "Literature",
                    Credits = 4,
                }
            };

            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();


            var enrollments = new List<Enrollment>
            {
                new Enrollment {
                    StudentId = 1,
                    CourseId = 1050,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentId = 1,
                    CourseId = 2042,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentId = 2,
                    CourseId = 1045,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentId = 2,
                    CourseId = 2042,
                    Grade = Grade.F
                },
            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}