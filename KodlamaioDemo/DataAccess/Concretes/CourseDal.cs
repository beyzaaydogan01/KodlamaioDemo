using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{

    public class CourseDal : ICourseDal
    {

        List<Course> _courses;

        public CourseDal()
        {

            Course course1 = new Course();
            course1.Id = 1;
            course1.CategoryId = 1;
            course1.CourseName = "C#";
            course1.Description = "C# Yazılım Geliştirme";
            course1.Price = 100;

            Course course2 = new Course();
            course2.Id = 2;
            course2.CategoryId = 2;
            course2.CourseName = "Sql";
            course2.Description = "Sql Veritabanı Eğitimi";
            course2.Price = 90;


            _courses = new List<Course> {course1,course2};
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }
        public void Update(Course course)
        {
            Course courseToUpdate = _courses.FirstOrDefault(c => c.Id == course.Id);
            if (courseToUpdate != null)
            {
                courseToUpdate.CourseName = course.CourseName;
            }
        }
        public void Delete(Course course)
        {
            Course courseToDelete = _courses.FirstOrDefault(c => c.Id == course.Id);
            if(courseToDelete != null)
            {
                _courses.Remove(courseToDelete);
            }
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        
    }
}
