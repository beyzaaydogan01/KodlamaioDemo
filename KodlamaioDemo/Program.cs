using KodlamaioDemo.Business.Abstracts;
using KodlamaioDemo.Business.Concretes;
using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.DataAccess.Concretes;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICategoryManager categoryManager = new CategoryManager(new CategoryDal());
            var categories = categoryManager.GetAll();

            if (categories != null)
            {
                foreach (var category in categories)
                {
                    Console.WriteLine($"Category Id: {category.Id}, Name: {category.CategoryName}");

                }
            }

            Console.WriteLine("**********************************************");
      
            ICourseManager courseManager = new CourseManager(new CourseDal());
            var courses = courseManager.GetAll();

            if (courses != null)
            {
                foreach (var course in courses)
                {
                    Console.WriteLine($"Id: {course.Id}, Category Id: {course.CategoryId}, " +
                        $"Course Name: {course.CourseName}, Description: {course.Description}, Price: {course.Price}");
                }
            }

            Console.WriteLine("**********************************************");


            IInstructorManager instructorManager = new InstructorManager(new InstructorDal());
            var instructors = instructorManager.GetAll();

            if (instructors != null)
            {
                foreach (var instructor in instructors)
                {
                    Console.WriteLine($"Id: {instructor.Id}, First Name: {instructor.FirstName}, " +
                        $"Last Name: {instructor.LastName}, E Mail: {instructor.Email}");
                }
            }

            Console.ReadLine();

        }

     
    }

    
}
