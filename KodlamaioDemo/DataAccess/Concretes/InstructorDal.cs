using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;


        public InstructorDal()
        { 
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";
            instructor1.Email = "engindemirog@gmail";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";
            instructor2.Email = "eneskalayci@gmail";

            _instructors = new List<Instructor> {instructor1,instructor2};

        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.FirstOrDefault(i =>  i.Id == instructor.Id);
            if (instructorToUpdate != null)
            {
                instructorToUpdate.FirstName = instructor.FirstName;
            }
        }
        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructors.FirstOrDefault(i => i.Id == instructor.Id);
            if (instructorToDelete != null)
            {
                _instructors.Remove(instructorToDelete);
            }
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

    }
}
